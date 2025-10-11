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
    public partial class Staff : Form
    {
        private Staff_ImportGood ImportGood;
        public Staff()
        {
            InitializeComponent();
            ImportGood = new Staff_ImportGood();
            ShowUserControl(ImportGood);
        }

        private void ShowUserControl(UserControl newControl)
        {
            UserPanel.Controls.Clear();

            newControl.Dock = DockStyle.Fill;

            UserPanel.Controls.Add(newControl);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void ImportGoodButton_Click(object sender, EventArgs e)
        {
            ShowUserControl(ImportGood);
        }
    }
}
