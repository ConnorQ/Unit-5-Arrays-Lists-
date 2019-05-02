/*
 * Created by: Connor Quinlan
 * Created on: 02-05-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #41 - Pass or Fail
 * This program tests students grades based on weights to see how many students passed in each class.
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

namespace PassFailConnorQ
{
    public partial class frmPassFail : Form
    {
        // declare file paths
        string filepath = "DATA10.txt";
        string outputFile = "DATA10_Output.txt";

        // declare variables
        int counterA, counterB;
        float weightTests, weightAssign, weightProjects, weightQuizzes;
        float markTests, markAssign, markProjects, markQuizzes;
        int numPassed, numStudents;
        float average;

        public frmPassFail()
        {
            InitializeComponent();
        }

        private void btnParseFile_Click(object sender, EventArgs e)
        {
            // read file path to lines file
            string[] lines = System.IO.File.ReadAllLines(filepath);

            // loop through each line of the array of lines
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(outputFile))
            {
                // loop through each line of the array
                for (counterA = 0; counterA < lines.Length; counterA++)
                {
                    // initialize number of students who passed
                    numPassed = 0;

                    // read the first line for the next set of students
                    string line = lines[counterA];

                    // split each weight by the space delimeter
                    string[] weights = line.Split(' ');

                    // set the weights for next set of students
                    weightTests = float.Parse(weights[0]);
                    weightAssign = float.Parse(weights[1]);
                    weightProjects = float.Parse(weights[2]);
                    weightQuizzes = float.Parse(weights[3]);

                    // set num of students
                    numStudents = int.Parse(lines[counterA + 1]);

                    // loop through each student
                    for (counterB = counterA + 2; counterB < counterA + 2 + numStudents; counterB++)
                    {
                        // read next line into array
                        string[] studentMarks = lines[counterB].Split(' ');

                        // set student grades
                        markTests = float.Parse(studentMarks[0]);
                        markAssign = float.Parse(studentMarks[1]);
                        markProjects = float.Parse(studentMarks[2]);
                        markQuizzes = float.Parse(studentMarks[3]);

                        // calculate the average for the student
                        average = (markTests * (weightTests / 100)) + (markAssign * (weightAssign / 100)) + (markProjects * (weightProjects / 100)) + (markQuizzes * (weightQuizzes / 100));

                        // if they passed increase counter
                        if (average >= 50)
                        {
                            numPassed++;
                        }
                    }

                    // reset the initial counter to start at the next batch of students
                    counterA = counterB - 1;

                    // output the numPassed
                    file.WriteLine(numPassed);
                }
            }
        }
    }
}
