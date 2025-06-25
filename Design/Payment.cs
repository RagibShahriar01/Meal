using Meal.Database;
using Meal.Design;
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
    public partial class Payment : Form
    {

        private readonly int newUserId;
        private readonly Cart cart;
        private readonly Helper db = new Helper();
        public Payment(int userId, Cart item)
        {
            InitializeComponent();
            newUserId = userId;
            cart = item;
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            lblAmount.Text = (cart.Price * cart.Quantity).ToString("N0") + " TK";
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            string paymentMethod = radioBkash.Checked ? "Bkash"
               : radioNagad.Checked ? "Nagad"
               : radiocash.Checked ? "CashOnDelivery"
               : null;

            
            db.AddFoodBuy(
                newUserId,
                cart.FoodName,
                cart.Price,
                cart.Quantity,
                paymentMethod
            );

            MessageBox.Show("Your order is confirmed!", "Order Placed",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            this.Hide();
            FoodItem f4 = new FoodItem(newUserId);
            f4.Show();
        }

        private void lblAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
