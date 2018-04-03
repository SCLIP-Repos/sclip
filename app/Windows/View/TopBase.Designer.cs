<<<<<<< HEAD:app/Windows/View/TopBase.Designer.cs
﻿namespace $safeprojectname$.View
{
    partial class TopBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopBase));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Base_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ItemList_listBox = new System.Windows.Forms.ListBox();
            this.New_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Sets_button = new System.Windows.Forms.Button();
            this.Lock_pictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lock_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.67391F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.32609F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 838F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Base_panel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.ItemList_listBox, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1023, 583);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Base_panel
            // 
            this.Base_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Base_panel.Location = new System.Drawing.Point(187, 3);
            this.Base_panel.Name = "Base_panel";
            this.Base_panel.Size = new System.Drawing.Size(833, 577);
            this.Base_panel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Lock_pictureBox);
            this.panel2.Controls.Add(this.Sets_button);
            this.panel2.Controls.Add(this.Delete_button);
            this.panel2.Controls.Add(this.Edit_button);
            this.panel2.Controls.Add(this.New_button);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(67, 577);
            this.panel2.TabIndex = 1;
            // 
            // ItemList_listBox
            // 
            this.ItemList_listBox.BackColor = System.Drawing.Color.White;
            this.ItemList_listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemList_listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemList_listBox.FormattingEnabled = true;
            this.ItemList_listBox.ItemHeight = 12;
            this.ItemList_listBox.Location = new System.Drawing.Point(76, 3);
            this.ItemList_listBox.Name = "ItemList_listBox";
            this.ItemList_listBox.Size = new System.Drawing.Size(105, 577);
            this.ItemList_listBox.TabIndex = 2;
            // 
            // New_button
            // 
            this.New_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.New_button.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.New_button.Location = new System.Drawing.Point(3, 3);
            this.New_button.Name = "New_button";
            this.New_button.Size = new System.Drawing.Size(64, 53);
            this.New_button.TabIndex = 0;
            this.New_button.Text = "＋";
            this.New_button.UseVisualStyleBackColor = true;
            this.New_button.Click += new System.EventHandler(this.New_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_button.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.Edit_button.Location = new System.Drawing.Point(3, 62);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(64, 53);
            this.Edit_button.TabIndex = 1;
            this.Edit_button.Text = "✎";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_button.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.Delete_button.Location = new System.Drawing.Point(3, 121);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(64, 53);
            this.Delete_button.TabIndex = 2;
            this.Delete_button.Text = "－";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Sets_button
            // 
            this.Sets_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sets_button.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.Sets_button.Location = new System.Drawing.Point(3, 521);
            this.Sets_button.Name = "Sets_button";
            this.Sets_button.Size = new System.Drawing.Size(61, 53);
            this.Sets_button.TabIndex = 3;
            this.Sets_button.Text = "⚙";
            this.Sets_button.UseVisualStyleBackColor = true;
            this.Sets_button.Click += new System.EventHandler(this.Sets_button_Click);
            // 
            // Lock_pictureBox
            // 
            this.Lock_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Lock_pictureBox.Image")));
            this.Lock_pictureBox.Location = new System.Drawing.Point(3, 462);
            this.Lock_pictureBox.Name = "Lock_pictureBox";
            this.Lock_pictureBox.Size = new System.Drawing.Size(61, 53);
            this.Lock_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Lock_pictureBox.TabIndex = 0;
            this.Lock_pictureBox.TabStop = false;
            this.Lock_pictureBox.Click += new System.EventHandler(this.Lock_pictureBox_Click);
            // 
            // TopBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TopBase";
            this.Size = new System.Drawing.Size(1023, 583);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Lock_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Base_panel;
        private System.Windows.Forms.ListBox ItemList_listBox;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button New_button;
        private System.Windows.Forms.Button Sets_button;
        private System.Windows.Forms.PictureBox Lock_pictureBox;
    }
}
=======
﻿namespace SCLIP.View.Top
{
    partial class TopBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopBase));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Base_panel = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.Plus_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Settings_button = new System.Windows.Forms.Button();
            this.Lock_pictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lock_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.749156F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.25085F));
            this.tableLayoutPanel1.Controls.Add(this.panel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Base_panel, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(889, 544);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Base_panel
            // 
            this.Base_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Base_panel.Location = new System.Drawing.Point(63, 3);
            this.Base_panel.Name = "Base_panel";
            this.Base_panel.Size = new System.Drawing.Size(823, 538);
            this.Base_panel.TabIndex = 0;
            // 
            // panel
            // 
            this.panel.Controls.Add(this.Lock_pictureBox);
            this.panel.Controls.Add(this.Settings_button);
            this.panel.Controls.Add(this.Delete_button);
            this.panel.Controls.Add(this.Edit_button);
            this.panel.Controls.Add(this.Plus_button);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(3, 3);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(54, 538);
            this.panel.TabIndex = 1;
            // 
            // Plus_button
            // 
            this.Plus_button.BackColor = System.Drawing.Color.White;
            this.Plus_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Plus_button.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Plus_button.Location = new System.Drawing.Point(3, 3);
            this.Plus_button.Name = "Plus_button";
            this.Plus_button.Size = new System.Drawing.Size(46, 43);
            this.Plus_button.TabIndex = 0;
            this.Plus_button.Text = "＋";
            this.Plus_button.UseVisualStyleBackColor = false;
            // 
            // Delete_button
            // 
            this.Delete_button.BackColor = System.Drawing.Color.White;
            this.Delete_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete_button.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Delete_button.Location = new System.Drawing.Point(3, 125);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(46, 43);
            this.Delete_button.TabIndex = 1;
            this.Delete_button.Text = "🚮";
            this.Delete_button.UseVisualStyleBackColor = false;
            // 
            // Edit_button
            // 
            this.Edit_button.BackColor = System.Drawing.Color.White;
            this.Edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit_button.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Edit_button.Location = new System.Drawing.Point(3, 64);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(46, 43);
            this.Edit_button.TabIndex = 2;
            this.Edit_button.Text = "✎";
            this.Edit_button.UseVisualStyleBackColor = false;
            // 
            // Settings_button
            // 
            this.Settings_button.BackColor = System.Drawing.Color.White;
            this.Settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings_button.Font = new System.Drawing.Font("ＭＳ ゴシック", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Settings_button.Location = new System.Drawing.Point(3, 433);
            this.Settings_button.Name = "Settings_button";
            this.Settings_button.Size = new System.Drawing.Size(46, 43);
            this.Settings_button.TabIndex = 3;
            this.Settings_button.Text = "⚙";
            this.Settings_button.UseVisualStyleBackColor = false;
            // 
            // Lock_pictureBox
            // 
            this.Lock_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Lock_pictureBox.Image")));
            this.Lock_pictureBox.Location = new System.Drawing.Point(3, 494);
            this.Lock_pictureBox.Name = "Lock_pictureBox";
            this.Lock_pictureBox.Size = new System.Drawing.Size(46, 43);
            this.Lock_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Lock_pictureBox.TabIndex = 0;
            this.Lock_pictureBox.TabStop = false;
            // 
            // TopBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TopBase";
            this.Size = new System.Drawing.Size(889, 544);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Lock_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel Base_panel;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button Plus_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Settings_button;
        private System.Windows.Forms.PictureBox Lock_pictureBox;
    }
}
>>>>>>> 778e97e77ed83c077448bd98246c6db0bc3cd5ef:app/Windows/View/Top/TopBase.Designer.cs
