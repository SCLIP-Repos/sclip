namespace $safeprojectname$.View.Setup
{
    partial class PasswdSet
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
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.ReEnter_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.View_label = new System.Windows.Forms.Label();
            this.Next_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Password_textBox
            // 
            this.Password_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password_textBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_textBox.Location = new System.Drawing.Point(133, 152);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.PasswordChar = '●';
            this.Password_textBox.Size = new System.Drawing.Size(334, 27);
            this.Password_textBox.TabIndex = 0;
            this.Password_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReEnter_textBox
            // 
            this.ReEnter_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReEnter_textBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReEnter_textBox.Location = new System.Drawing.Point(133, 213);
            this.ReEnter_textBox.Name = "ReEnter_textBox";
            this.ReEnter_textBox.PasswordChar = '●';
            this.ReEnter_textBox.Size = new System.Drawing.Size(334, 27);
            this.ReEnter_textBox.TabIndex = 1;
            this.ReEnter_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Re-enter";
            // 
            // View_label
            // 
            this.View_label.AutoSize = true;
            this.View_label.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_label.Location = new System.Drawing.Point(440, 182);
            this.View_label.Name = "View_label";
            this.View_label.Size = new System.Drawing.Size(27, 23);
            this.View_label.TabIndex = 4;
            this.View_label.Text = "👁";
            this.View_label.MouseLeave += new System.EventHandler(this.View_label_MouseLeave);
            this.View_label.MouseHover += new System.EventHandler(this.View_label_MouseHover);
            // 
            // Next_button
            // 
            this.Next_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Next_button.Location = new System.Drawing.Point(391, 456);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(96, 40);
            this.Next_button.TabIndex = 5;
            this.Next_button.Text = "NEXT";
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // PasswdSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.View_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReEnter_textBox);
            this.Controls.Add(this.Password_textBox);
            this.Name = "PasswdSet";
            this.Size = new System.Drawing.Size(490, 499);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.TextBox ReEnter_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label View_label;
        private System.Windows.Forms.Button Next_button;
    }
}
