using RamDisk;
using System.Diagnostics;

namespace RamDiskGUI
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            List<string> letters = ["A:\\", "B:\\", "C:\\", "D:\\", "E:\\", "F:\\", "G:\\", "H:\\", "I:\\", "J:\\", "K:\\", "L:\\", "M:\\", "N:\\", "O:\\", "P:\\", "Q:\\", "R:\\", "S:\\", "T:\\", "U:\\", "V:\\", "W:\\", "X:\\", "Y:\\", "Z:\\"];
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                letters.Remove(drive.Name);
            }
            diskLetterComboBox.Items.Clear();
            foreach (string letter in letters)
                diskLetterComboBox.Items.Add(letter);

            diskLetterComboBox.SelectedIndex = letters.IndexOf("R:\\") == -1 ? 0 : letters.IndexOf("R:\\");

            var MaxSpace = (int)((new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory) / ((ulong)Math.Pow(1024, 2)));
            diskSpaceNumeric.Maximum = MaxSpace;
            diskSpaceNumeric.Value = MaxSpace / 4;

            fileSystemComboBox.Items.Clear();
            fileSystemComboBox.Items.Add("NTFS");
            fileSystemComboBox.Items.Add("FAT32");
            fileSystemComboBox.Items.Add("FAT");
            fileSystemComboBox.Items.Add("exFAT");
            fileSystemComboBox.SelectedIndex = 0;

            clusterSizeComboBox.Items.Clear();
            string[] clusterSize = ["512", "1024", "2048", "4096", "8192", "16K", "32K", "64K", "128K", "256K", "512K", "1M", "2M"];
            foreach (var cs in clusterSize)
            {
                clusterSizeComboBox.Items.Add(cs);
            }
            clusterSizeComboBox.SelectedItem = "4096";
        }


        private void Mount(object sender, EventArgs e)
        {
            int space = (int)diskSpaceNumeric.Value;
            char letter = (char)diskLetterComboBox.SelectedItem.ToString()[0];
            string name = diskNameTextBox.Text == string.Empty ? diskNameTextBox.PlaceholderText : diskNameTextBox.Text;
            var fs = FileSystem.NTFS;
            int clusterSize = 4096;
            bool enableCompression = false, quickFormat = true;


            switch (fileSystemComboBox.SelectedItem.ToString())
            {
                case "NTFS":
                    fs = FileSystem.NTFS;
                    break;
                case "FAT32":
                    fs = FileSystem.FAT32;
                    break;
                case "FAT":
                    fs = FileSystem.FAT;
                    break;
                case "exFAT":
                    fs = FileSystem.exFAT;
                    break;
            }


            if (mountButton.Text == "Mount")
            {
                RamDrive.Mount(space, fs, letter, name);

                string fs1 = fileSystemComboBox.SelectedItem.ToString();
                try
                {
                    var di = new DriveInfo(letter + ":");
                    var psi = new ProcessStartInfo
                    {
                        FileName = "format.com",
                        CreateNoWindow = true, //if you want to hide the window
                        WorkingDirectory = Environment.SystemDirectory,
                        Arguments = "/FS:" + fs + " /Y" + " /V:" + name.Replace(' ', '_') + (quickFormat ? " /Q" : "") + ((fs1 == "NTFS" && enableCompression) ? " /C" : "") + " /A:" + clusterSize + " " + letter + ":",
                        UseShellExecute = false
                    };
                    psi.CreateNoWindow = true;
                    psi.RedirectStandardOutput = true;
                    psi.RedirectStandardInput = true;
                    var formatProcess = Process.Start(psi);
                    var swStandardInput = formatProcess.StandardInput;
                    swStandardInput.WriteLine();
                    formatProcess.WaitForExit();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }

                mountButton.Text = "Unmount";
                diskLetterComboBox.Enabled = false;
                diskSpaceNumeric.Enabled = false;
                diskNameTextBox.Enabled = false;
                fileSystemComboBox.Enabled = false;
            }
            else
            {
                RamDrive.Unmount(letter);
                mountButton.Text = "Mount";
                diskLetterComboBox.Enabled = true;
                diskSpaceNumeric.Enabled = true;
                diskNameTextBox.Enabled = true;
                fileSystemComboBox.Enabled = true;

            }

        }

        private void FileSystemComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fileSystemComboBox.SelectedItem.ToString() != "NTFS")
            {
                enableCompressionCheckBox.Checked = false;
                enableCompressionCheckBox.Enabled = false;
            }
            enableCompressionCheckBox.Enabled = true;
        }

        private void mainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            Mount(sender, e);
        }
    }
}
