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
        private Inventory MainInventory;
        List<Product> Temp = new List<Product>();
        public Form2Cart()
        {
            InitializeComponent();
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2Cart_Load(object sender, EventArgs e)
        {

        }
    }
}
