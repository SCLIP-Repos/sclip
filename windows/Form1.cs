using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SCLIP_CryptoModule;

namespace SCLIP
{
    public partial class Form1 : Form
    {
        private static UserControls.Item.View viewControl;

        private static UserControls.Item.Edit editControl;

        private static UserControls.Item.QRView qrviewControl;

        

        public Form1()
        {
            InitializeComponent();

            Registration();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Switch(SelectControls.QRView);
        }

        internal static void Switch(Enum @enum)
        {
            switch(@enum)
            {
                case SelectControls.Init:
                    viewControl.Visible = false;

                    editControl.Visible = false;

                    qrviewControl.Visible = false;
                    break;

                case SelectControls.View:
                    Switch(SelectControls.Init);

                    viewControl.Visible = true;
                    break;

                case SelectControls.Edit:
                    Switch(SelectControls.Init);

                    editControl.Visible = true;
                    break;

                case SelectControls.QRView:
                    Switch(SelectControls.Init);

                    qrviewControl.Visible = true;
                    break;
            }
        }

        private void Registration()
        {
            viewControl = new UserControls.Item.View();

            editControl = new UserControls.Item.Edit();

            qrviewControl = new UserControls.Item.QRView();

            Base_panel.Controls.Add(viewControl);

            Base_panel.Controls.Add(editControl);

            Base_panel.Controls.Add(qrviewControl);
        }
    }
}