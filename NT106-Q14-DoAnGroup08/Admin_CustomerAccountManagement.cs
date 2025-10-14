using System;
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
    public partial class Admin_CustomerAccountManagement : Form
    {
        public Admin_CustomerAccountManagement()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void Admin_CustomerAccountManagement_Load(object sender, EventArgs e)
        {
           
        
            dgvAccCustomers.Rows.Add("KH01", "Nguyen Van A", "50,000", "Active", "UserA", "userA@123");
            dgvAccCustomers.Rows.Add("KH02", "Tran Thi B", "0","Inactive", "UserB", "userB@123");
            dgvAccCustomers.Rows.Add("KH03", "Le Van C", "120,000", "Active", "UserC", "userC@123");
        

    }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            frm_AddCustomer addUser = new frm_AddCustomer();
            if(addUser.ShowDialog() == DialogResult.OK)
            {
                string name = addUser.CustomerName;
                string balance = addUser.Balance;
                string status = addUser.Status;
                string username = addUser.userName;
                string userpass = addUser.userPassword;
                string id = "KH" + (dgvAccCustomers.Rows.Count).ToString("00");
                dgvAccCustomers.Rows.Add(id, name, balance, status, username, userpass);
            }
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {

        }
    }
}
