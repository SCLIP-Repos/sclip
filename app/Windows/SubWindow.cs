using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View.Item;
using View.Sets;

namespace SCLIP
{
    public partial class SubWindow : Form
    {
        private static ItemControl _itemControlView = new ItemControl();

        private static Setting _settingView = new Setting();



        public SubWindow()
        {
            InitializeComponent();

            Registration();
        }


        internal static void Switch(Enum SelectChannel)
        {

            switch(SelectChannel)
            {
                case Channel.Init:
                    _itemControlView.Visible = false;
                    _settingView.Visible = false;
                    break;

                case Channel.ItemControl:
                    Switch(Channel.Init);
                    _itemControlView.Visible = true;
                    break;

                case Channel.Setting:
                    Switch(Channel.Init);
                    _settingView.Visible = true;
                    break;
            }

        }



        private void Registration()
        {
            Base_panel.Controls.Add(_itemControlView);

            Base_panel.Controls.Add(_settingView);
        }
    }
}
