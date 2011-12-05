using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RoboProgrammer
{
    public partial class ProfilesForm : Form
    {
        public ProfilesForm()
        {
            InitializeComponent();
        }

        bool _adding = false;
        public DataSet ds;

        private void WriteXmlToFile(DataSet aDataSet)
        {
            if (aDataSet == null)
                return;
            FileStream myFileStream = new FileStream(Path.GetDirectoryName(Application.ExecutablePath) + "\\profiles.xml", 
                                                     FileMode.Create);
            System.Xml.XmlTextWriter myXmlWriter = new System.Xml.XmlTextWriter(myFileStream, System.Text.Encoding.Unicode);
            aDataSet.WriteXml(myXmlWriter);
            myXmlWriter.Close();
        }

        private void buttonBrowse1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select Programmer...";
            openFileDialog1.Filter = "Executables (*.exe)|*.exe";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textBoxCommandLine.Text = openFileDialog1.FileName;
        }

        private void buttonBrowse2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select File To Burn...";
            openFileDialog1.Filter = "Hex Files (*.hex)|*.hex|Bin Files (*.bin)|*.bin|All Files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                textBoxFile.Text = openFileDialog1.FileName;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            ds.Tables["profiles"].Rows.RemoveAt(listBox1.SelectedIndex);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            _adding = true;
            textBoxName.Text = textBoxCommandLine.Text = textBoxArguments.Text = textBoxFile.Text = "";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _adding = false;
            textBoxName.Text = (string)(listBox1.SelectedItem as DataRowView)["name"];
            textBoxCommandLine.Text = (string)(listBox1.SelectedItem as DataRowView)["commandline"];
            textBoxArguments.Text = (string)(listBox1.SelectedItem as DataRowView)["arguments"];
            textBoxFile.Text = (string)(listBox1.SelectedItem as DataRowView)["file"];
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_adding)
            {
                ds.Tables["profiles"].Rows.Add(textBoxName.Text, textBoxCommandLine.Text, textBoxArguments.Text, textBoxFile.Text);
            }
            else
            {
                DataRowView drv = (listBox1.SelectedItem as DataRowView);
                drv["name"] = textBoxName.Text;
                drv["commandline"] = textBoxCommandLine.Text;
                drv["arguments"] = textBoxArguments.Text;
                drv["file"] = textBoxFile.Text;
            }
            ds.Tables["profiles"].AcceptChanges();

            textBoxName.Text = textBoxCommandLine.Text = textBoxArguments.Text = textBoxFile.Text = "";
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProfilesForm_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = ds.Tables["profiles"];
            listBox1.DisplayMember = "name";
        }

        private void ProfilesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            WriteXmlToFile(ds);
        }
    }
}
