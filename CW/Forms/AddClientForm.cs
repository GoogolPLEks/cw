﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW.Forms
{
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            var FirstName = textBoxFirstName.Text;
            var SecondName = textBoxSecondName.Text;
            var ThirdName = textBoxThirdName.Text;
            var Address = textBoxAddress.Text;
            var Tenants = textBoxTenants.Text;
            var Area = textBoxArea.Text;
            var Passport = textBoxPassport.Text;
            var Login = textBoxCreateLogin.Text;
            var Password = textBoxCreatePassword.Text;
        }
    }
}