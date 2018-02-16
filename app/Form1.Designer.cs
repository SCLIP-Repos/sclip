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
            this.Base_Panel = new System.Windows.Forms.Panel();
            this.ItemList_listView = new System.Windows.Forms.ListView();
            this.DirectoryList_listView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Base_Panel
            // 
            this.Base_Panel.Location = new System.Drawing.Point(345, 2);
            this.Base_Panel.Name = "Base_Panel";
            this.Base_Panel.Size = new System.Drawing.Size(638, 520);
            this.Base_Panel.TabIndex = 3;
            // 
            // ItemList_listView
            // 
            this.ItemList_listView.BackColor = System.Drawing.Color.White;
            this.ItemList_listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemList_listView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ItemList_listView.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ItemList_listView.Location = new System.Drawing.Point(158, 2);
            this.ItemList_listView.Name = "ItemList_listView";
            this.ItemList_listView.Size = new System.Drawing.Size(181, 520);
            this.ItemList_listView.TabIndex = 5;
            this.ItemList_listView.UseCompatibleStateImageBehavior = false;
            this.ItemList_listView.View = System.Windows.Forms.View.List;
            // 
            // DirectoryList_listView
            // 
            this.DirectoryList_listView.BackColor = System.Drawing.Color.White;
            this.DirectoryList_listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DirectoryList_listView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DirectoryList_listView.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.DirectoryList_listView.Location = new System.Drawing.Point(2, 2);
            this.DirectoryList_listView.Name = "DirectoryList_listView";
            this.DirectoryList_listView.Size = new System.Drawing.Size(150, 520);
            this.DirectoryList_listView.TabIndex = 6;
            this.DirectoryList_listView.UseCompatibleStateImageBehavior = false;
            this.DirectoryList_listView.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 526);
            this.Controls.Add(this.DirectoryList_listView);
            this.Controls.Add(this.ItemList_listView);
            this.Controls.Add(this.Base_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "$safeprojectname$";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Base_Panel;
        private System.Windows.Forms.ListView ItemList_listView;
        private System.Windows.Forms.ListView DirectoryList_listView;
    }
}

