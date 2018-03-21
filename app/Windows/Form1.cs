using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$
{
    public partial class Form1 : Form
    {

        /* 変数とクラス(public,internal,private) */
        internal static View.Item _itemView = new View.Item();

        internal static View.ItemControl _itemControlView = new View.ItemControl();
        


        /*コンストラクタ*/
        public Form1()
        {
            InitializeComponent();

            View_panel.Controls.Add(_itemView);
            View_panel.Controls.Add(_itemControlView);
        }


        /* パブリック */
        public static void ViewSwitch(Enum @enum)
        {
            switch(@enum)
            {
                case View_Channel.Init:
                    _itemView.Visible = false;
                    _itemControlView.Visible = false;
                    break;

                case View_Channel.ItemAdd:
                    ViewSwitch(View_Channel.Init);
                    _itemControlView.Visible = true;
                    break;

                    
                case View_Channel.ItemView:
                    ViewSwitch(View_Channel.Init);
                    _itemView.Visible = true;

                    break;
            }
        }


        public  void RefreshItemList()
        {

            ItemList_listView.Clear();
            

            Act.ItemControl itemControl = new Act.ItemControl();

            string[] tmpArray = itemControl.Items;

            for (int i = 0; i < tmpArray.Length; i++)
                ItemList_listView.Items.Add(System.IO.Path.GetFileName(tmpArray[i]));
        }


        /* プライベートメソッド */



        /* イベント駆動 */


        private void Form1_Load(object sender, EventArgs e)
        {
            //セットアップ済みかチェックする
            if(!Act.Configuration.isProfile())
            {
                //セットアップをする。
                //設定が完了するとログイン処理に"続かずに"アプリケーションをリスタートさせて設定を読み込みなおします。
                //設定を最後までせずに途中で中断された場合はアプリケーション事態を終了します。

                Setup setup = new Setup();

                Setup.SwitchView(1);

                setup.ShowDialog();

                
            }



            //ログイン処理
            Login login = new Login();

            login.ShowDialog();


            RefreshItemList();
          
        }

        private void Lock_pictureBox_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Sets_label_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();

            settings.ShowDialog();
        }




        private void New_button_Click(object sender, EventArgs e)
        {
            ViewSwitch(View_Channel.ItemAdd);
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            if(ItemList_listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Item is not selected.");
                return;
            }

            ViewSwitch(View_Channel.ItemAdd);


            ListViewItem listView = ItemList_listView.SelectedItems[0];

            _itemControlView.Read(listView.Text);
            
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (ItemList_listView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Item is not selected.");
                return;
            }




            DialogResult dialogResult = MessageBox.Show("Do you want to delete the selected item?" , "",MessageBoxButtons.YesNo,MessageBoxIcon.Stop,MessageBoxDefaultButton.Button2);

            if(dialogResult == DialogResult.Yes)
            {

                ListViewItem listView = ItemList_listView.SelectedItems[0];


                Act.ItemControl itemControl = new Act.ItemControl();

                itemControl.Delete(listView.Text);


                RefreshItemList();

                ViewSwitch(View_Channel.Init);

            }

        }

        private void ItemList_listView_Click(object sender, EventArgs e)
        {
            if (ItemList_listView.SelectedItems.Count == 0)
                return;

            ViewSwitch(View_Channel.ItemView);

            
            ListViewItem listView = ItemList_listView.SelectedItems[0];
            
            _itemView.Load(listView.Text);
        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            RefreshItemList();
        }
    }
}
