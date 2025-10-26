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
    public partial class uc_Product : UserControl
    {
        public uc_Product()
        {
            InitializeComponent();
            this.Size = new Size(288, 334);
        }

        public event EventHandler onselect = null;

        public int id {get;set;}
        public string FoodName
        {
            get { return lblName.Text; }
            set { lblName.Text = value; }
        }
        public string FoodPrice { get; set; }

        public Image FoodImage 
        { 
            get { return txtImage.Image; }
            set { txtImage.Image = value; }
        }

        private void txtImage_Click(object sender, EventArgs e)
        {
            onselect?.Invoke(this, e);
        }
    }
}
