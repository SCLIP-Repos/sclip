namespace SCLIP.View
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Passwd_textBox = new System.Windows.Forms.TextBox();
            this.Login_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(160, 191);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Passwd_textBox
            // 
            this.Passwd_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Passwd_textBox.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwd_textBox.Location = new System.Drawing.Point(224, 202);
            this.Passwd_textBox.Name = "Passwd_textBox";
            this.Passwd_textBox.PasswordChar = '●';
            this.Passwd_textBox.Size = new System.Drawing.Size(427, 33);
            this.Passwd_textBox.TabIndex = 1;
            this.Passwd_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Login_button
            // 
            this.Login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Login_button.Font = new System.Drawing.Font("Verdana", 10F);
            this.Login_button.Location = new System.Drawing.Point(657, 202);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(81, 33);
            this.Login_button.TabIndex = 2;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = true;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Login_button);
            this.Controls.Add(this.Passwd_textBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(889, 544);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Passwd_textBox;
        private System.Windows.Forms.Button Login_button;
    }
}
