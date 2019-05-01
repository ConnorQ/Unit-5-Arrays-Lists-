using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListsConnorQ
{
    public partial class frmLists : Form
    {
        public frmLists()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // declare the list
            List<int> myListOfIntegers = new List<int>();

            // declare local variable
            int userMark = -1;

            // convert the value in the text box to an integer
            try
            {
                userMark = Convert.ToInt32(txtInput.Text);
            }
            // if the user did not enter a valid number, write the error to the command line
            catch (Exception parseError)
            {
                Console.WriteLine("An error occurred: '{0}'", parseError);
            }

            // check if the user entered a number between 0 and 100
            if ( (userMark >= 0) && (userMark <= 100) )
            {
                // add the mark to the list box
                this.lstMarks.Items.Add(userMark);

                // add the mark to the list
                myListOfIntegers.Add(userMark);
            }
            // otherwise display an error
            else
            {
                MessageBox.Show("Please enter a number between 0 and 100.", "Invalid Number");
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {

        }
    }
}
