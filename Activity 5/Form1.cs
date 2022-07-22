namespace Activity_5
{
    public partial class MainForm : Form
    {
        //string filePath = @"E:\Users\Beast\Desktop\College stuff\TextFiles";
        public string txtFile;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
                txtFile = ofd.FileName;
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtFile.Length > 0)
            {
                ProcessForm processForm = new ProcessForm();
                processForm.main = this;
                processForm.Show();
                this.Hide();
            }
            else
            {
                textBox2.Text = "Please select a file";
            }
            
        }
    }
}