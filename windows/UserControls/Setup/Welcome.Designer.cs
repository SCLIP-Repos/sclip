namespace SCLIP.UserControls.Setup
{
    partial class Welcome
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.WelcomeNext_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SCLIP.Properties.Resources._001;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // WelcomeNext_button
            // 
            this.WelcomeNext_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WelcomeNext_button.Location = new System.Drawing.Point(372, 268);
            this.WelcomeNext_button.Name = "WelcomeNext_button";
            this.WelcomeNext_button.Size = new System.Drawing.Size(75, 23);
            this.WelcomeNext_button.TabIndex = 1;
            this.WelcomeNext_button.Text = "次へ";
            this.WelcomeNext_button.UseVisualStyleBackColor = true;
            this.WelcomeNext_button.Click += new System.EventHandler(this.WelcomeNext_button_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.WelcomeNext_button);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Welcome";
            this.Size = new System.Drawing.Size(450, 294);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button WelcomeNext_button;
    }
}
