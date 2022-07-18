namespace Activity4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1Calculate_Click(object sender, EventArgs e)
        {
            int seconds = 0;
            int minutes = 0;
            int hours = 0;
            int days = 0;

            seconds = int.Parse(textBox1.Text);
            minutes = seconds / 60;
            hours = minutes / 60;
            days = hours / 24;

            if(seconds >= 86400)
            {
                MessageBox.Show(days.ToString() + " days");
            }
            else if(seconds >= 3600)
            {
                MessageBox.Show(hours.ToString() + " hours");
            }
            else if(seconds >= 60)
            {
                MessageBox.Show(minutes.ToString() + " minutes");
            }
            else
            {
                MessageBox.Show(seconds.ToString() + " seconds");
            }

        }
    }
}