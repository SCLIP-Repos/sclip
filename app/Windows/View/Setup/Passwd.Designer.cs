namespace $safeprojectname$.View.Setup
{
    partial class Passwd
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Passwd_textBox = new System.Windows.Forms.TextBox();
            this.RePasswd_textBox = new System.Windows.Forms.TextBox();
            this.Next_button = new System.Windows.Forms.Button();
            this.PasswdExport_checkBox = new System.Windows.Forms.CheckBox();
            this.PswExporttype_checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Passwd_textBox
            // 
            this.Passwd_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Passwd_textBox.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.Passwd_textBox.Location = new System.Drawing.Point(150, 159);
            this.Passwd_textBox.Name = "Passwd_textBox";
            this.Passwd_textBox.PasswordChar = '●';
            this.Passwd_textBox.Size = new System.Drawing.Size(418, 31);
            this.Passwd_textBox.TabIndex = 0;
            this.Passwd_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RePasswd_textBox
            // 
            this.RePasswd_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RePasswd_textBox.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.RePasswd_textBox.Location = new System.Drawing.Point(150, 244);
            this.RePasswd_textBox.Name = "RePasswd_textBox";
            this.RePasswd_textBox.PasswordChar = '●';
            this.RePasswd_textBox.Size = new System.Drawing.Size(418, 31);
            this.RePasswd_textBox.TabIndex = 1;
            this.RePasswd_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Next_button
            // 
            this.Next_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_button.Location = new System.Drawing.Point(542, 620);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(99, 38);
            this.Next_button.TabIndex = 4;
            this.Next_button.Text = "NEXT";
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // PasswdExport_checkBox
            // 
            this.PasswdExport_checkBox.AutoSize = true;
            this.PasswdExport_checkBox.Checked = true;
            this.PasswdExport_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PasswdExport_checkBox.Location = new System.Drawing.Point(143, 373);
            this.PasswdExport_checkBox.Name = "PasswdExport_checkBox";
            this.PasswdExport_checkBox.Size = new System.Drawing.Size(109, 16);
            this.PasswdExport_checkBox.TabIndex = 5;
            this.PasswdExport_checkBox.Text = "Export password";
            this.PasswdExport_checkBox.UseVisualStyleBackColor = true;
            // 
            // PswExporttype_checkBox
            // 
            this.PswExporttype_checkBox.AutoSize = true;
            this.PswExporttype_checkBox.Checked = true;
            this.PswExporttype_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PswExporttype_checkBox.Location = new System.Drawing.Point(292, 373);
            this.PswExporttype_checkBox.Name = "PswExporttype_checkBox";
            this.PswExporttype_checkBox.Size = new System.Drawing.Size(332, 16);
            this.PswExporttype_checkBox.TabIndex = 6;
            this.PswExporttype_checkBox.Text = "Would you like to export the exported passwords in base64?";
            this.PswExporttype_checkBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label1.Location = new System.Drawing.Point(31, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.label2.Location = new System.Drawing.Point(36, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Re-enter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password setting";
            // 
            // Passwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PswExporttype_checkBox);
            this.Controls.Add(this.PasswdExport_checkBox);
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.RePasswd_textBox);
            this.Controls.Add(this.Passwd_textBox);
            this.Name = "Passwd";
            this.Size = new System.Drawing.Size(644, 661);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Passwd_textBox;
        private System.Windows.Forms.TextBox RePasswd_textBox;
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.CheckBox PasswdExport_checkBox;
        private System.Windows.Forms.CheckBox PswExporttype_checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
