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
            diskSpaceNumeric.Location = new Point(95, 104);
            diskSpaceNumeric.Maximum = new decimal(new int[] { 4096, 0, 0, 0 });
            diskSpaceNumeric.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            diskSpaceNumeric.Name = "diskSpaceNumeric";
            diskSpaceNumeric.Size = new Size(120, 25);
            diskSpaceNumeric.TabIndex = 1;
            diskSpaceNumeric.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // diskLetterComboBox
            // 
            diskLetterComboBox.Font = new Font("Segoe UI", 10F);
            diskLetterComboBox.FormattingEnabled = true;
            diskLetterComboBox.Location = new Point(96, 48);
            diskLetterComboBox.Name = "diskLetterComboBox";
            diskLetterComboBox.Size = new Size(121, 25);
            diskLetterComboBox.TabIndex = 5;
            // 
            // mountButton
            // 
            mountButton.Font = new Font("Segoe UI", 15F);
            mountButton.Location = new Point(36, 135);
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
            label4.Location = new Point(12, 106);
            label4.Name = "label4";
            label4.Size = new Size(77, 19);
            label4.TabIndex = 9;
            label4.Text = "Disk Space:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 51);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 8;
            label3.Text = "Disk Letter:";
            // 
            // mainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 201);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(mountButton);
            Controls.Add(diskLetterComboBox);
            Controls.Add(diskSpaceNumeric);
            Controls.Add(label1);
            Name = "mainWindow";
            ShowIcon = false;
            Text = "Ram Disk Mount";
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
    }
}
