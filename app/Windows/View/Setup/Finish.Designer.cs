<<<<<<< HEAD
﻿namespace SCLIP.View.Setup
=======
﻿namespace $safeprojectname$.View.Setup
>>>>>>> b27f45d06842ef02074930127f0fc5e0a8f3b40b
{
    partial class Finish
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
            this.Finish_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Finish_button
            // 
            this.Finish_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Finish_button.Location = new System.Drawing.Point(625, 350);
            this.Finish_button.Name = "Finish_button";
            this.Finish_button.Size = new System.Drawing.Size(95, 35);
            this.Finish_button.TabIndex = 4;
            this.Finish_button.Text = "FINISH";
            this.Finish_button.UseVisualStyleBackColor = true;
            this.Finish_button.Click += new System.EventHandler(this.Finish_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(108, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 80);
            this.label1.TabIndex = 5;
<<<<<<< HEAD
            this.label1.Text = "Go to SCLIP !";
=======
            this.label1.Text = "Go to $safeprojectname$ !";
>>>>>>> b27f45d06842ef02074930127f0fc5e0a8f3b40b
            // 
            // Finish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Finish_button);
            this.Name = "Finish";
            this.Size = new System.Drawing.Size(720, 385);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Finish_button;
        private System.Windows.Forms.Label label1;
    }
}
