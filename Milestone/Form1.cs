namespace Milestone
{
    public partial class Form1Main : Form
    {
        //global variables for the inventory and to get to form 2
        private Inventory MainInventory;
        private Form2Cart frm2;

        //constructor for the form
        public Form1Main()
        {
            InitializeComponent();
            MainInventory = new Inventory();
            frm2 = new Form2Cart(MainInventory, this);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Method left intentionally blank
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Method left intentionally blank
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Method left intentionally blank
        }
        //taking user selected items and loading them into cart in form 2
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != null && comboBox2.SelectedIndex != null && comboBox3.SelectedIndex != null)
            {
                foreach (Product p in MainInventory.GetproductsAvaliable())
                {
                    
                    if (comboBox1.Text.Equals(p.showProdcutName()))
                    {
                        MainInventory.ProductSold(p);
                    }
                    else if (comboBox2.Text.ToString().Equals(p.showProdcutName()))
                    {
                        MainInventory.ProductSold(p);
                    }
                    else if (comboBox3.Text.ToString().Equals(p.showProdcutName()))
                    {
                        MainInventory.ProductSold(p);
                    }
                }
                //moving to form 2 and populating the cart
                frm2.PopulateCart();
                frm2.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this method was lefte intentionally blank
        }

        private void Form1Main_Load(object sender, EventArgs e)
        {
            //New feature added as requested by the assignment
            MessageBox.Show("Welcome to the Gamer Store, Check out what we have available");
            //Adding all items for purchase to the Online store
            MainInventory.AddProduct(new Product("PS5", "Console", 500.00, 1));
            MainInventory.AddProduct(new Product("XBOX", "Console", 500.00, 1));
            MainInventory.AddProduct(new Product("PC", "Console", 1400.00, 1));
            MainInventory.AddProduct(new Product("Halo", "Game", 60.00, 1));
            MainInventory.AddProduct(new Product("God Of War", "Game", 60, 1));
            MainInventory.AddProduct(new Product("Apex Lengends", "Game", 60.00, 1));
            MainInventory.AddProduct(new Product("Controller", "Periphrials", 60.00, 1));
            MainInventory.AddProduct(new Product("Mouse", "Periphrials", 80.00, 1));
            MainInventory.AddProduct(new Product("Keyboard", "Periphrials", 120.00, 1));
            ImportInventory();
            


        }
        //loads inventory items into comboboxes
        private void ImportInventory()
        {
            //Allowing to select one item and one item only if that is the user's wish
            comboBox1.Items.Add("");
            comboBox2.Items.Add("");
            comboBox3.Items.Add("");
            foreach (Product p in MainInventory.GetproductsAvaliable())
            {
                if(p.GetProductDescription() == "Console")
                {
                    comboBox1.Items.Add(p.showProdcutName());
                }
                 if(p.GetProductDescription() == "Game")
                {
                    comboBox2.Items.Add(p.showProdcutName());
                }
                if (p.GetProductDescription() == "Periphrials")
                {
                    comboBox3.Items.Add(p.showProdcutName());
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //new feature added for assignment
            this.Close();
        }
    }
}
    