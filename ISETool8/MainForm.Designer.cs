namespace ISETool8
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbGUID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDownloadPath = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.gbDevice = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton0 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbListInfo = new System.Windows.Forms.RadioButton();
            this.rbUpload = new System.Windows.Forms.RadioButton();
            this.rbDownload = new System.Windows.Forms.RadioButton();
            this.labelUpload = new System.Windows.Forms.Label();
            this.btnUpload = new System.Windows.Forms.Button();
            this.tbUploadPath = new System.Windows.Forms.TextBox();
            this.btnProgress = new System.Windows.Forms.Button();
            this.folderBrowserDialogDownload = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogUpload = new System.Windows.Forms.FolderBrowserDialog();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLock = new System.Windows.Forms.Button();
            this.gbDevice.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "程序GUID";
            // 
            // tbGUID
            // 
            this.tbGUID.Location = new System.Drawing.Point(75, 22);
            this.tbGUID.Name = "tbGUID";
            this.tbGUID.Size = new System.Drawing.Size(405, 21);
            this.tbGUID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "下载路径";
            // 
            // tbDownloadPath
            // 
            this.tbDownloadPath.Location = new System.Drawing.Point(75, 55);
            this.tbDownloadPath.Name = "tbDownloadPath";
            this.tbDownloadPath.Size = new System.Drawing.Size(302, 21);
            this.tbDownloadPath.TabIndex = 3;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(383, 53);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(97, 23);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "...";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // gbDevice
            // 
            this.gbDevice.Controls.Add(this.radioButton3);
            this.gbDevice.Controls.Add(this.radioButton6);
            this.gbDevice.Controls.Add(this.radioButton5);
            this.gbDevice.Controls.Add(this.radioButton4);
            this.gbDevice.Controls.Add(this.radioButton2);
            this.gbDevice.Controls.Add(this.radioButton1);
            this.gbDevice.Controls.Add(this.radioButton0);
            this.gbDevice.Location = new System.Drawing.Point(497, 22);
            this.gbDevice.Name = "gbDevice";
            this.gbDevice.Size = new System.Drawing.Size(171, 196);
            this.gbDevice.TabIndex = 5;
            this.gbDevice.TabStop = false;
            this.gbDevice.Text = "选择设备";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(21, 101);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(101, 16);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.Tag = "3";
            this.radioButton3.Text = "Emulator WXGA";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(21, 171);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(95, 16);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.Tag = "6";
            this.radioButton6.Text = "Emulator 7.1";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(21, 149);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(125, 16);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.Tag = "5";
            this.radioButton5.Text = "Emulator 7.1 256M";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(21, 125);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(101, 16);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.Tag = "4";
            this.radioButton4.Text = "Emulator 720P";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(21, 77);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 16);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Tag = "2";
            this.radioButton2.Text = "Emulator WVGA";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(131, 16);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Tag = "1";
            this.radioButton1.Text = "Emulator WVGA 512M";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton0
            // 
            this.radioButton0.AutoSize = true;
            this.radioButton0.Checked = true;
            this.radioButton0.Location = new System.Drawing.Point(21, 30);
            this.radioButton0.Name = "radioButton0";
            this.radioButton0.Size = new System.Drawing.Size(59, 16);
            this.radioButton0.TabIndex = 0;
            this.radioButton0.TabStop = true;
            this.radioButton0.Tag = "0";
            this.radioButton0.Text = "Device";
            this.radioButton0.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbListInfo);
            this.groupBox1.Controls.Add(this.rbUpload);
            this.groupBox1.Controls.Add(this.rbDownload);
            this.groupBox1.Location = new System.Drawing.Point(18, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 95);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作类型";
            // 
            // rbListInfo
            // 
            this.rbListInfo.AutoSize = true;
            this.rbListInfo.Location = new System.Drawing.Point(166, 28);
            this.rbListInfo.Name = "rbListInfo";
            this.rbListInfo.Size = new System.Drawing.Size(143, 16);
            this.rbListInfo.TabIndex = 2;
            this.rbListInfo.Text = "查看应用程序目录信息";
            this.rbListInfo.UseVisualStyleBackColor = true;
            // 
            // rbUpload
            // 
            this.rbUpload.AutoSize = true;
            this.rbUpload.Location = new System.Drawing.Point(22, 65);
            this.rbUpload.Name = "rbUpload";
            this.rbUpload.Size = new System.Drawing.Size(107, 16);
            this.rbUpload.TabIndex = 1;
            this.rbUpload.Text = "上传至应用程序";
            this.rbUpload.UseVisualStyleBackColor = true;
            // 
            // rbDownload
            // 
            this.rbDownload.AutoSize = true;
            this.rbDownload.Checked = true;
            this.rbDownload.Location = new System.Drawing.Point(22, 28);
            this.rbDownload.Name = "rbDownload";
            this.rbDownload.Size = new System.Drawing.Size(83, 16);
            this.rbDownload.TabIndex = 0;
            this.rbDownload.TabStop = true;
            this.rbDownload.Text = "下载至本地";
            this.rbDownload.UseVisualStyleBackColor = true;
            // 
            // labelUpload
            // 
            this.labelUpload.AutoSize = true;
            this.labelUpload.Location = new System.Drawing.Point(16, 90);
            this.labelUpload.Name = "labelUpload";
            this.labelUpload.Size = new System.Drawing.Size(53, 12);
            this.labelUpload.TabIndex = 7;
            this.labelUpload.Text = "上传路径";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(383, 85);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(97, 23);
            this.btnUpload.TabIndex = 9;
            this.btnUpload.Text = "...";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // tbUploadPath
            // 
            this.tbUploadPath.Location = new System.Drawing.Point(75, 87);
            this.tbUploadPath.Name = "tbUploadPath";
            this.tbUploadPath.Size = new System.Drawing.Size(302, 21);
            this.tbUploadPath.TabIndex = 8;
            // 
            // btnProgress
            // 
            this.btnProgress.Enabled = false;
            this.btnProgress.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProgress.Location = new System.Drawing.Point(383, 184);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(97, 28);
            this.btnProgress.TabIndex = 10;
            this.btnProgress.Text = "执行操作";
            this.btnProgress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProgress.UseVisualStyleBackColor = true;
            this.btnProgress.Click += new System.EventHandler(this.btnProgress_Click);
            // 
            // tbLog
            // 
            this.tbLog.BackColor = System.Drawing.SystemColors.Menu;
            this.tbLog.Location = new System.Drawing.Point(0, 20);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(650, 267);
            this.tbLog.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbLog);
            this.groupBox2.Location = new System.Drawing.Point(18, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 287);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "日志信息";
            // 
            // btnLock
            // 
            this.btnLock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLock.Location = new System.Drawing.Point(383, 129);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(97, 28);
            this.btnLock.TabIndex = 11;
            this.btnLock.Text = "锁定参数";
            this.btnLock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 519);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.btnProgress);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.tbUploadPath);
            this.Controls.Add(this.labelUpload);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbGUID);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.gbDevice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDownloadPath);
            this.Name = "MainForm";
            this.Text = "ISETool for Windows Phone 8";
            this.gbDevice.ResumeLayout(false);
            this.gbDevice.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGUID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDownloadPath;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.GroupBox gbDevice;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbUpload;
        private System.Windows.Forms.RadioButton rbDownload;
        private System.Windows.Forms.Label labelUpload;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox tbUploadPath;
        private System.Windows.Forms.Button btnProgress;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDownload;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogUpload;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.RadioButton rbListInfo;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

