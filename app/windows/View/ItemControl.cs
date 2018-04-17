using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCLIP.View
{
    public partial class ItemControl : UserControl
    {
        internal string[] SET = new string[8];

        private bool _EditMode = false;

        public ItemControl(bool EditMode)
        {
            InitializeComponent();

            _EditMode = EditMode;

            Load();

        }


        private new void Load()
        {
            Service_label.Text = SET[0];

            URL_textBox.Text = SET[1];

            Nicname_textBox.Text = SET[2];

            ID_textBox.Text = SET[3];

            Passwd_textBox.Text = SET[4];

            Mail_textBox.Text = SET[5];

            TEL_textBox.Text = SET[6];

            Memo_richTextBox.Text = SET[7];


            for (int i = 0; i < 8; i++)
                SET[i] = null;
        }

        private void Save()
        {
            string[] Tmp =
            {
                Service_textBox.Text  + ',', 

                URL_textBox.Text + ',',

                Nicname_textBox.Text + ',',

                ID_textBox.Text + ',',

                Passwd_textBox.Text + ',',

                Mail_textBox.Text + ',',

                TEL_textBox.Text + ',',

                Memo_richTextBox.Text

            };


        }

        private void OK_button_Click(object sender, EventArgs e)
        {

        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {

        }
    }
}
