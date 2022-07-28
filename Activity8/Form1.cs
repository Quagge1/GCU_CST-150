namespace Activity8
{
    public partial class Form1 : Form
    {
        private int caloriesFromFat;
        private int caloriesFromCarbs;

        public Form1()
        {
            InitializeComponent();
        }
        //Method to calculate calories from fat
        public int FatCalories(int fGrams)
        {
            //using parse to take input from textbox
            int value = int.Parse(FatGrams.Text.ToString());
            //using value variable to hold textbox number input
            fGrams = value;
            //conversion to calories from fat
            caloriesFromFat = fGrams * 9;
            
            return caloriesFromFat;
        }
        //Method to calculate calories from carbs
        public int CarbCalories(int cGrams)
        {
            //same strategie as used in prior method to take input from user and store it in value
            //then convert it to calories from carbs 
            int value = int.Parse(CarbGrams.Text.ToString());
            cGrams = value;
            caloriesFromCarbs = cGrams * 4;

            return caloriesFromCarbs;
        }

        //calculate calories on button click
        private void button1_Click(object sender, EventArgs e)
        {
            //message box to show conversion from fat and carbs calling each method
            MessageBox.Show("Calroies from fat: " + FatCalories(caloriesFromFat).ToString() + " " + "Calories from Carbs: " + CarbCalories(caloriesFromCarbs).ToString());
        }
        //exit form
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}