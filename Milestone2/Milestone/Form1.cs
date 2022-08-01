namespace Milestone
{
    public partial class Form1Main : Form
    {
        private Inventory MainInventory;
        public Form1Main()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

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
                Form2Cart frm2 = new Form2Cart();
                frm2.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1Main_Load(object sender, EventArgs e)
        {
            MainInventory = new Inventory();
            MainInventory.AddProduct(new Product("PS5", "Console", 500.00, 1));
            MainInventory.AddProduct(new Product("XBOX", "Console", 500.00, 1));
            MainInventory.AddProduct(new Product("PC", "Console", 1400.00, 1));
            MainInventory.AddProduct(new Product("Halo", "Game", 60.00, 1));
            MainInventory.AddProduct(new Product("God Of War", "Game", 60, 1));
            MainInventory.AddProduct(new Product("Apex Lengends", "Game", 60.00, 1));
            MainInventory.AddProduct(new Product("Controller", "Periphrials", 60.00, 1));
            MainInventory.AddProduct(new Product("Mouse", "Periphrials", 80.00, 1));
            MainInventory.AddProduct(new Product("Keyboard", "Periphrials", 120.00, 1));


        }
    }
}
    