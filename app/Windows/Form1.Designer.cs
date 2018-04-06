namespace $safeprojectname$
{
    partial class Form1
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

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Item_listBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Lock_pictureBox = new System.Windows.Forms.PictureBox();
            this.Settings_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.New_button = new System.Windows.Forms.Button();
            this.Base_panel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lock_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.30303F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.69697F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 934F));
            this.tableLayoutPanel1.Controls.Add(this.Item_listBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Base_panel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1166, 638);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Item_listBox
            // 
            this.Item_listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Item_listBox.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_listBox.FormattingEnabled = true;
            this.Item_listBox.ItemHeight = 18;
            this.Item_listBox.Location = new System.Drawing.Point(73, 3);
            this.Item_listBox.Name = "Item_listBox";
            this.Item_listBox.Size = new System.Drawing.Size(155, 632);
            this.Item_listBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Lock_pictureBox);
            this.panel2.Controls.Add(this.Settings_button);
            this.panel2.Controls.Add(this.Delete_button);
            this.panel2.Controls.Add(this.Edit_button);
            this.panel2.Controls.Add(this.New_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 632);
            this.panel2.TabIndex = 1;
            // 
            // Lock_pictureBox
            // 
            this.Lock_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Lock_pictureBox.Image")));
            this.Lock_pictureBox.Location = new System.Drawing.Point(3, 523);
            this.Lock_pictureBox.Name = "Lock_pictureBox";
            this.Lock_pictureBox.Size = new System.Drawing.Size(57, 50);
            this.Lock_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Lock_pictureBox.TabIndex = 0;
            this.Lock_pictureBox.TabStop = false;
            this.Lock_pictureBox.Click += new System.EventHandler(this.Lock_pictureBox_Click);
            // 
            // Settings_button
            // 
            this.Settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_button.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Settings_button.Location = new System.Drawing.Point(3, 579);
            this.Settings_button.Name = "Settings_button";
            this.Settings_button.Size = new System.Drawing.Size(57, 50);
            this.Settings_button.TabIndex = 3;
            this.Settings_button.Text = "⚙";
            this.Settings_button.UseVisualStyleBackColor = true;
            // 
            // Delete_button
            // 
            this.Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_button.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Delete_button.Location = new System.Drawing.Point(3, 115);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(57, 50);
            this.Delete_button.TabIndex = 2;
            this.Delete_button.Text = "－";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_button.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Edit_button.Location = new System.Drawing.Point(3, 59);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(57, 50);
            this.Edit_button.TabIndex = 1;
            this.Edit_button.Text = "✎";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // New_button
            // 
            this.New_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New_button.Font = new System.Drawing.Font("メイリオ", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.New_button.Location = new System.Drawing.Point(3, 3);
            this.New_button.Name = "New_button";
            this.New_button.Size = new System.Drawing.Size(57, 50);
            this.New_button.TabIndex = 0;
            this.New_button.Text = "＋";
            this.New_button.UseVisualStyleBackColor = true;
            this.New_button.Click += new System.EventHandler(this.New_button_Click);
            // 
            // Base_panel
            // 
            this.Base_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Base_panel.Location = new System.Drawing.Point(234, 3);
            this.Base_panel.Name = "Base_panel";
            this.Base_panel.Size = new System.Drawing.Size(929, 632);
            this.Base_panel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1166, 638);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "$safeprojectname$";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Lock_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Base_panel;
        private System.Windows.Forms.ListBox Item_listBox;
        private System.Windows.Forms.Button New_button;
        private System.Windows.Forms.Button Settings_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.PictureBox Lock_pictureBox;
    }
}

