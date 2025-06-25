using Meal.Database;
using Meal.Design;
using Meal.Imrul;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meal.Design
{
    public partial class ShowProfile : Form
    {

        private readonly int newUserId;
        private readonly Helper db;
        public ShowProfile(int newUserId)
        {
            InitializeComponent();
            usernametextBox.ReadOnly = true;
            this.newUserId = newUserId;

            db = new Helper();

        }

        private void ShowProfile_Load(object sender, EventArgs e)
        {
            editbutton.Click += editbutton_Click;
            savebutton.Click += savebutton_Click;
            cancelbutton.Click += cancelbutton_Click;


            LoadUserProfile();
        }


        private void LoadUserProfile()
        {
            try
            {
                DataRow userProfile = db.GetUserProfileById(newUserId);
                if (userProfile == null)
                {
                    MessageBox.Show("User profile not found.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                // Populate text fields
                usernametextBox.Text = userProfile["Username"]?.ToString() ?? string.Empty;
                emailtextBox.Text = userProfile["Email"]?.ToString() ?? string.Empty;
                mobiletextBox.Text = userProfile["Mobile"]?.ToString() ?? string.Empty;
                addresstextBox.Text = userProfile["Address"]?.ToString() ?? string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user profile: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ToggleEditMode(bool isEditable)
        {
            emailtextBox.ReadOnly = !isEditable;
            mobiletextBox.ReadOnly = !isEditable;
            addresstextBox.ReadOnly = !isEditable;
            cancelbutton.Visible = isEditable;
            savebutton.Visible = isEditable;
            editbutton.Visible = !isEditable;
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            ToggleEditMode(true);
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                string email = emailtextBox.Text.Trim();
                string username = usernametextBox.Text.Trim();
                string mobile = mobiletextBox.Text.Trim();
                string address = addresstextBox.Text.Trim();

                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Email is required.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(username))
                {
                    MessageBox.Show("Full Name is required.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Debug: Log profile update details
                Console.WriteLine($"Updating Profile: Username={username}, Email={email}, Address={address},  Mobile={mobile}");

                // Save to DB
                db.UpdateUserProfile(newUserId, email, address, mobile);

                MessageBox.Show("Profile updated.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset form to view-only mode
                ToggleEditMode(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving profile: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            ToggleEditMode(false);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FoodItem f2 = new FoodItem(newUserId);
            f2.Show();
        }
    }
}
