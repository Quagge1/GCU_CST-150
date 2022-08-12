namespace Activity_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Double clicked in error caused this generated code. Cannot delete or
        //it will destroy the form
        private void Armor_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declared variables to hold selected values
            //lstText variable calls the listbox and gets its slected item text in one line
            string lstText = ArmorLstBx.GetItemText(ArmorLstBx.SelectedItem);
            string radText = GetRadioButton();
            string chxText = GetChcekBox();
            
            //method to get radio button selections
            string GetRadioButton()
            {
                if(Potion.Checked)
                {
                    return Potion.Text.ToString();
                }
                else if (Elixer.Checked)
                {
                    return Elixer.Text.ToString();
                }
                else if (Remedy.Checked)
                {
                    return Remedy.Text.ToString();
                }
                else
                {
                    return "Make Selection ";
                }
            }
            //method to get checkbox selections
            string GetChcekBox()
            {
                if (Sword.Checked)
                {
                    return Sword.Text.ToString();
                }
                else if (Spear.Checked)
                {
                    return Spear.Text.ToString();
                }
                else if (Shield.Checked)
                {
                    return Shield.Text.ToString(); 
                }
                else
                {
                    return null;
                }
            }
            //Callling message box to show what the user bought per selections stored in variables
            MessageBox.Show("You bought: " + radText + ", " + chxText + ", " + lstText);
          
        }
    }
}