using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCLIP
{
    public partial class InternalWindow : Form
    {
        private static View.Top.Item.ItemControl _itemControl = new View.Top.Item.ItemControl();

        private static View.Top.Sets _sets = new View.Top.Sets();

        public InternalWindow()
        {
            InitializeComponent();

            Registration();
        }

        
        internal void SwitchView(Enum SelectChannel)
        {
            switch(SelectChannel)
            {
                case Channel.Init:
                    _itemControl.Visible = false;

                    break;

                case Channel.ItemControl:
                    break;

                case Channel.Settings:
                    break;
            }
        }

        private void Registration()
        {
            Base_panel.Controls.Add(_itemControl);
        }
    }
}
