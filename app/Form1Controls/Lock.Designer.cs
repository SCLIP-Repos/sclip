namespace $safeprojectname$.Form1Controls
{
    partial class Lock
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
            this.SuspendLayout();
            // 
            // Psw_textBox
            // 
            this.Psw_textBox.BackColor = System.Drawing.Color.White;
            this.Psw_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Psw_textBox.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Psw_textBox.Location = new System.Drawing.Point(92, 203);
            this.Psw_textBox.Name = "Psw_textBox";
            this.Psw_textBox.PasswordChar = '●';
            this.Psw_textBox.Size = new System.Drawing.Size(543, 34);
            this.Psw_textBox.TabIndex = 0;
            this.Psw_textBox.Text = "aaaa";
            // 
            // Lock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Psw_textBox);
            this.Name = "Lock";
            this.Size = new System.Drawing.Size(638, 520);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Psw_textBox;
    }
}
