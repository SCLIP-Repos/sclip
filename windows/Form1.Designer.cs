namespace SCLIP
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
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.ItemAdd_button = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemEdit_button = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemDelete_button = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemSets_button = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Base_panel = new System.Windows.Forms.Panel();
            this.Item_listBox = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.ItemSets_button,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(866, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripComboBox1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemAdd_button,
            this.ItemEdit_button,
            this.ItemDelete_button});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(56, 22);
            this.toolStripComboBox1.Text = "アイテム";
            // 
            // ItemAdd_button
            // 
            this.ItemAdd_button.Name = "ItemAdd_button";
            this.ItemAdd_button.Size = new System.Drawing.Size(180, 22);
            this.ItemAdd_button.Text = "追加";
            // 
            // ItemEdit_button
            // 
            this.ItemEdit_button.Name = "ItemEdit_button";
            this.ItemEdit_button.Size = new System.Drawing.Size(180, 22);
            this.ItemEdit_button.Text = "編集";
            // 
            // ItemDelete_button
            // 
            this.ItemDelete_button.Name = "ItemDelete_button";
            this.ItemDelete_button.Size = new System.Drawing.Size(180, 22);
            this.ItemDelete_button.Text = "削除";
            // 
            // ItemSets_button
            // 
            this.ItemSets_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ItemSets_button.Image = ((System.Drawing.Image)(resources.GetObject("ItemSets_button.Image")));
            this.ItemSets_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItemSets_button.Name = "ItemSets_button";
            this.ItemSets_button.Size = new System.Drawing.Size(35, 22);
            this.ItemSets_button.Text = "設定";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(55, 22);
            this.toolStripButton1.Text = "ログアウト";
            // 
            // Base_panel
            // 
            this.Base_panel.BackColor = System.Drawing.Color.White;
            this.Base_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Base_panel.Location = new System.Drawing.Point(134, 25);
            this.Base_panel.Name = "Base_panel";
            this.Base_panel.Size = new System.Drawing.Size(732, 507);
            this.Base_panel.TabIndex = 1;
            // 
            // Item_listBox
            // 
            this.Item_listBox.BackColor = System.Drawing.Color.White;
            this.Item_listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Item_listBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.Item_listBox.FormattingEnabled = true;
            this.Item_listBox.ItemHeight = 12;
            this.Item_listBox.Location = new System.Drawing.Point(0, 25);
            this.Item_listBox.Name = "Item_listBox";
            this.Item_listBox.Size = new System.Drawing.Size(128, 507);
            this.Item_listBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 532);
            this.Controls.Add(this.Item_listBox);
            this.Controls.Add(this.Base_panel);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "SCLIP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem ItemAdd_button;
        private System.Windows.Forms.ToolStripMenuItem ItemEdit_button;
        private System.Windows.Forms.ToolStripMenuItem ItemDelete_button;
        private System.Windows.Forms.ToolStripButton ItemSets_button;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Panel Base_panel;
        private System.Windows.Forms.ListBox Item_listBox;
    }
}

