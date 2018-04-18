namespace SCLIP.View.Config.Setup
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
            this.NEXT_button = new System.Windows.Forms.Button();
            this.Agree_checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(522, 453);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // NEXT_button
            // 
            this.NEXT_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NEXT_button.Location = new System.Drawing.Point(428, 459);
            this.NEXT_button.Name = "NEXT_button";
            this.NEXT_button.Size = new System.Drawing.Size(91, 38);
            this.NEXT_button.TabIndex = 4;
            this.NEXT_button.Text = "NEXT";
            this.NEXT_button.UseVisualStyleBackColor = true;
            // 
            // Agree_checkBox1
            // 
            this.Agree_checkBox1.AutoSize = true;
            this.Agree_checkBox1.Location = new System.Drawing.Point(368, 459);
            this.Agree_checkBox1.Name = "Agree_checkBox1";
            this.Agree_checkBox1.Size = new System.Drawing.Size(54, 16);
            this.Agree_checkBox1.TabIndex = 5;
            this.Agree_checkBox1.Text = "Agree";
            this.Agree_checkBox1.UseVisualStyleBackColor = true;
            // 
            // Agree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Agree_checkBox1);
            this.Controls.Add(this.NEXT_button);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Agree";
            this.Size = new System.Drawing.Size(522, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button NEXT_button;
        private System.Windows.Forms.CheckBox Agree_checkBox1;
    }
}
