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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Act.Sets.Authentication authentication = new Act.Sets.Authentication();

            bool bl = authentication.Match(textBox1.Text);

            if(!bl)
            {
                MessageBox.Show("パスワードが一致しません。");
                return;
            }

            this.Close();
        }
    }
}
