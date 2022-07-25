namespace Activity_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Calculate_Click(object sender, EventArgs e)
        {
            //to grab textbox input
            string number = textBox1.Text;
            //method to calculate PI
            static double PI(double pi, double n, double sign)
            {
                //iterating 1000000 times to make sure that the PI is accurate
                for (double i = 0; i <= 1000000; i++)
                {
                    pi = pi + (sign * (4 / ((n) * (n + 1) * (n + 2))));

                    sign = sign * (-1);

                    n += 2;
                }
                return pi;
            }

            //If block to make sure user input is in
            if (textBox1.Text == number)
            {
               //having to add values to PI method since it takes 3 parameters
               MessageBox.Show("Pi equals " + PI(3, 2, 1));
                
                
            }
            else
            {
                MessageBox.Show("No entry made");
            }
        }
        //exception handling in case the method was not called 
        private string PI(string v)
        {
            throw new NotImplementedException();
        }
    }
}