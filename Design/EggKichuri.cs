using Meal.Imrul;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meal.Design
{
    public partial class EggKichuri : Form
    {

        private readonly int newUserId;
        private decimal basePrice = 60;
        private int quantity = 1;
        public EggKichuri(int userId)
        {
            InitializeComponent();
            newUserId = userId;
        }

        private void EggKichuri_Load(object sender, EventArgs e)
        {
            label2.Text = basePrice.ToString("N0") + " TK";
            lblQuantity.Text = quantity.ToString();

            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            decimal total = basePrice * quantity;
            label2.Text = total.ToString("N0") + " Tk";
        }


        
        private void backlabel3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FoodItem f2 = new FoodItem(newUserId);
            f2.Show();
        }

        private void BtnAddToCart_Click_1(object sender, EventArgs e)
        {
            Cart item = new Cart
            {
                FoodName = "Beef khichuri with Begun Vaja",
                Price = basePrice,
                Quantity = quantity
            };

            Hide();
            AddToCart a1 = new AddToCart(newUserId, item);
            a1.Show();
        }

        private void LblPlus_Click(object sender, EventArgs e)
        {
            quantity++;
            lblQuantity.Text = quantity.ToString();
            UpdateDisplay();
        }

        private void LblMinus_Click(object sender, EventArgs e)
        {

            if (quantity > 1)
            {
                quantity--;
                lblQuantity.Text = quantity.ToString();
                UpdateDisplay();
            }
        }
    }
}
