using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone
{
    public partial class Form2Cart : Form
    {
        //gloabals to get inventory selections over to form2
        private Inventory MainInventory;
        private Form frm1;
        
        //added Main inventory to the constructor of the class
        public Form2Cart(Inventory MainInvetory, Form frm1)
        {
            InitializeComponent();
            this.MainInventory = MainInvetory;
            this.frm1 = frm1;
        }
        

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this method was left intentionally blank
        }

        private void Form2Cart_Load(object sender, EventArgs e)
        {
            //this method was left intentionally blank
        }
        //to go back to the main form
        private void Main_Click(object sender, EventArgs e)
        {
            //going back to form 1
            frm1.Show();
            this.Hide();
        }
        //populating the cart and clearing it
        public void PopulateCart()
        {
            Cart.Items.Clear();
            foreach (Product p in MainInventory.GetCart())
            {
                Cart.Items.Add(p.showProdcutName() + " x" + p.ShowProductQuantity() + " $" + p.ShowProductPrice());
            }
        }
        //emptying the cart on button push and clearing the list box with populatecart()
        private void button3_Click(object sender, EventArgs e)
        {
            MainInventory.EmptyCart();
            PopulateCart();
        }
        //Placing order button click will show message box with total price of order and a thank you message
        private void button2_Click(object sender, EventArgs e)
        {
            double totalPrice = 0;
            foreach (Product p in MainInventory.GetCart()) {
                totalPrice += p.ShowProductPrice();
            }
            MainInventory.EmptyCart();
            PopulateCart();
            MessageBox.Show("Your total order was $" + totalPrice + " Thank you for your Order!");
        }
    }
}
