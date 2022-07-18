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
            //variables
            double c = 0.0;
            double f = 0.0;
            
            f = Convert.ToDouble(textF.Text);
            //made the 5 a double so that conversion is correct
            c = (5.0 / 9) * (f - 32);
            //using toString convert from double to string
            textC.Text = c.ToString();
        }
    }
}