﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCLIP.View.SetupForm
{
    public partial class Welcome : UserControl
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            SCLIP.SetupForm.Switch(SCLIP.SetupForm.Channel.Agree);
        }
    }
}