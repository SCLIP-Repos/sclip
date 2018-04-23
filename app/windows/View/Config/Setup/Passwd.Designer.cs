namespace SCLIP.View.Config.Setup
{
    partial class Passwd
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NEXT_button = new System.Windows.Forms.Button();
            this.ExportOfPasswd_checkBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Strength_label = new System.Windows.Forms.Label();
            this.Strength_progressBar = new System.Windows.Forms.ProgressBar();
            this.RePasswd_textBox = new System.Windows.Forms.TextBox();
            this.Passwd_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(522, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NEXT_button);
            this.panel2.Controls.Add(this.ExportOfPasswd_checkBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 289);
            this.panel2.TabIndex = 1;
            // 
            // NEXT_button
            // 
            this.NEXT_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NEXT_button.Location = new System.Drawing.Point(425, 251);
            this.NEXT_button.Name = "NEXT_button";
            this.NEXT_button.Size = new System.Drawing.Size(91, 38);
            this.NEXT_button.TabIndex = 5;
            this.NEXT_button.Text = "NEXT";
            this.NEXT_button.UseVisualStyleBackColor = true;
            this.NEXT_button.Click += new System.EventHandler(this.NEXT_button_Click);
            // 
            // ExportOfPasswd_checkBox
            // 
            this.ExportOfPasswd_checkBox.AutoSize = true;
            this.ExportOfPasswd_checkBox.Location = new System.Drawing.Point(99, 35);
            this.ExportOfPasswd_checkBox.Name = "ExportOfPasswd_checkBox";
            this.ExportOfPasswd_checkBox.Size = new System.Drawing.Size(109, 16);
            this.ExportOfPasswd_checkBox.TabIndex = 0;
            this.ExportOfPasswd_checkBox.Text = "Export password\r\n";
            this.ExportOfPasswd_checkBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Strength_label);
            this.panel1.Controls.Add(this.Strength_progressBar);
            this.panel1.Controls.Add(this.RePasswd_textBox);
            this.panel1.Controls.Add(this.Passwd_textBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 199);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label2.Location = new System.Drawing.Point(21, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Re enter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.label1.Location = new System.Drawing.Point(21, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // Strength_label
            // 
            this.Strength_label.AutoSize = true;
            this.Strength_label.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Strength_label.ForeColor = System.Drawing.Color.Coral;
            this.Strength_label.Location = new System.Drawing.Point(96, 177);
            this.Strength_label.Name = "Strength_label";
            this.Strength_label.Size = new System.Drawing.Size(0, 15);
            this.Strength_label.TabIndex = 2;
            // 
            // Strength_progressBar
            // 
            this.Strength_progressBar.BackColor = System.Drawing.Color.White;
            this.Strength_progressBar.Location = new System.Drawing.Point(99, 151);
            this.Strength_progressBar.Name = "Strength_progressBar";
            this.Strength_progressBar.Size = new System.Drawing.Size(360, 23);
            this.Strength_progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Strength_progressBar.TabIndex = 0;
            // 
            // RePasswd_textBox
            // 
            this.RePasswd_textBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.RePasswd_textBox.Location = new System.Drawing.Point(99, 103);
            this.RePasswd_textBox.Name = "RePasswd_textBox";
            this.RePasswd_textBox.PasswordChar = '●';
            this.RePasswd_textBox.Size = new System.Drawing.Size(360, 23);
            this.RePasswd_textBox.TabIndex = 1;
            this.RePasswd_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Passwd_textBox
            // 
            this.Passwd_textBox.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.Passwd_textBox.Location = new System.Drawing.Point(99, 53);
            this.Passwd_textBox.Name = "Passwd_textBox";
            this.Passwd_textBox.PasswordChar = '●';
            this.Passwd_textBox.Size = new System.Drawing.Size(360, 23);
            this.Passwd_textBox.TabIndex = 0;
            this.Passwd_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Passwd_textBox.TextChanged += new System.EventHandler(this.Passwd_textBox_TextChanged);
            // 
            // Passwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Passwd";
            this.Size = new System.Drawing.Size(522, 500);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Passwd_textBox;
        private System.Windows.Forms.TextBox RePasswd_textBox;
        private System.Windows.Forms.ProgressBar Strength_progressBar;
        private System.Windows.Forms.Label Strength_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ExportOfPasswd_checkBox;
        private System.Windows.Forms.Button NEXT_button;
        private System.Windows.Forms.Label label3;
    }
}
