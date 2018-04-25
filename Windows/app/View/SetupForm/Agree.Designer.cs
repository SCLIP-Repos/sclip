namespace SCLIP.View.SetupForm
{
    partial class Agree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agree));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Next_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(503, 450);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Next_button
            // 
            this.Next_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_button.Location = new System.Drawing.Point(408, 456);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(92, 28);
            this.Next_button.TabIndex = 4;
            this.Next_button.Text = "→";
            this.Next_button.UseVisualStyleBackColor = true;
            // 
            // Back_button
            // 
            this.Back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back_button.Location = new System.Drawing.Point(310, 456);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(92, 28);
            this.Back_button.TabIndex = 5;
            this.Back_button.Text = "←";
            this.Back_button.UseVisualStyleBackColor = true;
            // 
            // Agree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Agree";
            this.Size = new System.Drawing.Size(503, 487);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.Button Back_button;
    }
}
