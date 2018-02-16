namespace $safeprojectname$.Form1Controls
{
    partial class List
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
            this.Item_ListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Item_ListView
            // 
            this.Item_ListView.BackColor = System.Drawing.Color.White;
            this.Item_ListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Item_ListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Item_ListView.Location = new System.Drawing.Point(0, 0);
            this.Item_ListView.Name = "Item_ListView";
            this.Item_ListView.Size = new System.Drawing.Size(638, 479);
            this.Item_ListView.TabIndex = 0;
            this.Item_ListView.UseCompatibleStateImageBehavior = false;
            this.Item_ListView.View = System.Windows.Forms.View.SmallIcon;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Item_ListView);
            this.Name = "List";
            this.Size = new System.Drawing.Size(638, 479);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView Item_ListView;
    }
}
