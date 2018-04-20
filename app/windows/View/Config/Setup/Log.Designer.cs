namespace SCLIP.View.Config.Setup
{
    partial class Log
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
            this.SecurityLog_checkBox = new System.Windows.Forms.CheckBox();
            this.OperationLog_checkBox = new System.Windows.Forms.CheckBox();
            this.NEXT_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SecurityLog_checkBox
            // 
            this.SecurityLog_checkBox.AutoSize = true;
            this.SecurityLog_checkBox.Location = new System.Drawing.Point(113, 67);
            this.SecurityLog_checkBox.Name = "SecurityLog_checkBox";
            this.SecurityLog_checkBox.Size = new System.Drawing.Size(85, 16);
            this.SecurityLog_checkBox.TabIndex = 0;
            this.SecurityLog_checkBox.Text = "Security log";
            this.SecurityLog_checkBox.UseVisualStyleBackColor = true;
            // 
            // OperationLog_checkBox
            // 
            this.OperationLog_checkBox.AutoSize = true;
            this.OperationLog_checkBox.Location = new System.Drawing.Point(286, 67);
            this.OperationLog_checkBox.Name = "OperationLog_checkBox";
            this.OperationLog_checkBox.Size = new System.Drawing.Size(92, 16);
            this.OperationLog_checkBox.TabIndex = 1;
            this.OperationLog_checkBox.Text = "Operation log";
            this.OperationLog_checkBox.UseVisualStyleBackColor = true;
            // 
            // NEXT_button
            // 
            this.NEXT_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NEXT_button.Location = new System.Drawing.Point(428, 459);
            this.NEXT_button.Name = "NEXT_button";
            this.NEXT_button.Size = new System.Drawing.Size(91, 38);
            this.NEXT_button.TabIndex = 6;
            this.NEXT_button.Text = "NEXT";
            this.NEXT_button.UseVisualStyleBackColor = true;
            this.NEXT_button.Click += new System.EventHandler(this.NEXT_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Log settings";
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NEXT_button);
            this.Controls.Add(this.OperationLog_checkBox);
            this.Controls.Add(this.SecurityLog_checkBox);
            this.Name = "Log";
            this.Size = new System.Drawing.Size(522, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox SecurityLog_checkBox;
        private System.Windows.Forms.CheckBox OperationLog_checkBox;
        private System.Windows.Forms.Button NEXT_button;
        private System.Windows.Forms.Label label1;
    }
}
