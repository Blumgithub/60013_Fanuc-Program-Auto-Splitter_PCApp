using System.Diagnostics;
using System.IO;

namespace Choose_FilePath_Form
{
    public partial class Form1 : Form
    {
        private string selectedFilePath;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Select a Text File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = openFileDialog.FileName;
                    textBox1.Text = selectedFilePath;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show("Please select an Input file.", "File Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string exePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appl", "Split-FANUC-Program-Backup.exe");

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = exePath,
                    Arguments = $"\"{selectedFilePath}\"",
                    UseShellExecute = true
                };

                Process.Start(startInfo);
                Process.Start("explorer.exe", $"/select,\"{selectedFilePath}\"");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                Environment.Exit(0);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
