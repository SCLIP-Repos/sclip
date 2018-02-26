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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Psw_textBox = new System.Windows.Forms.TextBox();
            this.Login_button = new System.Windows.Forms.Button();
            this.ResetPsw_label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Psw_textBox
            // 
            this.Psw_textBox.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.Psw_textBox.Location = new System.Drawing.Point(281, 244);
            this.Psw_textBox.Name = "Psw_textBox";
            this.Psw_textBox.PasswordChar = '●';
            this.Psw_textBox.Size = new System.Drawing.Size(389, 25);
            this.Psw_textBox.TabIndex = 0;
            this.Psw_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Login_button
            // 
            this.Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_button.Font = new System.Drawing.Font("Segoe UI Emoji", 9F);
            this.Login_button.Location = new System.Drawing.Point(672, 244);
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
            this.ResetPsw_label.Location = new System.Drawing.Point(669, 627);
            this.ResetPsw_label.Name = "ResetPsw_label";
            this.ResetPsw_label.Size = new System.Drawing.Size(74, 14);
            this.ResetPsw_label.TabIndex = 3;
            this.ResetPsw_label.Text = "Reset password";
            this.ResetPsw_label.Click += new System.EventHandler(this.ResetPsw_label_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-158, -40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(222, 223);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ResetPsw_label);
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Psw_textBox);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(743, 641);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Psw_textBox;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.Label ResetPsw_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
