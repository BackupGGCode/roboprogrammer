using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace RoboProgrammer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        RoboProgrammerClass roboProgrammer = null;

        private enum StatusMoves
        {
            Loading = 0, Programming, Unloading, Dumping
        }

        private class StatusReport
        {
            private DateTime _currentJobStart;
            private DateTime _allJobsStart;
            private int _currentJobTimeCostInSeconds;

            private string _currentProfileName = "";
            private string _currentFileName = "";

            private int _currentJobID = 0;
            private int _currentJobPiecesDone = 0;
            private int _currentJobPieces = 0;

            private int _allJobsPiecesDone = 0;

            private string _nowDoing = "";

            public string CurrentProfileName
            {
                get { return _currentProfileName; }
            }

            public string CurrentFileName
            {
                get { return _currentFileName; }
            }

            public int CurrentJobID
            {
                get { return _currentJobID; }
            }

            public string CurrentJobElapsedTime
            {
                get { return DateTime.Now.Subtract(_currentJobStart).ToString(); }
            }

            public string CurrentJobRemainingTime
            {
                get { return new TimeSpan(0, 0, ((_currentJobPieces - _currentJobPiecesDone) * _currentJobTimeCostInSeconds)).ToString(); }
            }

            public string CurrentJobPiecesDone
            {
                get { return _currentJobPiecesDone.ToString(); }
            }

            public string CurrentJobPieces
            {
                get { return _currentJobPieces.ToString(); }
            }

            public string AllJobsPiecesDone
            {
                get { return _allJobsPiecesDone.ToString(); }
            }

            public string AllJobsElapsedTime
            {
                get { return DateTime.Now.Subtract(_allJobsStart).ToString(); }
            }

            public string DoingStatus
            {
                get { return _nowDoing; }
            }

            public StatusReport()
            {

            }

            public void StartNewJob(string aProfileName, int aProfileID, string aFileName, int aPieces)
            {
                //If Starting Now
                if (_currentProfileName == "")
                    _allJobsStart = DateTime.Now;

                _currentProfileName = aProfileName;
                _currentJobID = aProfileID;
                _currentFileName = aFileName;
                _currentJobStart = DateTime.Now;
                _currentJobPiecesDone = 0;
                _currentJobPieces = aPieces;
            }

            public void AnotherPieceDone()
            {
                if (_currentJobPiecesDone == 0)
                    _currentJobTimeCostInSeconds = DateTime.Now.Subtract(_currentJobStart).Seconds;
                _currentJobPiecesDone++;
                _allJobsPiecesDone++;
            }

            public void NowDoing(StatusMoves move)
            {
                switch (move)
                {
                    case StatusMoves.Loading: _nowDoing = "Loading New Chip...";
                        break;
                    case StatusMoves.Programming: _nowDoing = "Programming Chip...";
                        break;
                    case StatusMoves.Unloading: _nowDoing = "Unloading Chip...";
                        break;
                    case StatusMoves.Dumping: _nowDoing = "Dumping Chip...";
                        break;
                    default:
                        break;
                }
            }
        }

        DataSet dsProfiles;

        private void MoveListViewItem(ref ListView lv, bool moveUp)
        {
            string cache;
            int selIdx;

            selIdx = lv.SelectedItems[0].Index;
            if (moveUp)
            {
                // ignore moveup of row(0)
                if (selIdx == 0)
                    return;

                // move the subitems for the previous row
                // to cache to make room for the selected row
                for (int i = 0; i < lv.Items[selIdx].SubItems.Count; i++)
                {
                    cache = lv.Items[selIdx - 1].SubItems[i].Text;
                    lv.Items[selIdx - 1].SubItems[i].Text =
                      lv.Items[selIdx].SubItems[i].Text;
                    lv.Items[selIdx].SubItems[i].Text = cache;
                }
                lv.Items[selIdx - 1].Selected = true;
                lv.Refresh();
                lv.Focus();
            }
            else
            {
                // ignore movedown of last item
                if (selIdx == lv.Items.Count - 1)
                    return;
                // move the subitems for the next row
                // to cache so we can move the selected row down
                for (int i = 0; i < lv.Items[selIdx].SubItems.Count; i++)
                {
                    cache = lv.Items[selIdx + 1].SubItems[i].Text;
                    lv.Items[selIdx + 1].SubItems[i].Text =
                      lv.Items[selIdx].SubItems[i].Text;
                    lv.Items[selIdx].SubItems[i].Text = cache;
                }
                lv.Items[selIdx + 1].Selected = true;
                lv.Refresh();
                lv.Focus();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                listView1.SelectedItems[i].Remove();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GUIStartOfThread()
        {
            buttonPlay.Enabled = false;
            buttonStop.Enabled = true;
            comboBoxPort.Enabled = false;
            comboBoxProgPort.Enabled = false;
            pictureBoxWorking.Visible = true;

            tabControl1.SelectedTab = tabStatus;

            foreach (Control ctrl in tabAddJob.Controls)
            {
                ctrl.Enabled = false;
            }

            foreach (Control ctrl in tabJobs.Controls)
            {
                ctrl.Enabled = false;
            }
        }

        private void GUIEndOfThread()
        {
            buttonPlay.Enabled = true;
            buttonStop.Enabled = false;
            comboBoxPort.Enabled = true;
            comboBoxProgPort.Enabled = true;
            pictureBoxWorking.Visible = false;

            tabControl1.SelectedTab = tabJobs;

            foreach (Control ctrl in tabAddJob.Controls)
            {
                ctrl.Enabled = true;
            }

            foreach (Control ctrl in tabJobs.Controls)
            {
                ctrl.Enabled = true;
            }
        }

        string sProgrammerPort = "";
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (comboBoxPort.SelectedIndex < 0)
            {
                MessageBox.Show("You have to select a Com Port!");
                return;
            }

            try
            {
                if (roboProgrammer == null)
                    roboProgrammer = new RoboProgrammerClass();
                roboProgrammer.Port = comboBoxPort.Text;
                roboProgrammer.Reboot();
                roboProgrammer.TryToID();
                sProgrammerPort = comboBoxProgPort.Text;
                GUIStartOfThread();
                ListViewItem[] arr = new ListViewItem[listView1.CheckedItems.Count];
                listView1.CheckedItems.CopyTo(arr, 0);
                backgroundWorker1.RunWorkerAsync(arr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStop.Enabled = false;
            backgroundWorker1.CancelAsync();
            MessageBox.Show("Please wait for the process to terminate...");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonPlay.Enabled = true;
            buttonStop.Enabled = false;
            pictureBoxWorking.Visible = false;

            linkLabel1.Links.Add(0, linkLabel1.Text.Length, linkLabel1.Text);

            comboBoxPort.Items.Clear();
            comboBoxPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());

            comboBoxProgPort.Items.Clear();
            comboBoxProgPort.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());

            dsProfiles = new DataSet("profiles");
            dsProfiles.ReadXml(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\profiles.xml");

            comboBoxProfile.DataSource = dsProfiles.Tables["profiles"];
            comboBoxProfile.DisplayMember = "name";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            if (MessageBox.Show("Are you sure you want to quit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                if (buttonStop.Enabled)
                    buttonStop_Click(null, null);
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textBoxFile.Text = openFileDialog1.FileName;
        }

        private void buttonProfiles_Click(object sender, EventArgs e)
        {
            ProfilesForm pf = new ProfilesForm();
            pf.ds = dsProfiles;
            pf.Show();
        }

        private void comboBoxProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tmp = (string)((comboBoxProfile.SelectedItem as DataRowView)["file"]);
            if (tmp != "")
                textBoxFile.Text = tmp;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if ((textBoxPieces.Text.Equals(string.Empty)) || (int.Parse(textBoxPieces.Text) < 1))
                return;
            listView1.Items.Add(new ListViewItem(new string[] { comboBoxProfile.Text, textBoxFile.Text, textBoxPieces.Text }) { Checked = true });
            comboBoxProfile.Text = textBoxFile.Text = textBoxPieces.Text = "";
            tabControl1.SelectedTab = tabJobs;
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            MoveListViewItem(ref listView1, true);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            buttonEdit_Click(null, null);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1)
                return;
            ListViewItem lvi = listView1.SelectedItems[0];
            comboBoxProfile.Text = lvi.SubItems[0].Text;
            textBoxFile.Text = lvi.SubItems[1].Text;
            textBoxPieces.Text = lvi.SubItems[2].Text;

            tabControl1.SelectedTab = tabAddJob;
            listView1.SelectedItems[0].Remove();
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            MoveListViewItem(ref listView1, false);
        }

        private void textBoxPieces_KeyPress(object sender, KeyPressEventArgs e)
        {
            int isNumber = 0;
            e.Handled = !(int.TryParse(e.KeyChar.ToString(), out isNumber) || e.KeyChar == 0x08);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private bool RunProgrammer(string aCommandLine, string aArguments)
        {
            try
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = aCommandLine;
                psi.Arguments = aArguments;
                psi.WorkingDirectory = System.IO.Path.GetDirectoryName(aCommandLine);
                //psi.WindowStyle = ProcessWindowStyle.Hidden;
                using (Process process = new Process())
                {
                    process.StartInfo = psi;
                    //process.EnableRaisingEvents = true;
                    //process.Exited += (s, ea) =>
                    //{

                    //};
                    process.Start();
                    process.WaitForExit(3 * 60 * 1000); //3 minute timeout
                    //process.Close();
                    if (process.ExitCode != 0)
                    {
                        return false;
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            ListViewItem[] arr = (e.Argument as ListViewItem[]);
            StatusReport status = new StatusReport();
            int progress = 0;
            int jobIndex = 0;

            try
            {
                foreach (ListViewItem ci in arr)
                {
                    if (backgroundWorker1.CancellationPending)
                        break;

                    int count = int.Parse(ci.SubItems[2].Text);
                    int progressMul = 100 / count;

                    status.StartNewJob(ci.SubItems[0].Text, jobIndex, ci.SubItems[1].Text, count);
                    backgroundWorker1.ReportProgress(progress, status);
                    for (int i = 0; i < count; i++)
                    {
                        if (backgroundWorker1.CancellationPending)
                            break;

                        string command = "";
                        string commandArgs = "";
                        try
                        {
                            dsProfiles.Tables["profiles"].DefaultView.RowFilter = string.Format("name = '{0}'", ci.SubItems[0].Text);
                            command = (string)dsProfiles.Tables["profiles"].DefaultView[0]["commandline"];
                            commandArgs = (string)dsProfiles.Tables["profiles"].DefaultView[0]["arguments"];
                            commandArgs = commandArgs.Replace("{f}", ci.SubItems[1].Text);
                            commandArgs = commandArgs.Replace("{F}", ci.SubItems[1].Text);
                            commandArgs = commandArgs.Replace("{p}", sProgrammerPort);
                            commandArgs = commandArgs.Replace("{P}", sProgrammerPort);
                        }
                        finally
                        {
                            dsProfiles.Tables["profiles"].DefaultView.RowFilter = "";
                        }

                        status.NowDoing(StatusMoves.Loading);
                        backgroundWorker1.ReportProgress(progress, status);
                        roboProgrammer.LoadChip();

                        status.NowDoing(StatusMoves.Programming);
                        backgroundWorker1.ReportProgress(progress, status);
                        if (RunProgrammer(command, commandArgs))
                        {
                            status.NowDoing(StatusMoves.Unloading);
                            backgroundWorker1.ReportProgress(progress, status);
                            roboProgrammer.UnloadChip();
                        }
                        else
                        {
                            status.NowDoing(StatusMoves.Unloading);
                            backgroundWorker1.ReportProgress(progress, status);
                            roboProgrammer.DumpChip();
                        }

                        status.AnotherPieceDone();
                        progress = (i + 1) * progressMul;
                        backgroundWorker1.ReportProgress(progress, status);
                    }
                    Thread.Sleep(1000);
                    jobIndex++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            roboProgrammer.SerialClose();
            GUIEndOfThread();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            StatusReport sts = (e.UserState as StatusReport);

            labelProfile.Text = "Profile: " + sts.CurrentProfileName;
            labelFile.Text = "File: " + sts.CurrentFileName;
            labelPiece.Text = string.Format("Piece {0} of {1}", sts.CurrentJobPiecesDone, sts.CurrentJobPieces);
            labelElapsed.Text = "Elapsed Time: " + sts.CurrentJobElapsedTime;
            labelRemaining.Text = "Remaining Time (approx): " + sts.CurrentJobRemainingTime;

            labelPieceTotal.Text = "Pieces Done: " + sts.AllJobsPiecesDone;
            labelElapsedTotal.Text = "Elapsed Time: " + sts.AllJobsElapsedTime;

            ListViewItem lvi = listView1.Items[sts.CurrentJobID];
            lvi.SubItems[2].Text = (int.Parse(sts.CurrentJobPieces) - int.Parse(sts.CurrentJobPiecesDone)).ToString();
            if (lvi.SubItems[2].Text == "0")
                lvi.Checked = false;

            labelNowDoing.Text = sts.DoingStatus;

            progressBarTotal.Value = e.ProgressPercentage;
        }
    }
}
