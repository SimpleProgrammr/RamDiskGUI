using static System.Drawing.Font;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RamDiskGUI
{
    partial class mainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            diskSpaceNumeric = new NumericUpDown();
            diskLetterComboBox = new ComboBox();
            mountButton = new Button();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            diskNameTextBox = new TextBox();
            fileSystemComboBox = new ComboBox();
            label2 = new Label();
            enableCompressionCheckBox = new CheckBox();
            clusterSizeComboBox = new ComboBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)diskSpaceNumeric).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 23F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(36, 9);
            label1.Name = "label1";
            label1.Size = new Size(152, 42);
            label1.TabIndex = 0;
            label1.Text = "Ram Disk";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // diskSpaceNumeric
            // 
            diskSpaceNumeric.Font = new Font("Segoe UI", 10F);
            diskSpaceNumeric.Location = new Point(95, 188);
            diskSpaceNumeric.Maximum = new decimal(new int[] { 4096, 0, 0, 0 });
            diskSpaceNumeric.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            diskSpaceNumeric.Name = "diskSpaceNumeric";
            diskSpaceNumeric.Size = new Size(121, 25);
            diskSpaceNumeric.TabIndex = 1;
            diskSpaceNumeric.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // diskLetterComboBox
            // 
            diskLetterComboBox.Font = new Font("Segoe UI", 10F);
            diskLetterComboBox.FormattingEnabled = true;
            diskLetterComboBox.Location = new Point(95, 99);
            diskLetterComboBox.Name = "diskLetterComboBox";
            diskLetterComboBox.Size = new Size(120, 25);
            diskLetterComboBox.TabIndex = 5;
            // 
            // mountButton
            // 
            mountButton.Font = new Font("Segoe UI", 15F);
            mountButton.Location = new Point(35, 305);
            mountButton.Name = "mountButton";
            mountButton.Size = new Size(152, 58);
            mountButton.TabIndex = 6;
            mountButton.Text = "Mount";
            mountButton.UseVisualStyleBackColor = true;
            mountButton.Click += Mount;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(12, 190);
            label4.Name = "label4";
            label4.Size = new Size(77, 19);
            label4.TabIndex = 9;
            label4.Text = "Disk Space:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 8;
            label3.Text = "Disk Letter:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(12, 145);
            label5.Name = "label5";
            label5.Size = new Size(80, 19);
            label5.TabIndex = 11;
            label5.Text = "File System:";
            // 
            // diskNameTextBox
            // 
            diskNameTextBox.Font = new Font("Segoe UI", 10F);
            diskNameTextBox.Location = new Point(12, 54);
            diskNameTextBox.Name = "diskNameTextBox";
            diskNameTextBox.PlaceholderText = "Ram Disk";
            diskNameTextBox.Size = new Size(203, 25);
            diskNameTextBox.TabIndex = 12;
            diskNameTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // fileSystemComboBox
            // 
            fileSystemComboBox.Font = new Font("Segoe UI", 10F);
            fileSystemComboBox.FormattingEnabled = true;
            fileSystemComboBox.Location = new Point(95, 142);
            fileSystemComboBox.Name = "fileSystemComboBox";
            fileSystemComboBox.Size = new Size(120, 25);
            fileSystemComboBox.TabIndex = 13;
            fileSystemComboBox.SelectedIndexChanged += FileSystemComboBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(11, 271);
            label2.Name = "label2";
            label2.Size = new Size(133, 19);
            label2.TabIndex = 14;
            label2.Text = "Enable compression:";
            // 
            // enableCompressionCheckBox
            // 
            enableCompressionCheckBox.AutoSize = true;
            enableCompressionCheckBox.Font = new Font("Segoe UI", 11F);
            enableCompressionCheckBox.Location = new Point(172, 276);
            enableCompressionCheckBox.Name = "enableCompressionCheckBox";
            enableCompressionCheckBox.Size = new Size(15, 14);
            enableCompressionCheckBox.TabIndex = 15;
            enableCompressionCheckBox.UseVisualStyleBackColor = true;
            // 
            // clusterSizeComboBox
            // 
            clusterSizeComboBox.Font = new Font("Segoe UI", 10F);
            clusterSizeComboBox.FormattingEnabled = true;
            clusterSizeComboBox.Location = new Point(94, 230);
            clusterSizeComboBox.Name = "clusterSizeComboBox";
            clusterSizeComboBox.Size = new Size(120, 25);
            clusterSizeComboBox.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(12, 233);
            label6.Name = "label6";
            label6.Size = new Size(82, 19);
            label6.TabIndex = 16;
            label6.Text = "Cluster Size:";
            // 
            // mainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 374);
            Controls.Add(clusterSizeComboBox);
            Controls.Add(label6);
            Controls.Add(enableCompressionCheckBox);
            Controls.Add(label2);
            Controls.Add(fileSystemComboBox);
            Controls.Add(diskNameTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(mountButton);
            Controls.Add(diskLetterComboBox);
            Controls.Add(diskSpaceNumeric);
            Controls.Add(label1);
            Name = "mainWindow";
            ShowIcon = false;
            Text = "Ram Disk Mount";
            FormClosing += mainWindow_FormClosing;
            Load += MainWindow_Load;
            ((System.ComponentModel.ISupportInitialize)diskSpaceNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown diskSpaceNumeric;
        private System.Windows.Forms.ComboBox diskLetterComboBox;
        private System.Windows.Forms.Button mountButton;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox diskNameTextBox;
        private ComboBox fileSystemComboBox;
        private Label label2;
        private CheckBox enableCompressionCheckBox;
        private ComboBox clusterSizeComboBox;
        private Label label6;
    }
}
