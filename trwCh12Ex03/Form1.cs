using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trwCh12Ex03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            // do a try catch phrase to see if a number was entered
            // if zero or greater that 7 then "try Again"
            // if not invisible this button; visble the rest; initialize the array
            
            try
            {
                string inValue;
                int numOfValues;
                numOfValues = int.Parse(inValue);
                int[] scores;
                string labelText;
                int counter
                
                labelText = "Enter Score # " + (i+1);
                label2.Text = labelText;

                }
            }
            catch
            {
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //enter in the grade
            //++ the counter
            //check if it is a number - TRY CATCH
            //check if it is a number > 0 & <101 - TRY CATCH
            //Check it is last one to enter - change button2 to Last Grade

            //calc avg & check if divide by zero error.
        }
    }
}
