namespace RoboProgrammer
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
            this.comboBoxProfile = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPieces = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAddJob = new System.Windows.Forms.TabPage();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tabJobs = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnProfile = new System.Windows.Forms.ColumnHeader();
            this.columnFile = new System.Windows.Forms.ColumnHeader();
            this.columnPieces = new System.Windows.Forms.ColumnHeader();
            this.tabStatus = new System.Windows.Forms.TabPage();
            this.labelNowDoing = new System.Windows.Forms.Label();
            this.groupBoxAllJobs = new System.Windows.Forms.GroupBox();
            this.progressBarTotal = new System.Windows.Forms.ProgressBar();
            this.labelElapsedTotal = new System.Windows.Forms.Label();
            this.labelPieceTotal = new System.Windows.Forms.Label();
            this.groupBoxCurrentJob = new System.Windows.Forms.GroupBox();
            this.labelRemaining = new System.Windows.Forms.Label();
            this.labelElapsed = new System.Windows.Forms.Label();
            this.labelPiece = new System.Windows.Forms.Label();
            this.labelFile = new System.Windows.Forms.Label();
            this.labelProfile = new System.Windows.Forms.Label();
            this.pictureBoxWorking = new System.Windows.Forms.PictureBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonProfiles = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxProgPort = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabAddJob.SuspendLayout();
            this.tabJobs.SuspendLayout();
            this.tabStatus.SuspendLayout();
            this.groupBoxAllJobs.SuspendLayout();
            this.groupBoxCurrentJob.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWorking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile:";
            // 
            // comboBoxProfile
            // 
            this.comboBoxProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfile.FormattingEnabled = true;
            this.comboBoxProfile.Location = new System.Drawing.Point(97, 73);
            this.comboBoxProfile.Name = "comboBoxProfile";
            this.comboBoxProfile.Size = new System.Drawing.Size(190, 21);
            this.comboBoxProfile.TabIndex = 1;
            this.comboBoxProfile.SelectedIndexChanged += new System.EventHandler(this.comboBoxProfile_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "File:";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(97, 100);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(287, 20);
            this.textBoxFile.TabIndex = 3;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(390, 98);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(30, 23);
            this.buttonBrowse.TabIndex = 4;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Hex Files (*.hex)|*.hex|Bin Files (*.bin)|*.bin|All Files (*.*)|*.*";
            this.openFileDialog1.Title = "Open File...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pieces:";
            // 
            // textBoxPieces
            // 
            this.textBoxPieces.Location = new System.Drawing.Point(97, 126);
            this.textBoxPieces.Name = "textBoxPieces";
            this.textBoxPieces.Size = new System.Drawing.Size(41, 20);
            this.textBoxPieces.TabIndex = 6;
            this.textBoxPieces.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPieces_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAddJob);
            this.tabControl1.Controls.Add(this.tabJobs);
            this.tabControl1.Controls.Add(this.tabStatus);
            this.tabControl1.Location = new System.Drawing.Point(12, 270);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(466, 262);
            this.tabControl1.TabIndex = 5;
            // 
            // tabAddJob
            // 
            this.tabAddJob.Controls.Add(this.buttonAdd);
            this.tabAddJob.Controls.Add(this.buttonBrowse);
            this.tabAddJob.Controls.Add(this.textBoxPieces);
            this.tabAddJob.Controls.Add(this.label1);
            this.tabAddJob.Controls.Add(this.label3);
            this.tabAddJob.Controls.Add(this.comboBoxProfile);
            this.tabAddJob.Controls.Add(this.label2);
            this.tabAddJob.Controls.Add(this.textBoxFile);
            this.tabAddJob.Location = new System.Drawing.Point(4, 22);
            this.tabAddJob.Name = "tabAddJob";
            this.tabAddJob.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddJob.Size = new System.Drawing.Size(458, 236);
            this.tabAddJob.TabIndex = 0;
            this.tabAddJob.Text = "Add Job";
            this.tabAddJob.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = global::RoboProgrammer.Properties.Resources.AddTableHS;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(338, 193);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(95, 25);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // tabJobs
            // 
            this.tabJobs.Controls.Add(this.buttonDelete);
            this.tabJobs.Controls.Add(this.buttonEdit);
            this.tabJobs.Controls.Add(this.buttonDown);
            this.tabJobs.Controls.Add(this.buttonUp);
            this.tabJobs.Controls.Add(this.listView1);
            this.tabJobs.Location = new System.Drawing.Point(4, 22);
            this.tabJobs.Name = "tabJobs";
            this.tabJobs.Padding = new System.Windows.Forms.Padding(3);
            this.tabJobs.Size = new System.Drawing.Size(458, 236);
            this.tabJobs.TabIndex = 1;
            this.tabJobs.Text = "Jobs";
            this.tabJobs.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Image = global::RoboProgrammer.Properties.Resources.DeleteHS;
            this.buttonDelete.Location = new System.Drawing.Point(420, 188);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(32, 42);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Image = global::RoboProgrammer.Properties.Resources.EditInformationHS;
            this.buttonEdit.Location = new System.Drawing.Point(420, 140);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(32, 42);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Image = global::RoboProgrammer.Properties.Resources.FillDownHS;
            this.buttonDown.Location = new System.Drawing.Point(420, 54);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(32, 42);
            this.buttonDown.TabIndex = 2;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Image = global::RoboProgrammer.Properties.Resources.FillUpHS;
            this.buttonUp.Location = new System.Drawing.Point(420, 6);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(32, 42);
            this.buttonUp.TabIndex = 1;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonUp_Click);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProfile,
            this.columnFile,
            this.columnPieces});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(408, 224);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // columnProfile
            // 
            this.columnProfile.Text = "Profile";
            this.columnProfile.Width = 130;
            // 
            // columnFile
            // 
            this.columnFile.Text = "File";
            this.columnFile.Width = 200;
            // 
            // columnPieces
            // 
            this.columnPieces.Text = "Pieces";
            this.columnPieces.Width = 45;
            // 
            // tabStatus
            // 
            this.tabStatus.Controls.Add(this.labelNowDoing);
            this.tabStatus.Controls.Add(this.groupBoxAllJobs);
            this.tabStatus.Controls.Add(this.groupBoxCurrentJob);
            this.tabStatus.Location = new System.Drawing.Point(4, 22);
            this.tabStatus.Name = "tabStatus";
            this.tabStatus.Padding = new System.Windows.Forms.Padding(3);
            this.tabStatus.Size = new System.Drawing.Size(458, 236);
            this.tabStatus.TabIndex = 2;
            this.tabStatus.Text = "Status";
            this.tabStatus.UseVisualStyleBackColor = true;
            // 
            // labelNowDoing
            // 
            this.labelNowDoing.AutoSize = true;
            this.labelNowDoing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNowDoing.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelNowDoing.Location = new System.Drawing.Point(6, 215);
            this.labelNowDoing.Name = "labelNowDoing";
            this.labelNowDoing.Size = new System.Drawing.Size(95, 16);
            this.labelNowDoing.TabIndex = 2;
            this.labelNowDoing.Text = "Now Doing...";
            // 
            // groupBoxAllJobs
            // 
            this.groupBoxAllJobs.Controls.Add(this.progressBarTotal);
            this.groupBoxAllJobs.Controls.Add(this.labelElapsedTotal);
            this.groupBoxAllJobs.Controls.Add(this.labelPieceTotal);
            this.groupBoxAllJobs.Location = new System.Drawing.Point(6, 128);
            this.groupBoxAllJobs.Name = "groupBoxAllJobs";
            this.groupBoxAllJobs.Size = new System.Drawing.Size(446, 78);
            this.groupBoxAllJobs.TabIndex = 1;
            this.groupBoxAllJobs.TabStop = false;
            this.groupBoxAllJobs.Text = " All Jobs ";
            // 
            // progressBarTotal
            // 
            this.progressBarTotal.Location = new System.Drawing.Point(15, 45);
            this.progressBarTotal.Name = "progressBarTotal";
            this.progressBarTotal.Size = new System.Drawing.Size(414, 22);
            this.progressBarTotal.TabIndex = 5;
            // 
            // labelElapsedTotal
            // 
            this.labelElapsedTotal.AutoSize = true;
            this.labelElapsedTotal.Location = new System.Drawing.Point(12, 29);
            this.labelElapsedTotal.Name = "labelElapsedTotal";
            this.labelElapsedTotal.Size = new System.Drawing.Size(85, 13);
            this.labelElapsedTotal.TabIndex = 3;
            this.labelElapsedTotal.Text = "Elapsed Time: %";
            // 
            // labelPieceTotal
            // 
            this.labelPieceTotal.AutoSize = true;
            this.labelPieceTotal.Location = new System.Drawing.Point(12, 16);
            this.labelPieceTotal.Name = "labelPieceTotal";
            this.labelPieceTotal.Size = new System.Drawing.Size(82, 13);
            this.labelPieceTotal.TabIndex = 2;
            this.labelPieceTotal.Text = "Pieces Done: %";
            // 
            // groupBoxCurrentJob
            // 
            this.groupBoxCurrentJob.Controls.Add(this.labelRemaining);
            this.groupBoxCurrentJob.Controls.Add(this.labelElapsed);
            this.groupBoxCurrentJob.Controls.Add(this.labelPiece);
            this.groupBoxCurrentJob.Controls.Add(this.labelFile);
            this.groupBoxCurrentJob.Controls.Add(this.labelProfile);
            this.groupBoxCurrentJob.Location = new System.Drawing.Point(6, 6);
            this.groupBoxCurrentJob.Name = "groupBoxCurrentJob";
            this.groupBoxCurrentJob.Size = new System.Drawing.Size(446, 116);
            this.groupBoxCurrentJob.TabIndex = 0;
            this.groupBoxCurrentJob.TabStop = false;
            this.groupBoxCurrentJob.Text = " Current Job ";
            // 
            // labelRemaining
            // 
            this.labelRemaining.AutoSize = true;
            this.labelRemaining.Location = new System.Drawing.Point(12, 91);
            this.labelRemaining.Name = "labelRemaining";
            this.labelRemaining.Size = new System.Drawing.Size(97, 13);
            this.labelRemaining.TabIndex = 4;
            this.labelRemaining.Text = "Remaining Time: %";
            // 
            // labelElapsed
            // 
            this.labelElapsed.AutoSize = true;
            this.labelElapsed.Location = new System.Drawing.Point(12, 78);
            this.labelElapsed.Name = "labelElapsed";
            this.labelElapsed.Size = new System.Drawing.Size(85, 13);
            this.labelElapsed.TabIndex = 3;
            this.labelElapsed.Text = "Elapsed Time: %";
            // 
            // labelPiece
            // 
            this.labelPiece.AutoSize = true;
            this.labelPiece.Location = new System.Drawing.Point(12, 55);
            this.labelPiece.Name = "labelPiece";
            this.labelPiece.Size = new System.Drawing.Size(71, 13);
            this.labelPiece.TabIndex = 2;
            this.labelPiece.Text = "Piece: % of %";
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(12, 29);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(37, 13);
            this.labelFile.TabIndex = 1;
            this.labelFile.Text = "File: %";
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Location = new System.Drawing.Point(12, 16);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(50, 13);
            this.labelProfile.TabIndex = 0;
            this.labelProfile.Text = "Profile: %";
            // 
            // pictureBoxWorking
            // 
            this.pictureBoxWorking.Image = global::RoboProgrammer.Properties.Resources.ajax_loader;
            this.pictureBoxWorking.Location = new System.Drawing.Point(12, 538);
            this.pictureBoxWorking.Name = "pictureBoxWorking";
            this.pictureBoxWorking.Size = new System.Drawing.Size(68, 62);
            this.pictureBoxWorking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxWorking.TabIndex = 14;
            this.pictureBoxWorking.TabStop = false;
            // 
            // buttonExit
            // 
            this.buttonExit.Image = global::RoboProgrammer.Properties.Resources.HomeHS;
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(382, 577);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(96, 25);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonProfiles
            // 
            this.buttonProfiles.Image = global::RoboProgrammer.Properties.Resources.Book_angleHS;
            this.buttonProfiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProfiles.Location = new System.Drawing.Point(382, 538);
            this.buttonProfiles.Name = "buttonProfiles";
            this.buttonProfiles.Size = new System.Drawing.Size(96, 25);
            this.buttonProfiles.TabIndex = 8;
            this.buttonProfiles.Text = "Profiles...";
            this.buttonProfiles.UseVisualStyleBackColor = true;
            this.buttonProfiles.Click += new System.EventHandler(this.buttonProfiles_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Image = global::RoboProgrammer.Properties.Resources.StopHS;
            this.buttonStop.Location = new System.Drawing.Point(244, 538);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(64, 64);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Text = "Stop";
            this.buttonStop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Image = global::RoboProgrammer.Properties.Resources.PlayHS;
            this.buttonPlay.Location = new System.Drawing.Point(181, 538);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(64, 64);
            this.buttonPlay.TabIndex = 6;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // pictureBoxBanner
            // 
            this.pictureBoxBanner.Image = global::RoboProgrammer.Properties.Resources.dexter1;
            this.pictureBoxBanner.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxBanner.Name = "pictureBoxBanner";
            this.pictureBoxBanner.Size = new System.Drawing.Size(466, 200);
            this.pictureBoxBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBanner.TabIndex = 8;
            this.pictureBoxBanner.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(13, 219);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(166, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://dexterslabgr.blogspot.com/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(406, 216);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(72, 21);
            this.comboBoxPort.TabIndex = 2;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(286, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "RoboProgrammer Port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Programmer Port:";
            // 
            // comboBoxProgPort
            // 
            this.comboBoxProgPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProgPort.FormattingEnabled = true;
            this.comboBoxProgPort.Location = new System.Drawing.Point(406, 243);
            this.comboBoxProgPort.Name = "comboBoxProgPort";
            this.comboBoxProgPort.Size = new System.Drawing.Size(72, 21);
            this.comboBoxProgPort.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 612);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxProgPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxPort);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBoxWorking);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonProfiles);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.pictureBoxBanner);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "RoboProgrammer v1.2.5   by Dexter\'s Lab GR   (04-2010)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabAddJob.ResumeLayout(false);
            this.tabAddJob.PerformLayout();
            this.tabJobs.ResumeLayout(false);
            this.tabStatus.ResumeLayout(false);
            this.tabStatus.PerformLayout();
            this.groupBoxAllJobs.ResumeLayout(false);
            this.groupBoxAllJobs.PerformLayout();
            this.groupBoxCurrentJob.ResumeLayout(false);
            this.groupBoxCurrentJob.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWorking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPieces;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAddJob;
        private System.Windows.Forms.TabPage tabJobs;
        private System.Windows.Forms.PictureBox pictureBoxBanner;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.TabPage tabStatus;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonProfiles;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.ColumnHeader columnProfile;
        private System.Windows.Forms.ColumnHeader columnFile;
        private System.Windows.Forms.ColumnHeader columnPieces;
        private System.Windows.Forms.PictureBox pictureBoxWorking;
        private System.Windows.Forms.GroupBox groupBoxCurrentJob;
        private System.Windows.Forms.Label labelRemaining;
        private System.Windows.Forms.Label labelElapsed;
        private System.Windows.Forms.Label labelPiece;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.Label labelProfile;
        private System.Windows.Forms.GroupBox groupBoxAllJobs;
        private System.Windows.Forms.ProgressBar progressBarTotal;
        private System.Windows.Forms.Label labelElapsedTotal;
        private System.Windows.Forms.Label labelPieceTotal;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label labelNowDoing;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxProgPort;
    }
}

