using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Activity_12
{
    class Reader
    {
        
        static void Main(string[] args)
        {
            //reading file in
            string text= File.ReadAllText(@"E:\Users\Beast\Desktop\College stuff\TextFiles\Activity12.txt");

            //createing an array out of the text in the file, removing the punctuation, spliting the words from the text files 
            //so that they can be looped through and be indiviual words
            string[] tokens = text.Replace(",","").Replace("!","").Split();

            //to keep count of words ending in t or e
            int count = 0;

            //looping through array to find words ending with t or e
            foreach(string item in tokens)
{               //printing words from file
                Console.WriteLine(item);
                char last_char = item[item.Length - 1];
                if (last_char == 't' || last_char == 'e')
                {
                    count++;
                }
                
            }
            //for a line break
            Console.WriteLine();
            //printing final output with word count
            Console.WriteLine("There are " + count + " words that ends with t or e.");
        }
    }
}

