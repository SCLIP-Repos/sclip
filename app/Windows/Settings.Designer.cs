namespace $safeprojectname$
{
    partial class Settings
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RePasswd_textBox = new System.Windows.Forms.TextBox();
            this.Passwd_textBox = new System.Windows.Forms.TextBox();
            this.PswExporttype_checkBox = new System.Windows.Forms.CheckBox();
            this.PasswdExport_checkBox = new System.Windows.Forms.CheckBox();
            this.OK_button = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(593, 407);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.OK_button);
            this.tabPage2.Controls.Add(this.PswExporttype_checkBox);
            this.tabPage2.Controls.Add(this.PasswdExport_checkBox);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.RePasswd_textBox);
            this.tabPage2.Controls.Add(this.Passwd_textBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(585, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Password";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label2.Location = new System.Drawing.Point(31, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Re-enter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Password";
            // 
            // RePasswd_textBox
            // 
            this.RePasswd_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RePasswd_textBox.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.RePasswd_textBox.Location = new System.Drawing.Point(145, 117);
            this.RePasswd_textBox.Name = "RePasswd_textBox";
            this.RePasswd_textBox.PasswordChar = '●';
            this.RePasswd_textBox.Size = new System.Drawing.Size(418, 31);
            this.RePasswd_textBox.TabIndex = 10;
            this.RePasswd_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Passwd_textBox
            // 
            this.Passwd_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Passwd_textBox.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.Passwd_textBox.Location = new System.Drawing.Point(145, 32);
            this.Passwd_textBox.Name = "Passwd_textBox";
            this.Passwd_textBox.PasswordChar = '●';
            this.Passwd_textBox.Size = new System.Drawing.Size(418, 31);
            this.Passwd_textBox.TabIndex = 9;
            this.Passwd_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PswExporttype_checkBox
            // 
            this.PswExporttype_checkBox.AutoSize = true;
            this.PswExporttype_checkBox.Checked = true;
            this.PswExporttype_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PswExporttype_checkBox.Location = new System.Drawing.Point(231, 193);
            this.PswExporttype_checkBox.Name = "PswExporttype_checkBox";
            this.PswExporttype_checkBox.Size = new System.Drawing.Size(332, 16);
            this.PswExporttype_checkBox.TabIndex = 14;
            this.PswExporttype_checkBox.Text = "Would you like to export the exported passwords in base64?";
            this.PswExporttype_checkBox.UseVisualStyleBackColor = true;
            // 
            // PasswdExport_checkBox
            // 
            this.PasswdExport_checkBox.AutoSize = true;
            this.PasswdExport_checkBox.Checked = true;
            this.PasswdExport_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PasswdExport_checkBox.Location = new System.Drawing.Point(82, 193);
            this.PasswdExport_checkBox.Name = "PasswdExport_checkBox";
            this.PasswdExport_checkBox.Size = new System.Drawing.Size(109, 16);
            this.PasswdExport_checkBox.TabIndex = 13;
            this.PasswdExport_checkBox.Text = "Export password";
            this.PasswdExport_checkBox.UseVisualStyleBackColor = true;
            // 
            // OK_button
            // 
            this.OK_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK_button.Location = new System.Drawing.Point(478, 337);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(99, 38);
            this.OK_button.TabIndex = 15;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(593, 407);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RePasswd_textBox;
        private System.Windows.Forms.TextBox Passwd_textBox;
        private System.Windows.Forms.CheckBox PswExporttype_checkBox;
        private System.Windows.Forms.CheckBox PasswdExport_checkBox;
        private System.Windows.Forms.Button OK_button;
    }
}