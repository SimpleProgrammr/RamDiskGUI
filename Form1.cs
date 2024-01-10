using RamDisk;

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
            List<string> letters = new() { "A:\\", "B:\\", "C:\\", "D:\\", "E:\\", "F:\\", "G:\\", "H:\\", "I:\\", "J:\\", "K:\\", "L:\\", "M:\\", "N:\\", "O:\\", "P:\\", "Q:\\", "R:\\", "S:\\", "T:\\", "U:\\", "V:\\", "W:\\", "X:\\", "Y:\\", "Z:\\" };
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

        }


        private void Mount(object sender, EventArgs e)
        {
            int space = (int)diskSpaceNumeric.Value;
            char letter = (char)diskLetterComboBox.SelectedItem.ToString()[0];
            string name = "RamDrive";
            if (mountButton.Text == "Mount")
            {
                diskLetterComboBox.Enabled = false;
                diskSpaceNumeric.Enabled = false;
                
                RamDrive.Mount(space, FileSystem.NTFS, letter, name);
                 
                mountButton.Text = "Unmount";
            }
            else
            {
                RamDrive.Unmount(letter);
                mountButton.Text = "Mount";
                diskLetterComboBox.Enabled = true;
                diskSpaceNumeric.Enabled = true;

            }
            
        }

    }
}
