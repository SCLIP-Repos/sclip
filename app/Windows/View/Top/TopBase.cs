using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCLIP.View.Top
{
    public partial class TopBase : UserControl
    {
        private static Item.ItemView _itemView = new Item.ItemView();

        private InternalWindow _internalWindow;


        public TopBase()
        {
            InitializeComponent();

            Registration();
        }
        

        internal void SwitchMode(Enum SelectChannel)
        {
            switch(SelectChannel)
            {
                case Channel.Init:
                    _itemView.Visible = false;
                    _internalWindow = null;
                    break;

                case Channel.New:
                    SwitchMode(Channel.Init);
                    break;

                case Channel.Edit:
                    SwitchMode(Channel.Init);
                    break;

            }
        }


        private void Registration()
        {
            Base_panel.Controls.Add(_itemView);

            _internalWindow = new InternalWindow();
        }
    }
}
