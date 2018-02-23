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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.ItemDirectory_listView = new System.Windows.Forms.ListView();
            this.Item_listView = new System.Windows.Forms.ListView();
            this.UserControlBase_panel = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemDirectory_listView
            // 
            this.ItemDirectory_listView.BackColor = System.Drawing.Color.White;
            this.ItemDirectory_listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemDirectory_listView.ContextMenuStrip = this.contextMenuStrip1;
            this.ItemDirectory_listView.Dock = System.Windows.Forms.DockStyle.Left;
            this.ItemDirectory_listView.Font = new System.Drawing.Font("Segoe UI Emoji", 14F);
            this.ItemDirectory_listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.ItemDirectory_listView.Location = new System.Drawing.Point(0, 0);
            this.ItemDirectory_listView.Name = "ItemDirectory_listView";
            this.ItemDirectory_listView.Size = new System.Drawing.Size(146, 641);
            this.ItemDirectory_listView.TabIndex = 0;
            this.ItemDirectory_listView.UseCompatibleStateImageBehavior = false;
            this.ItemDirectory_listView.View = System.Windows.Forms.View.SmallIcon;
            this.ItemDirectory_listView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ItemDirectory_listView_MouseDown);
            // 
            // Item_listView
            // 
            this.Item_listView.BackColor = System.Drawing.Color.White;
            this.Item_listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Item_listView.Dock = System.Windows.Forms.DockStyle.Left;
            this.Item_listView.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_listView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.Item_listView.Location = new System.Drawing.Point(146, 0);
            this.Item_listView.Name = "Item_listView";
            this.Item_listView.Size = new System.Drawing.Size(146, 641);
            this.Item_listView.TabIndex = 1;
            this.Item_listView.UseCompatibleStateImageBehavior = false;
            this.Item_listView.View = System.Windows.Forms.View.List;
            this.Item_listView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Item_listView_MouseDown);
            // 
            // UserControlBase_panel
            // 
            this.UserControlBase_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.UserControlBase_panel.Location = new System.Drawing.Point(328, 0);
            this.UserControlBase_panel.Name = "UserControlBase_panel";
            this.UserControlBase_panel.Size = new System.Drawing.Size(743, 641);
            this.UserControlBase_panel.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 76);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.newToolStripMenuItem.Text = "New";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 641);
            this.Controls.Add(this.UserControlBase_panel);
            this.Controls.Add(this.Item_listView);
            this.Controls.Add(this.ItemDirectory_listView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "$safeprojectname$ β";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ItemDirectory_listView;
        private System.Windows.Forms.ListView Item_listView;
        private System.Windows.Forms.Panel UserControlBase_panel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

