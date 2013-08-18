using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISETool8
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadConfig();

            btnProgress.Image = (Image)rm.GetObject("run");
            btnLock.Image = (Image)rm.GetObject("_lock");

        }

        ResourceManager rm = new ResourceManager("ISETool8.Properties.Resources", Assembly.GetExecutingAssembly());

        #region Configs
        private RegistryKey setting;
        private const string DownloadDir = "DownloadDir";
        private const string GUID = "GUID";
        private const string UploadDir = "DestDir";
        private const string ActionType = "ActionType";
        private const string DeviceIndex = "DeviceIndex";
        private void SaveConfig()
        {
            setting = Registry.CurrentUser.CreateSubKey("Software\\ISEToolHelper");
            setting.SetValue(DownloadDir, this.tbDownloadPath.Text);
            setting.SetValue(GUID, this.tbGUID.Text);
            setting.SetValue(UploadDir, this.tbUploadPath.Text);

            if (this.rbDownload.Checked)
            {
                setting.SetValue(ActionType, 0);
            }
            else if (this.rbUpload.Checked)
            {
                setting.SetValue(ActionType, 1);
            }
            else
            {
                setting.SetValue(ActionType, 2);
            }

            setting.SetValue(DeviceIndex, GetDeviceIndex());
        }

        private void LoadConfig()
        {
            setting = Registry.CurrentUser.CreateSubKey("Software\\ISEToolHelper");
            tbDownloadPath.Text = setting.GetValue(DownloadDir, "") as string;
            tbGUID.Text = setting.GetValue(GUID, "") as string;
            tbUploadPath.Text = setting.GetValue(UploadDir, "") as string;

            int action = (int)setting.GetValue(ActionType, 0);
            if (action == 0)
            {
                rbDownload.Checked = true;
            }
            else if (action == 1)
            {
                rbUpload.Checked = true;
            }
            else
            {
                rbListInfo.Checked = true;
            }

            int deviceindex = (int)setting.GetValue(DeviceIndex, 0);
            if (deviceindex == 0)
            {
                radioButton0.Checked = true;
            }
            else if (deviceindex == 1)
            {
                radioButton1.Checked = true;
            }
            else if (deviceindex == 2)
            {
                radioButton2.Checked = true;
            }
            else if (deviceindex == 3)
            {
                radioButton3.Checked = true;
            }
            else if (deviceindex == 4)
            {
                radioButton4.Checked = true;
            }
            else if (deviceindex == 5)
            {
                radioButton5.Checked = true;
            }
            else
            {
                radioButton6.Checked = true;
            }
        }
        #endregion

        private void btnDownload_Click(object sender, EventArgs e)
        {
            folderBrowserDialogDownload.ShowDialog();
            tbDownloadPath.Text = folderBrowserDialogDownload.SelectedPath;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            folderBrowserDialogUpload.ShowDialog();
            tbUploadPath.Text = folderBrowserDialogUpload.SelectedPath;
        }

        private int GetDeviceIndex()
        {
            int deviceindex = 0;
            if (radioButton0.Checked)
            {
                deviceindex = 0;
            }
            else if (radioButton1.Checked)
            {
                deviceindex = 1;
            }
            else if (radioButton2.Checked)
            {
                deviceindex = 2;
            }
            else if (radioButton3.Checked)
            {
                deviceindex = 3;
            }
            else if (radioButton4.Checked)
            {
                deviceindex = 4;
            }
            else if (radioButton5.Checked)
            {
                deviceindex = 5;
            }
            else
            {
                deviceindex = 6;
            }
            return deviceindex;
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            Run();
        }

        private bool Run()
        {
            string cmd = "";
            if (rbDownload.Checked)
            {
                cmd = "ts deviceindex:" + GetDeviceIndex() + " " + tbGUID.Text.Trim() + " " + tbDownloadPath.Text.Trim();
            }
            else if (rbListInfo.Checked)
            {
                cmd = "dir:\\IsolatedStore\\ deviceindex:" + GetDeviceIndex() + " " + tbGUID.Text.Trim();
            }
            else
            {
                cmd = "rs deviceindex:" + GetDeviceIndex() + " " + tbGUID.Text.Trim() + " " + tbDownloadPath.Text.Trim();
            }
            Process process = new Process();
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.CreateNoWindow = true;
                processStartInfo.UseShellExecute = false;
                processStartInfo.RedirectStandardOutput = true;
                processStartInfo.RedirectStandardError = true;
                processStartInfo.FileName = System.IO.Directory.GetCurrentDirectory() + "\\ISETool.exe";
                processStartInfo.Arguments = cmd;
                process.StartInfo = processStartInfo;
                process.Start();
                while (!process.HasExited)
                {
                    string text = process.StandardOutput.ReadToEnd();
                    if (text != null)
                    {
                        int index = text.IndexOf("ISETool - Help");
                        if (index > -1)
                        {
                            text = text.Substring(0, index);
                        }
                        if (text.StartsWith("Error: The application is not installed."))
                        {
                            Log("错误：找不到应用程序，请确保安装了应用程序");
                            return false;
                        }

                        if (text=="\r\nDone.\r\n\r\n")
                        {
                            Log("操作成功");
                            return false;
                        }

                        if (this.rbListInfo.Checked)
                        {
                            if (text.StartsWith("Command Parameters"))
                            {
                                Log("操作失败\r\n");
                                return false;
                            }
                            if (text.StartsWith("Directory Listing Error"))
                            {
                                Log(text);
                                return false;
                            }                            
                            Log(text);
                            return true;
                        }
                        else
                        {
                            if (text.StartsWith("Command Parameters"))
                            {
                                Log("操作失败");
                                return false;
                            }
                            if (text.StartsWith("Download Error") || text.StartsWith("Upload Error"))
                            {
                                Log(text);
                                return false;
                            }
                            if (text.StartsWith("Download Successful") || text.StartsWith("Upload Successful"))
                            {
                                Log(text);
                                return true;
                            }
                            Log(text);
                        }
                    }
                }
            }
            finally
            {
                process.Close();
            }
            return true;
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (btnProgress.Enabled)
            {
                LockOrUnlock(false);
                btnProgress.Enabled = false;
                btnLock.Text = "锁定参数";
                btnLock.Image = (Image)rm.GetObject("_lock");
                return;
            }
            if (CheckValue())
            {
                SaveConfig();
                LockOrUnlock(true);
                btnProgress.Enabled = true;
                btnLock.Text = "解锁参数";
                btnLock.Image = (Image)rm.GetObject("unlock");
                return;
            }
        }

        private void Log(string text)
        {
            tbLog.AppendText(text + "\r\n");
            tbLog.ScrollToCaret();
        }

        private bool CheckValue()
        {
            bool result = true;

            if (string.IsNullOrEmpty(tbGUID.Text))
            {
                Log("参数错误 : 请输入程序GUID");
                return false;
            }

            if (rbDownload.Checked && string.IsNullOrEmpty(tbDownloadPath.Text))
            {
                Log("参数错误 : 请选择下载目录");
                return false;
            }

            if (rbUpload.Checked && string.IsNullOrEmpty(tbUploadPath.Text))
            {
                Log("参数错误 : 请选择上传目录");
                return false;
            }

            if (!File.Exists("ISETool.exe"))
            {
                Log("参数错误 : 当前目录下ISETool工具不存在");
                return false;
            }

            string[] array = this.tbGUID.Text.Split(new char[] { '-' });
            if (array.Length != 5)
            {
                Log("参数错误 : GUID格式错误。");
                return false;
            }
            if (array[0].Length != 8 || array[1].Length != 4 || array[2].Length != 4 || array[3].Length != 4 || array[4].Length != 12)
            {
                Log("参数错误 : GUID格式错误。");
                return false;
            }
            return result;
        }

        private void LockOrUnlock(bool isLock)
        {
            this.tbDownloadPath.ReadOnly = isLock;
            this.tbGUID.ReadOnly = isLock;
            this.tbUploadPath.ReadOnly = isLock;

            this.rbDownload.Enabled = !isLock;
            this.rbUpload.Enabled = !isLock;
            this.rbListInfo.Enabled = !isLock;

            this.radioButton0.Enabled = !isLock;
            this.radioButton1.Enabled = !isLock;
            this.radioButton2.Enabled = !isLock;
            this.radioButton3.Enabled = !isLock;
            this.radioButton4.Enabled = !isLock;
            this.radioButton5.Enabled = !isLock;
            this.radioButton6.Enabled = !isLock;
        }

        /*
        * Syntax: 
ISETool.exe <cmd[:param]> <target-device[:param]> <product-id> [<desktop-path>]

  <cmd[:param]> - Specifies the command to be executed (one of the following)
    ts                - (takesnapshot) to download the contents of isolated
                        store from <target-device> to desktop
    rs                - (restoresnapshot) to upload the contents of isolated
                        store from desktop to <target-device>
    dir[:device-path] - lists the contents of the device folder or root
                        if not mentioned
    EnumerateDevices  - lists the valid device targets along with their
                        device indices.

  <target-device[:param]> - Specifies the target device (one of the following)
    xd                - default emulator
    de                - Windows Phone device connected to the desktop
    deviceindex:n     - device listed at index n. To get the list of devices
                        use the following command
                         "ISETool EnumerateDevices"

  <product-id> - Specifies the GUID of the product. This is located in
                 WMAppManifest.xml file of the project

  <desktop-path> - desktop path for download and upload

Examples: (assuming product id is f8ce6878-0aeb-497f-bcf4-65be961d4bba)

ISETool.exe ts xd f8ce6878-0aeb-497f-bcf4-65be961d4bba c:\data\myfiles
      - downloads the isolated store content of application specified by
        product id from default emulator to c:\data\myfiles folder

ISETool.exe rs de f8ce6878-0aeb-497f-bcf4-65be961d4bba c:\data\myfiles
      - uploads all files from c:\data\myfiles on desktop to the isolated
        store of application specified by product on Windows Phone device

ISETool.exe rs deviceindex:2 f8ce6878-0aeb-497f-bcf4-65be961d4bba c:\data\myfiles
      - uploads all files from c:\data\myfiles on desktop to the device
        specified by device index 2. To get the list of valid indices use
        the EnumerateDevices command

ISETool.exe EnumerateDevices
      - enumerates the list of valid device targets along with their
        corresponding device index

ISETool.exe dir:\MyPictures\Images\ deviceindex:2 f8ce6878-0aeb-497f-bcf4-65be961d4bba
      - lists the contents of \MyPictures\Images\ in device at index 2
             * */
    }
}
