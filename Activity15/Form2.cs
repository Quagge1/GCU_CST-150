using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_15
{
    public partial class Form2 : Form
    {
        //Variables to transfer data between forms
        public static Form2 Instance;
        public Form2()
        {
            InitializeComponent();
            Instance = this;
        }
        //On load event to display lucky number in a lable 
        private void Form2_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            int result = rand.Next(10, 100);
            LuckyNum.Text = result.ToString();
            //Based on user zodiac sign input color of lucky number will change
            /*Using the instance varibles to get input from textbox 4(Sign) to 
             change color based off user input*/
            if(Form1.instance.tb1.Text == "Libra")
            {
                LuckyNum.ForeColor = Color.Blue;
            }
            else if(Form1.instance.tb1.Text == "Aries")
            {
                LuckyNum.ForeColor = Color.Red;
            }
            else if(Form1.instance.tb1.Text == "Taurus")
            {
                LuckyNum.ForeColor = Color.Green;
            }
            else if(Form1.instance.tb1.Text == "Gemini")
            {
                LuckyNum.ForeColor = Color.Yellow;
            }
            else if(Form1.instance.tb1.Text == "Cancer")
            {
                LuckyNum.ForeColor = Color.Silver;
            }
            else if(Form1.instance.tb1.Text == "Leo")
            {
                LuckyNum.ForeColor = Color.Gold;
            }
            else if(Form1.instance.tb1.Text == "Virgo")
            {
                LuckyNum.ForeColor = Color.Brown;
            }
            else if(Form1.instance.tb1.Text == "Scorpio")
            {
                LuckyNum.ForeColor = Color.Black;
            }
            else if(Form1.instance.tb1.Text == "Sagittarius")
            {
                LuckyNum.ForeColor = Color.Purple;
            }
            else if(Form1.instance.tb1.Text == "Capricorn")
            {
                LuckyNum.ForeColor = Color.Gray;
            }
            else if(Form1.instance.tb1.Text == "Aquarius")
            {
                LuckyNum.ForeColor = Color.Blue;
            }
            else if(Form1.instance.tb1.Text == "Pisces")
            {
                LuckyNum.ForeColor = Color.Cyan;
            }
        }

        //Close form on button click
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
