﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NT106_Q14_DoAnGroup08.DAO;

namespace NT106_Q14_DoAnGroup08.ClientCustomer
{
    public partial class frm_Customer_FoodMenu : Form
    {
        public frm_Customer_FoodMenu()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Customer_FoodMenu_Load(object sender, EventArgs e)
        {
            guna2DataGridView1.BorderStyle = BorderStyle.FixedSingle;
            CategoryDAO.Instance.AddCategory(CategoryPanel1);
        }
    }
}
