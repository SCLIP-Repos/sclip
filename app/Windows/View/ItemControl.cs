using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FSys;

namespace $safeprojectname$.View
{
    public partial class ItemControl : UserControl
    {

        /*変数*/
        private  bool EditMode = false;


        /* コンストラクター */
        public ItemControl()
        {
            InitializeComponent();
        }


        /* パブリック */

        public void Read(string ServiceName)
        {

            EditMode = true;

            
            Act.ItemControl itemControl = new Act.ItemControl();

            string tmp = itemControl.Decrypt(ServiceName);


            Service_textBox.Text = tmp.Split(',')[0];

            URL_textBox.Text = tmp.Split(',')[1];

            Name_textBox.Text = tmp.Split(',')[2];

            Passwd_textBox.Text = tmp.Split(',')[3];

            Mail_textBox.Text = tmp.Split(',')[4];

            TEL_textBox.Text = tmp.Split(',')[5];

            Memo_richTextBox.Text = tmp.Split(',')[6];

            
        }

        public void Save(string ServiceName)
        {
            Act.ItemControl itemControl = new Act.ItemControl();

            itemControl.Encrypt(ServiceName,URL_textBox.Text,Name_textBox.Text,Passwd_textBox.Text,Mail_textBox.Text,TEL_textBox.Text,Memo_richTextBox.Text);
            
            EditMode = false;
        }




        /*　イベント駆動 */

        private void OK_button_Click(object sender, EventArgs e)
        {
            if(FileSt.Exists(Act.Paths.Directory[0] + Service_textBox.Text) && !EditMode)
            {
                MessageBox.Show("That item already exists.");
                return;
            }

            if (Service_textBox.Text != null)
                Save(Service_textBox.Text);
            else
                MessageBox.Show("The service name can not be empty.");


            Cancel_button_Click(sender, e);
            
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            Service_textBox.Text = null;

            URL_textBox.Text = null;

            Name_textBox.Text = null;

            Passwd_textBox.Text = null;

            Mail_textBox.Text = null;

            TEL_textBox.Text = null;

            Memo_richTextBox.Text = null;

            

            Form1.ViewSwitch(Form1.View_Channel.Init);
            
        }
    }
}
