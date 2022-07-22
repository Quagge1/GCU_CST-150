using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_5
{
    public partial class ProcessForm : Form

    {
        public MainForm main { get; set; }
        public string FileContents { get; set; }
        public ProcessForm()
        {
            InitializeComponent();
            
        }

        private void ProcessForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(main.txtFile))
            {
                FileContents = File.ReadAllText(main.txtFile);
                this.textBox1.Text = FileContents;
            }
            //making all lower case
            textBox1.Text = "All Lower Case:\n " + FileContents.ToLower();

            //sort Alphabetically and show first and last index after sorting
            List<string> list = File.ReadAllLines(main.txtFile).ToList();
            list.Sort();
            textBox1.Text += String.Format("\n\nFirst and last Alphabetical:\n " + " " + list[0] + " " + list[5]);

            //find index location of largest word
            //reference youtube.com. I used this for coding examples to create this code
            string[] stringOfWords = FileContents.Split(' ');
            int max = 0;
            int maxIndex = 0;

                for(int i = 0; i < stringOfWords.Length; i++)
                {
                    if(max < stringOfWords[i].Length)
                    {
                        max = stringOfWords[i].Length;
                        maxIndex = i;
                    }
                    textBox1.Text += String.Format("\n\n Largest word at index:\n " + maxIndex);
                }
            //find the word with the most vowels
            //reference youtube.com. I used this for coding examples to create this code
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            string word = "";
            string[] strings = FileContents.Split(' ');
            var mostVowels = 0;

                for(int i = 0; i < strings.Length; i++)
                {
                    var part = strings[i];
                    var numberOfVowels = 0;
                    foreach (var vowel in vowels)
                    {
                        if (part.Contains(vowel)) numberOfVowels++;
           
                    }
                    if(mostVowels < numberOfVowels)
                    {
                        mostVowels = i;
                        word = part;
                    }
                     textBox1.Text += String.Format("\n\n Word with most vowels:\n " + word);     
                }
               


            }
        }
    }

