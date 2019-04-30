/*
 * Created by: Connor Quinlan
 * Created on: 04-30-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #36 - Find Max Value
 * This program finds the max value of a group of integers.
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

namespace FindMaxValue
{
    public partial class frmFindMaxValue : Form
    {
        public frmFindMaxValue()
        {
            InitializeComponent();
        }

        private int GetMaxValue(int[] tmpArrayOfIntegers)
        {
            //declaring variables and constants
            int tmpMaxValue = 0;
            int counter;
            const int MAX_ARRAY_SIZE = 10;


            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {

                if (tmpArrayOfIntegers[counter] > tmpMaxValue)
                {
                    //Sets the current max value to the current index if it is greater than the last max value
                    tmpMaxValue = tmpArrayOfIntegers[counter];
                }
            }

            //return the max value 
            return tmpMaxValue;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // declare local variables and constants
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_RANDOM_NUMBER = 500;
            int[] arrayOfIntegers = new int[MAX_ARRAY_SIZE];
            int counter, randomNumber, maxValue;
            Random randomNumberGenerator = new Random();

            //Clears the listbox
            lstNumbers.Items.Clear();


            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                //generate a random number
                randomNumber = randomNumberGenerator.Next(1, MAX_RANDOM_NUMBER + 1);

                //Setting the current index of the array to the generated number
                arrayOfIntegers[counter] = randomNumber;

                //Add the number to the listbox
                this.lstNumbers.Items.Add(randomNumber);

                //refresh the form
                this.Refresh();

            }

            //call the GetMaxValue function
            maxValue = GetMaxValue(arrayOfIntegers);

            //Display the max value
            lblMaxValue.Text = "The max value is: " + maxValue;
        }
    }
}
