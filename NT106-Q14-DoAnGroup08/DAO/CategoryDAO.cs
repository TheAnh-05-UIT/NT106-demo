﻿using QuanLyQuanNet.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace NT106_Q14_DoAnGroup08.DAO
{
    internal class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set => instance = value;
        }
        private CategoryDAO() { }

        public void AddCategory(FlowLayoutPanel CategoryPanel)
        {
            string query = "Select * from Category";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            CategoryPanel.Controls.Clear();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Guna.UI2.WinForms.Guna2Button b = new Guna.UI2.WinForms.Guna2Button();
                    b.FillColor = Color.FromArgb(0, 32, 63);
                    b.Size = new Size(120, 50);
                    b.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
                    b.Text = row["CategoryName"].ToString();

                    CategoryPanel.Controls.Add(b);
                }
            }
        }


    }
}