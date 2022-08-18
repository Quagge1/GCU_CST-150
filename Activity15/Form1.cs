namespace Activity_15
{
    public partial class Form1 : Form
    {
        //Variables to transfer data between forms
        public static Form1 instance;
        public TextBox tb1;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            tb1 = Signtxt;
        }
        //Loading form2 on button click and hiding form1
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Results = new Form2();
            Results.Show();
            this.Hide();
        }

        //Form Load message box to tell the user that Case of input matters
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This Form Is Case Sensitive");
        }
    }
}