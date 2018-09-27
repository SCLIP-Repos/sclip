namespace SCLIP.UserControls.Setup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agree));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.AgreeNext_button = new System.Windows.Forms.Button();
            this.AgreeBack_button = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(447, 262);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // AgreeNext_button
            // 
            this.AgreeNext_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgreeNext_button.Location = new System.Drawing.Point(372, 268);
            this.AgreeNext_button.Name = "AgreeNext_button";
            this.AgreeNext_button.Size = new System.Drawing.Size(75, 23);
            this.AgreeNext_button.TabIndex = 2;
            this.AgreeNext_button.Text = "次へ";
            this.AgreeNext_button.UseVisualStyleBackColor = true;
            this.AgreeNext_button.Click += new System.EventHandler(this.AgreeNext_button_Click);
            // 
            // AgreeBack_button
            // 
            this.AgreeBack_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgreeBack_button.Location = new System.Drawing.Point(291, 268);
            this.AgreeBack_button.Name = "AgreeBack_button";
            this.AgreeBack_button.Size = new System.Drawing.Size(75, 23);
            this.AgreeBack_button.TabIndex = 3;
            this.AgreeBack_button.Text = "戻る";
            this.AgreeBack_button.UseVisualStyleBackColor = true;
            this.AgreeBack_button.Click += new System.EventHandler(this.AgreeBack_button_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(3, 271);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 16);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "同意する";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Agree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.AgreeBack_button);
            this.Controls.Add(this.AgreeNext_button);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Agree";
            this.Size = new System.Drawing.Size(450, 294);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button AgreeNext_button;
        private System.Windows.Forms.Button AgreeBack_button;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
