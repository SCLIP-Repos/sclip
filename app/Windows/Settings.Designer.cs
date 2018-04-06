namespace SCLIP
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Passwd_textBox = new System.Windows.Forms.TextBox();
            this.ReEnter_textBox = new System.Windows.Forms.TextBox();
            this.EP_checkBox = new System.Windows.Forms.CheckBox();
            this.OK_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(133, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Re enter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(126, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password";
            // 
            // Passwd_textBox
            // 
            this.Passwd_textBox.BackColor = System.Drawing.Color.White;
            this.Passwd_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Passwd_textBox.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.Passwd_textBox.Location = new System.Drawing.Point(236, 79);
            this.Passwd_textBox.Name = "Passwd_textBox";
            this.Passwd_textBox.PasswordChar = '●';
            this.Passwd_textBox.Size = new System.Drawing.Size(369, 27);
            this.Passwd_textBox.TabIndex = 5;
            // 
            // ReEnter_textBox
            // 
            this.ReEnter_textBox.BackColor = System.Drawing.Color.White;
            this.ReEnter_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReEnter_textBox.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ReEnter_textBox.Location = new System.Drawing.Point(236, 141);
            this.ReEnter_textBox.Name = "ReEnter_textBox";
            this.ReEnter_textBox.PasswordChar = '●';
            this.ReEnter_textBox.Size = new System.Drawing.Size(369, 27);
            this.ReEnter_textBox.TabIndex = 6;
            // 
            // EP_checkBox
            // 
            this.EP_checkBox.AutoSize = true;
            this.EP_checkBox.Location = new System.Drawing.Point(236, 198);
            this.EP_checkBox.Name = "EP_checkBox";
            this.EP_checkBox.Size = new System.Drawing.Size(109, 16);
            this.EP_checkBox.TabIndex = 10;
            this.EP_checkBox.Text = "Export password";
            this.EP_checkBox.UseVisualStyleBackColor = true;
            // 
            // OK_button
            // 
            this.OK_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK_button.Location = new System.Drawing.Point(624, 349);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(95, 35);
            this.OK_button.TabIndex = 9;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 385);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Passwd_textBox);
            this.Controls.Add(this.ReEnter_textBox);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.EP_checkBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Passwd_textBox;
        private System.Windows.Forms.TextBox ReEnter_textBox;
        private System.Windows.Forms.CheckBox EP_checkBox;
        private System.Windows.Forms.Button OK_button;
    }
}