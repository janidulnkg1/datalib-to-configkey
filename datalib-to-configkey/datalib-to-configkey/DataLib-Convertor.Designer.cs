
namespace datalib_to_configkey
{
    partial class Form1
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
            panel1 = new Panel();
            label3 = new Label();
            lblOutput = new Label();
            btnProcess = new Button();
            label2 = new Label();
            lblSelectedFile = new Label();
            btnBrowse = new Button();
            lblFooter = new Label();
            lblFooter2 = new Label();
            lblDT = new Label();
            label1 = new Label();
            lblExit = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblOutput);
            panel1.Controls.Add(btnProcess);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblSelectedFile);
            panel1.Controls.Add(btnBrowse);
            panel1.Location = new Point(12, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(566, 215);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(9, 160);
            label3.Name = "label3";
            label3.Size = new Size(189, 21);
            label3.TabIndex = 7;
            label3.Text = "Processed File Location :";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(199, 164);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(89, 15);
            lblOutput.TabIndex = 6;
            lblOutput.Text = "No Files Found.";
            // 
            // btnProcess
            // 
            btnProcess.BackColor = Color.FromArgb(128, 128, 255);
            btnProcess.FlatStyle = FlatStyle.Popup;
            btnProcess.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnProcess.Location = new Point(184, 69);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(169, 48);
            btnProcess.TabIndex = 5;
            btnProcess.Text = "PROCESS";
            btnProcess.UseVisualStyleBackColor = false;
            btnProcess.Click += btnProcess_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 24);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 4;
            label2.Text = "Select File :";
            // 
            // lblSelectedFile
            // 
            lblSelectedFile.AutoSize = true;
            lblSelectedFile.Location = new Point(102, 28);
            lblSelectedFile.Name = "lblSelectedFile";
            lblSelectedFile.Size = new Size(91, 15);
            lblSelectedFile.TabIndex = 3;
            lblSelectedFile.Text = "No file selected.";
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.Cyan;
            btnBrowse.FlatStyle = FlatStyle.Popup;
            btnBrowse.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrowse.ForeColor = SystemColors.Desktop;
            btnBrowse.Location = new Point(393, 21);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(109, 34);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Location = new Point(12, 337);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(143, 15);
            lblFooter.TabIndex = 4;
            lblFooter.Text = "2024 | All Rights Reserved ";
            // 
            // lblFooter2
            // 
            lblFooter2.AutoSize = true;
            lblFooter2.Location = new Point(382, 337);
            lblFooter2.Name = "lblFooter2";
            lblFooter2.Size = new Size(196, 15);
            lblFooter2.TabIndex = 8;
            lblFooter2.Text = " Copyright © Quantrax Corporation";
            // 
            // lblDT
            // 
            lblDT.AutoSize = true;
            lblDT.Location = new Point(10, 7);
            lblDT.Name = "lblDT";
            lblDT.Size = new Size(0, 15);
            lblDT.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(107, 46);
            label1.Name = "label1";
            label1.Size = new Size(392, 37);
            label1.TabIndex = 10;
            label1.Text = "DataLib - KeyConfig Convertor";
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblExit.Location = new Point(560, 4);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(24, 25);
            lblExit.TabIndex = 11;
            lblExit.Text = "X";
            lblExit.Click += lblExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(590, 361);
            ControlBox = false;
            Controls.Add(lblExit);
            Controls.Add(label1);
            Controls.Add(lblDT);
            Controls.Add(lblFooter2);
            Controls.Add(lblFooter);
            Controls.Add(panel1);
            MaximizeBox = false;
            MaximumSize = new Size(606, 400);
            MinimumSize = new Size(606, 400);
            Name = "Form1";
            Text = "Convertor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Panel panel1;
        private Label lblFooter;
        private Label lblFooter2;
        private Label lblDT;
        private Button btnBrowse;
        private Label lblSelectedFile;
        private Button btnProcess;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label lblOutput;
        private Label lblExit;
    }
}
