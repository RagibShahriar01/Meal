using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Meal.Database;
using Meal.Design;
using Meal.Imrul;

namespace Meal.Design
{
    public partial class Admin : Form
    {

        private int _adminId;

        private readonly Helper db = new Helper();
        public Admin(int adminId)
        {
            InitializeComponent();
            _adminId = adminId;

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            dgv.DataSource = db.SearchByUsername(null);

            Loadbuy();
        }

        private void Loadbuy()
        {
            DataTable dt = db.GetBuy(/* all: no filter*/0);
            dgv.DataSource = dt;
        }

        private void BtnSavePrice_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            dgv.DataSource = db.SearchByUsername(TxtSearch.Text.Trim());
        }
    }
}
