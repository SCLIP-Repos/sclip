using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$.View
{
    public partial class Item : UserControl
    {
        public Item()
        {
            InitializeComponent();
        }




        /* パブリック */

        public void Load(string ServiceName)
        {
            Act.ItemControl itemControl = new Act.ItemControl();

            string tmp = itemControl.Decrypt(ServiceName);


            Service_label.Text = tmp.Split(',')[0];

            URL_label.Text = tmp.Split(',')[1];

            Name_label.Text = tmp.Split(',')[2];

            Passwd_label.Text = tmp.Split(',')[3];

            Mail_label.Text = tmp.Split(',')[4];

            TEL_label.Text = tmp.Split(',')[5];

            Memo_richTextBox.Text = tmp.Split(',')[6];

        }
    }
}
