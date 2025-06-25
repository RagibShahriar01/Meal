using Meal.Database;
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
    public partial class Adminlogin : Form
    {
        public Adminlogin()
        {
            InitializeComponent();
        }

        private void Adminlogin_Load(object sender, EventArgs e)
        {
            passwordtext.UseSystemPasswordChar = true;

            Helper hp = new Helper();
            bool isConnected = hp.TestConnection();
            if (!isConnected)
            {

                loginbutton.Enabled = false;
                MessageBox.Show("Cannot connect to the database. Please check your connection settings.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Registerationbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminRegistration reg = new AdminRegistration();
            reg.Show();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string adminname = usernametext.Text.Trim();
            string password = passwordtext.Text;

            // Input Validation
            if (string.IsNullOrEmpty(adminname) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

                Helper db = new Helper();


                Admins existingAdmin = db.GetAdminByName(adminname);

                if (existingAdmin == null)
                {

                    MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (password == existingAdmin.Password)
                {
                    // Authentication successful
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Redirect based on role
                    RedirectAdmin(existingAdmin.AdminID);


                    // Optionally, close the Login Form
                    this.Hide();
                }
                else
                {
                    // Password does not match
                    MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                MessageBox.Show("An error occurred during login: " + ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void RedirectAdmin(int adminId)
        {

            Helper db3 = new Helper();
            Admins admin = db3.GetAdminByID(adminId);

            if (admin != null)
            {

                Admin a1 = new Admin (admin.AdminID);
                a1.Show();
            }
            else
            {
                MessageBox.Show("Admin profile not found. Please contact support.", "Profile Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lo2 = new Login();
            lo2.Show();
        }
    }
}
