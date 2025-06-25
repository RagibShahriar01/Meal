using Meal.Imrul;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meal.Design
{
    public partial class FoodItem : Form
    {

        private int newUserId;

        public FoodItem(int userId)
        {
            InitializeComponent();
            this.newUserId = userId;
        }

        private void FoodItem_Load(object sender, EventArgs e)
        {

        }

        private void BeefkpictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            BeefKichuri b1 = new BeefKichuri (newUserId);
            b1.Show();
        }

        private void EggKpictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            EggKichuri E1 = new EggKichuri(newUserId);
            E1.Show();
        }

        private void parathapictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            Paratha b3 = new Paratha(newUserId);
            b3.Show();
        }

        private void RuipictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            RuiRice b7 = new RuiRice(newUserId);
            b7.Show();
        }

        private void BeefRpictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            BeefRice bb1 = new BeefRice (newUserId);
            bb1.Show();
        }

        private void checkenKpictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChickenKichuri c1 = new ChickenKichuri(newUserId);
            c1.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Login loginForm = new Login();
                loginForm.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowProfile myprofile = new ShowProfile(newUserId);
            myprofile.Show();
        }
    }
}
