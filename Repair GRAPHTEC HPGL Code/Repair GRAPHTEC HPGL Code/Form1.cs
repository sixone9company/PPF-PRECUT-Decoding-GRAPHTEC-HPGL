using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Repair_GRAPHTEC_HPGL_Code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = FilterContent(textBox1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Plot Files (*.plt;*.gl;*.bin;*.pcapng;*.txt)|*.plt;*.gl;*.bin;*.pcapng;*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                try
                {
                    // Start Notepad and open the selected file
                    ProcessStartInfo processStartInfo = new ProcessStartInfo("notepad.exe", selectedFilePath);
                    Process notepadProcess = Process.Start(processStartInfo);

                    // Wait for the Notepad process to be idle
                    notepadProcess.WaitForInputIdle();

                    // Wait for the Notepad window to be activated
                    while (notepadProcess.MainWindowTitle == "")
                    {
                        Thread.Sleep(100);
                        notepadProcess.Refresh();
                    }

                    // Send Ctrl+A to select all text in Notepad
                    SendKeys.SendWait("^a");

                    // Send Ctrl+C to copy the selected text
                    SendKeys.SendWait("^c");

                    // Wait for the clipboard to have data
                    while (!Clipboard.ContainsText())
                    {
                        Thread.Sleep(100);
                    }

                    // Get the text from the clipboard
                    string fileContent = Clipboard.GetText();

                    // Display the file content in TextBox
                    textBox1.Text = fileContent;

                    // Close Notepad
                    notepadProcess.CloseMainWindow();
                    notepadProcess.WaitForExit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // create a SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // set file filter
            saveFileDialog.Filter = "Plot Files (*.plt)|*.plt";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            // display a dialog box for saving files
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // get selected file address
                string fileName = saveFileDialog.FileName;

                // save data from TextBox2 to file
                File.WriteAllText(fileName, textBox2.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Clear data in TextBox1 and TextBox2
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private string FilterContent(string content)
        {
            string pattern = @"(PU[^\s]*|PD|PU|PA|PR|IN|!PG0|[0-9]|,|;)+";
            string filteredContent = "";
            MatchCollection matches = Regex.Matches(content, pattern);

            bool foundPA = false;
            foreach (Match match in matches)
            {
                string value = match.Value.Trim();

                if (!foundPA && !value.StartsWith("PU"))
                {
                    continue;
                }
                else if (value.StartsWith("PU"))
                {
                    foundPA = true;
                }

                filteredContent += value + " ";
            }

            if (!foundPA)
            {
                return "";
            }

            return filteredContent.Trim();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutBox1 aboutForm = new AboutBox1();
            aboutForm.ShowDialog();
        }
    }
}