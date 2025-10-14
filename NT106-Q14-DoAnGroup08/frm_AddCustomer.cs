using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106_Q14_DoAnGroup08
{
    public partial class frm_AddCustomer : Form
    {
        public frm_AddCustomer()
        {
            InitializeComponent();
        }
        public string CustomerName { get; private set; }
        public string Balance { get; private set; }
        public string Status{ get; private set; }
        public string userName { get; private set; }
        public string userPassword { get; private set; }
        private void frm_AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomerName = txtHoten.Text;
            Balance = txtSodu.Text;
            Status = cbbTrangthai.Text;
            userName = txtTenDangNhap.Text;
            userPassword = txtMatKhau.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCanCel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cbbTrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSodu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
