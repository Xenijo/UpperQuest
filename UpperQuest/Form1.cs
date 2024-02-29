using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpperQuest
{
    public partial class Form1 : Form
    {
        private string adbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "adb", "adb.exe");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshDeviceList();
            devicefullratecapturelabel.Text = "Full Rate Capture:";
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(devicefullratecapturelabel, "Enable/disable full rate capture for the camera recording.");


        }

        bool DebugMode = true ;
        private void RefreshDeviceList()
        {
            devicesListBox.Items.Clear();

            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = adbPath,
                Arguments = "devices",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = DebugMode
            };

            using (Process process = Process.Start(processStartInfo))
            {
                while (!process.StandardOutput.EndOfStream)
                {
                    string line = process.StandardOutput.ReadLine();
                    if (line.Contains('\t') && line.EndsWith("device"))
                    {
                        string deviceId = line.Split('\t')[0];
                        devicesListBox.Items.Add(deviceId);
                    }
                }
            }
        }

        private void DisplayDeviceInfo(string deviceId)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = adbPath,
                Arguments = $"-s {deviceId} shell getprop",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = DebugMode
            };

            using (Process process = Process.Start(processStartInfo))
            {
                string output = process.StandardOutput.ReadToEnd();
                string[] lines = output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string line in lines)
                {
                    if (line.StartsWith("[ro.product.model]"))
                    {
                        string deviceName = line.Split(':')[1].Trim();
                        labelDeviceName.Text = deviceName;
                    }
                    else if (line.StartsWith("[debug.oculus.cpuLevel]"))
                    {
                        string cpuLevel = line.Split(':')[1].Trim();
                        labelCpuLevel.Text = FormatPropertyValue(cpuLevel);
                    }
                    else if (line.StartsWith("[debug.oculus.gpuLevel]"))
                    {
                        string gpuLevel = line.Split(':')[1].Trim();
                        labelGpuLevel.Text = FormatPropertyValue(gpuLevel);
                    }
                    else if (line.StartsWith("[debug.oculus.textureWidth]"))
                    {
                        string textureWidth = line.Split(':')[1].Trim();
                        labelTextureWidth.Text = FormatPropertyValue(textureWidth);
                    }
                    else if (line.StartsWith("[debug.oculus.textureHeight]"))
                    {
                        string textureHeight = line.Split(':')[1].Trim();
                        labelTextureHeight.Text = FormatPropertyValue(textureHeight);
                    }
                    else if (line.StartsWith("[debug.oculus.capture.bitrate]"))
                    {
                        string bitrate = line.Split(':')[1].Trim();
                        devicebitratelabel.Text = FormatPropertyValue(bitrate);
                    }
                    else if (line.StartsWith("[debug.oculus.capture.width]"))
                    {
                        string width = line.Split(':')[1].Trim();
                        devicecapturewidthlabel.Text = FormatPropertyValue(width);
                    }
                    else if (line.StartsWith("[debug.oculus.capture.height]"))
                    {
                        string height = line.Split(':')[1].Trim();
                        devicecaptureheightlabel.Text = FormatPropertyValue(height);
                    }
                    else if (line.StartsWith("[debug.oculus.fullRateCapture]"))
                    {
                        string fullratecaptures = line.Split(':')[1].Trim();
                        devicefullratecapturelabel.Text = FormatPropertyValue(fullratecaptures); // Update label for full rate capture
                    }
                }
            }
        }

        private string FormatPropertyValue(string value)
        {
            return string.IsNullOrWhiteSpace(value) ? "Default" : $"[{value}]";
        }

        private void ChangeDeviceInformation(string deviceId, string propertyName, string propertyValue)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = adbPath,
                Arguments = $"-s {deviceId} shell setprop {propertyName} {propertyValue}",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = DebugMode
            };

            using (Process process = Process.Start(processStartInfo))
            {
                process.WaitForExit();
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (devicesListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a device from the list.", "No Device Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string deviceId = devicesListBox.SelectedItem.ToString();
            string propertyName;
            string propertyValue;

            if (radioButtonGPU.Checked)
            {
                propertyName = "debug.oculus.gpuLevel";
                propertyValue = textBoxPropertyValue.Text;
                if (!IsValidPropertyValue(propertyValue, 4))
                {
                    MessageBox.Show("Invalid GPU level. Please enter a value between 0 and 4.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (radioButtonCPU.Checked)
            {
                propertyName = "debug.oculus.cpuLevel";
                propertyValue = textBoxPropertyValue.Text;
                if (!IsValidPropertyValue(propertyValue, 4))
                {
                    MessageBox.Show("Invalid CPU level. Please enter a value between 0 and 4.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (radioButtonTexture.Checked)
            {
                propertyName = "debug.oculus.textureWidth";
                propertyValue = textBoxPropertyValue.Text;
                if (!IsValidPropertyValue(propertyValue, 2048))
                {
                    MessageBox.Show("Invalid texture size. Please enter a value between 0 and 2048.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                ChangeDeviceInformation(deviceId, "debug.oculus.textureHeight", propertyValue);
            }
            else if (fullRateCapture.Checked)
            {
                propertyName = "debug.oculus.fullRateCapture";
                propertyValue = textBoxPropertyValue.Text; // The value here should be either 0 or 1, representing off or on
                if (!IsValidPropertyValue(propertyValue, 1))
                {
                    MessageBox.Show("Invalid full rate capture value. Please enter either 0 or 1.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (capturew.Checked)
            {
                propertyName = "debug.oculus.capture.width";
                propertyValue = textBoxPropertyValue.Text;
                if (!IsValidPropertyValue(propertyValue, int.MaxValue))
                {
                    MessageBox.Show($"Invalid width value. Please enter a value between 0 and {int.MaxValue}.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (captureh.Checked)
            {
                propertyName = "debug.oculus.capture.height";
                propertyValue = textBoxPropertyValue.Text;
                if (!IsValidPropertyValue(propertyValue, int.MaxValue))
                {
                    MessageBox.Show($"Invalid height value. Please enter a value between 0 and {int.MaxValue}.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (bitrate.Checked)
            {
                propertyName = "debug.oculus.capture.bitrate";
                propertyValue = textBoxPropertyValue.Text;
                if (!IsValidPropertyValue(propertyValue, int.MaxValue))
                {
                    MessageBox.Show($"Invalid bitrate value. Please enter a value between 0 and {int.MaxValue}.", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select a property to change.", "No Property Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ChangeDeviceInformation(deviceId, propertyName, propertyValue);
            MessageBox.Show("Device information changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisplayDeviceInfo(deviceId);
        }

        private void devicesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (devicesListBox.SelectedItem != null)
            {
                string deviceId = devicesListBox.SelectedItem.ToString();
                DisplayDeviceInfo(deviceId);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshDeviceList();
        }

        private bool IsValidPropertyValue(string value, int maxValue)
        {
            if (!int.TryParse(value, out int intValue))
            {
                return false;
            }
            return intValue >= 0 && intValue <= maxValue;
        }

        private void buttonBrowseApk_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "APK files (*.apk)|*.apk";
            openFileDialog.Title = "Select an APK file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxApkFilePath.Text = openFileDialog.FileName;
            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxApkFilePath.Text))
            {
                MessageBox.Show("Please select an APK file first.", "No APK Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string apkFilePath = textBoxApkFilePath.Text;

            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = adbPath,
                Arguments = $"install \"{apkFilePath}\"",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = DebugMode
            };

            using (Process process = Process.Start(processStartInfo))
            {
                string output = process.StandardOutput.ReadToEnd();
                MessageBox.Show(output, "Installation Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void GetLogs_Click(object sender, EventArgs e)
        {
            if (devicesListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a device from the list.", "No Device Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string deviceId = devicesListBox.SelectedItem.ToString();
            string logsFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs", DateTime.Now.ToString("yyyy-MM-dd"));

            // Create the logs folder if it doesn't exist
            Directory.CreateDirectory(logsFolderPath);

            string logsFilePath = Path.Combine(logsFolderPath, $"Logs_{DateTime.Now.ToString("HH-mm-ss")}.txt");

            DownloadLogs(deviceId, logsFilePath);

            MessageBox.Show("Logs downloaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DownloadLogs(string deviceId, string logsFilePath)
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = adbPath,
                Arguments = $"-s {deviceId} logcat -d",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = DebugMode
            };

            using (Process process = Process.Start(processStartInfo))
            {
                if (process != null)
                {
                    using (StreamWriter writer = new StreamWriter(logsFilePath))
                    {
                        writer.Write(process.StandardOutput.ReadToEnd());
                    }
                }
            }
        }

        private async void DiscordDownloadButton_Click(object sender, EventArgs e)
        {
            // URL of the APK file
            string apkDownloadUrl = "https://drive.usercontent.google.com/download?id=11d0zv4TF55pKtP5zvXlomLALsJOJQxyA&export=download&authuser=0&confirm=t&uuid=59ae0d27-936a-4acc-8a22-decf10ccac37&at=APZUnTUaAvNaZjaYhlYKa74CHb-I%3A1708453352994";

            // Path to store the downloaded APK file
            string apkFilePath = Path.Combine(Path.GetTempPath(), "Discord.apk");

            using (WebClient webClient = new WebClient())
            {
                try
                {
                    // Download the APK file
                    await DownloadApkAsync(webClient, apkDownloadUrl, apkFilePath);
                    MessageBox.Show("APK file downloaded successfully.", "Download Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Install the APK on the Oculus Quest
                    InstallApkOnQuest(apkFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while downloading the APK file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task DownloadApkAsync(WebClient webClient, string apkDownloadUrl, string apkFilePath)
        {
            // Download the APK file asynchronously
            await webClient.DownloadFileTaskAsync(new Uri(apkDownloadUrl), apkFilePath);
        }

        private void InstallApkOnQuest(string apkFilePath)
        {
            // Check if ADB is available
            if (!File.Exists(adbPath))
            {
                MessageBox.Show("ADB executable not found. Please make sure it's correctly configured.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Install the APK on the Oculus Quest using ADB
            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = adbPath,
                Arguments = $"install \"{apkFilePath}\"",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(processStartInfo))
            {
                if (process != null)
                {
                    string output = process.StandardOutput.ReadToEnd();
                    MessageBox.Show(output, "Installation Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

    }
}
