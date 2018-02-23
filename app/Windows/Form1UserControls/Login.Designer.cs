namespace $safeprojectname$.Form1UserControls
{
    partial class Login
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
            this.Psw_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.ResetPsw_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Psw_textBox
            // 
            this.Psw_textBox.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.Psw_textBox.Location = new System.Drawing.Point(191, 244);
            this.Psw_textBox.Name = "Psw_textBox";
            this.Psw_textBox.PasswordChar = '●';
            this.Psw_textBox.Size = new System.Drawing.Size(389, 25);
            this.Psw_textBox.TabIndex = 0;
            this.Psw_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 13F);
            this.label1.Location = new System.Drawing.Point(81, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password";
            // 
            // Login_button
            // 
            this.Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_button.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.Login_button.Location = new System.Drawing.Point(586, 244);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(67, 25);
            this.Login_button.TabIndex = 2;
            this.Login_button.Text = "LOGIN";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // ResetPsw_label
            // 
            this.ResetPsw_label.AutoSize = true;
            this.ResetPsw_label.Font = new System.Drawing.Font("Segoe UI Emoji", 7F);
            this.ResetPsw_label.ForeColor = System.Drawing.Color.Teal;
            this.ResetPsw_label.Location = new System.Drawing.Point(506, 272);
            this.ResetPsw_label.Name = "ResetPsw_label";
            this.ResetPsw_label.Size = new System.Drawing.Size(74, 14);
            this.ResetPsw_label.TabIndex = 3;
            this.ResetPsw_label.Text = "Reset password";
            this.ResetPsw_label.Click += new System.EventHandler(this.ResetPsw_label_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ResetPsw_label);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Psw_textBox);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(743, 641);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Psw_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Label ResetPsw_label;
    }
}
