﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NT106_Q14_DoAnGroup08
{
    public partial class frm_Deposit : Form
    {
        public string Balance { get; private set; }
        public frm_Deposit()
        {
            InitializeComponent();
        }
        public void LoadCustomerData(string balance, string status, string username)
        {
         
            txtBalance.Text = balance;
            txtUserName.Text = username;
            txtStatus.Text = status;
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Balance = (int.Parse(txtBalance.Text) + int.Parse(txtDeposit.Text)).ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void frm_Deposit_Load(object sender, EventArgs e)
        {

        }
    }
}
