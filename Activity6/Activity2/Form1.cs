/*reference www.youtube.com/c/ProfessorSaad*/

namespace Activity2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try catch block to catch runtime errors
            try
            {
                //variables
                double celcius = 0.0;
                double fahrenheit = 0.0;

                fahrenheit = Convert.ToDouble(textF.Text);
                //made the 5 a double so that conversion is correct
                celcius = (5.0 / 9) * (fahrenheit - 32);
                //using toString convert from double to string
                textC.Text = Math.Round(celcius, 3).ToString();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
    }
}