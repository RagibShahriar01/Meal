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

namespace Meal
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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




        private void forgotbutton_Click(object sender, EventArgs e)
        {
            ForgetPassword fp = new ForgetPassword();
            fp.Show();
        }

        private void Registerationbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration();
            reg.Show();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            string username = usernametext.Text.Trim();
            string password = passwordtext.Text;

            // Input Validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                
                Helper db = new Helper();

                
                User existingUser = db.GetUserByname(username);

                if (existingUser == null)
                {
                    
                    MessageBox.Show("Invalid username or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (password == existingUser.Password)
                {
                    // Authentication successful
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Redirect based on role
                    RedirectUser(existingUser.UserID);


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


        private void RedirectUser(int userId)
        {
           
                    Helper db3 = new Helper();
                    User user = db3.GetUserByID(userId);

                    if (user != null)
                    {
                        
                        FoodItem Food = new FoodItem (user.UserID);
                        Food.Show();
                    }
                    else
                    {
                        MessageBox.Show("User profile not found. Please contact support.", "Profile Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adminlogin ad = new Adminlogin();
            ad.Show();
        }
    }
}
