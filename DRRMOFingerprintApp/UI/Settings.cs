﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRRMOFingerprintApp.UI
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btnRegisterAccount_Click(object sender, EventArgs e)
        {
            var registerAccount = new RegisterAccount();
            registerAccount.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
