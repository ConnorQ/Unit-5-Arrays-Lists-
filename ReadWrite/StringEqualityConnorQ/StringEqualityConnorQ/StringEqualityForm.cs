/*
 * Created by: Connor Quinlan
 * Created on: 30-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #40 - Read Write
 * This program tests if pairs of strings are equal.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringEqualityConnorQ
{
    public partial class frmStringEquality : Form
    {
        public frmStringEquality()
        {
            InitializeComponent();
        }

        public bool Check(string input1, string input2)
        {
            //set the strings to not equal
            bool equal = false;

            //check if the strings are the same length
            if (input1.Length == input2.Length)
            {
                //set them both to all capitals
                input1 = input1.ToUpper();
                input2 = input2.ToUpper();

                //check if the strings are the same
                if (input1 == input2)
                {
                    equal = true;
                }
            }
            return equal;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // copy input file to lines array
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");

            // array of spaces to know how to split words
            char[] charSeparators = new char[] { ' ', '\t' };

            // string used for results
            string output = "";

            // go through and compare each string on each line of the file
            foreach (string line in lines)
            {
                // split up words on line\
                string[] words = line.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

                if (Check(words[0], words[1]) == true)
                {
                    // add true to output
                    output = output + "True\r\n";
                }
                else
                {
                    // add false to output
                    output = output + "False\r\n";
                }

                // create output file and display the output on it
                System.IO.File.WriteAllText(@"output.txt", output);
            }
        }
    }
}
