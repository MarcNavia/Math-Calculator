//App Developer: Marc Navia 3/27/2018
//Application Name: Calculator
//App Purpose: A math calculator that performs many different types of arithmatic equations
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class MainForm : Form
    {
        //Declaring global variables that will be constantly used throughout the application
        int startNumber, endNumber;

        public MainForm()
        {
            InitializeComponent();
        }

        private void GetData()
        {
            //This method parses the input that the user keys in, into two seperate variables
            int.TryParse(startNumberTextBox.Text, out startNumber);
            int.TryParse(endNumberTextBox.Text, out endNumber);
          
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            //Clears the listbox
            resultsListBox.Items.Clear();

            //Checks if the textboxes are empty. If they are empty it throws a error to the user
            if (startNumberTextBox.Text == "" || endNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
                
                //Puts the focus back to the start number text box
                startNumberTextBox.Focus();
                    
            }
            else
            {
                //Declaring interger variables that will be used for the count calculation
                int endNumberNew, count, start, end;

                //Retrieves the data from the textboxes
                GetData();

                // If the start number is greater than the endnumber, it flips the variable
                if (startNumber > endNumber)
                {
                    start = endNumber;
                    end = startNumber;
                }
                else
                {
                    start = startNumber;
                    end = endNumber;
                }
                //Adds one to the end variable to be used for the count calculation
                endNumberNew = end + 1;

                //subtracts the adjusted end number and start number
                count = endNumberNew - start;

                //outputs the count into the result listbox
                resultsListBox.Items.Add("Count of values between " + start + " and " + end +
                    ": " + count);

                //Sets the focus back to the start number textbox
                startNumberTextBox.Focus();
                startNumberTextBox.SelectAll();
            }
        }

        private void descendingSortButton_Click(object sender, EventArgs e)
        {
            //Clears the listbox
            resultsListBox.Items.Clear();

            //Checks if the textboxes are empty. If they are empty it throws a error to the user
            if (startNumberTextBox.Text == "" || endNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //Retrieves the data from the textboxes
                GetData();

                //delcaring new variables that will be used in the calculation
                int x, start, end;

                // If the start number is greater than the endnumber, it flips the variable
                if (startNumber > endNumber)
                {
                    start = endNumber;
                    end = startNumber;
                }
                else
                {
                    start = startNumber;
                    end = endNumber;
                }
                //Displays what two values that will be descended
                resultsListBox.Items.Add("Descending values between " + start + " and " + end + ":");

                //A for loop that display the value going from the end value down to the start value
                for (x = end; x >= start; x--)
                {
                    resultsListBox.Items.Add(x.ToString());
                }
                //Sets focus on the start number textbox
                startNumberTextBox.Focus();
            }
        }

        private void exponentationButton_Click(object sender, EventArgs e)
        {
            //Clears the listbox
            resultsListBox.Items.Clear();
           
            //Checks if the textboxes are empty. If they are empty it throws a error to the user
            if (startNumberTextBox.Text == "" || endNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //Retrieves the data from the textboxes
                GetData();

                //declareing a new variable to be used in the calculation
                double exponentation;

                //sets the start number value to the power of the end number value
                exponentation = Math.Pow(startNumber, endNumber);
                resultsListBox.Items.Add(startNumber + " raised to the power of " + endNumber + ": " + exponentation.ToString("N0"));

                //sets focus on the start number textbox
                startNumberTextBox.Focus();
            }
        }

        private void factorialButton_Click(object sender, EventArgs e)
        {
            //Clears the listbox
            resultsListBox.Items.Clear();
           
            //Checks if the textboxes are empty. If they are empty it throws a error to the user
            if (startNumberTextBox.Text == "")
            {
                MessageBox.Show("Please enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //Retrieves the data from the textboxes
                GetData();
                int results = startNumber;
                if ((startNumber < 0) || (startNumber > 10))
                {
                    MessageBox.Show("The start number cannot be less than 0 or greater than 10.", "Error Message",
                       MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    //This for loop products all values that are less than or equal to the startnumber
                    for (int i = 1; i < startNumber; i++)
                    {
                        //accumulates the total product
                        results = results * i;
                    }
                    //displays the results to the listbox
                    resultsListBox.Items.Add(startNumber + "!" + "= " + results);

                    //sets the focus to the start number textbox
                    startNumberTextBox.Focus();
                }

            }
        }

        private void fibonacciButton_Click(object sender, EventArgs e)
        {
            //Clears the listbox
            resultsListBox.Items.Clear();
            
            //Retrieves the data from the textboxes
            GetData();
            
            //Checks if the textboxes are empty. If they are empty it throws a error to the user
            if (startNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //Checks if the inputed values are between 0 and 30. If not  itthrows a error
                if ((startNumber <= 0) || (startNumber > 30))
                {
                    MessageBox.Show("Starting number cannot be less than or equal to zero or greater than 30", "Error Message",
                                       MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {

                }
                //Declaring the array that will be used
                int[] fibonacci = new int[30];

                //Setting the value of the first two index
                fibonacci[0] = 0;
                fibonacci[1] = 1;

                //Adds the two numbers before [i] index
                for (int i = 2; i < startNumber; i++)
                {
                    //Index i is equal to the two previous index addded together
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
                
                //Display what number that will be sequence
                resultsListBox.Items.Add("Fibonacci sequence for " + startNumber);

                // display every value in the array from 0 to startnumber
               for(int i = 0; i < startNumber; i++)
                {
                    resultsListBox.Items.Add(fibonacci[i]);
                }

               // sets focus on the start number textbox
                startNumberTextBox.Focus();
            }
        }



        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            //Clears the listbox
            resultsListBox.Items.Clear();
            
            //Checks if the textboxes are empty. If they are empty it throws a error to the user
            if (startNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //Retrieves the data from the textboxes
                GetData();

                //creating a new integer variable called result
                int result;

                //Checks is the start number is in the range of 1-12. if not it throws an error
                if ((startNumber <= 0) || (startNumber > 12))
                {
                    MessageBox.Show("The start number can only be in the range of 1-12.", "Error Message",
                     MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    // mutiplies the startnumber from 1 to 12 and outputs into the listbox
                    for (int counter = 1; counter <= 12; counter++)
                    {
                        result = startNumber * counter;
                        resultsListBox.Items.Add(counter + "*" + startNumber + "=" + result);

                    }
                }
                //Sets focus on the textbox
                startNumberTextBox.Focus();

            }
        }

        private void perimeterButton_Click(object sender, EventArgs e)
        {
            //Clears the listbox
            resultsListBox.Items.Clear();
            
            //Checks if the textboxes are empty. If they are empty it throws a error to the user
            if (startNumberTextBox.Text == "" || endNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
                startNumberTextBox.Focus();

            }
            else
            {
                //Retrieves the data from the textboxes
                GetData();
                if ((startNumber <= 0) || (endNumber <= 0))
                {
                    MessageBox.Show("Start number and end number cannot be zero.", "Error Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    startNumberTextBox.Focus();

                }
                else
                {
                    //If the the start number is greater than the end number, send a error message
                    if (startNumber > endNumber)
                    {
                        MessageBox.Show("The start number is larger than end number.", "Error Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        startNumberTextBox.Focus();

                    }
                    else
                    {
                        //Declare new integer variable perimeter
                        int Perimeter;

                        //Calculates the perimeter
                        Perimeter = startNumber * 2 + endNumber * 2;

                        //Outs the perimeter value to the listbox
                        resultsListBox.Items.Add("Rectangle perimeter: Width = " + startNumber + ":" + " length = " +
                            endNumber + ": " + Perimeter);
                        startNumberTextBox.Focus();
                    }
                }


            }
        }

        private void primeButton_Click(object sender, EventArgs e)
        {
            //Clears the listbox
            resultsListBox.Items.Clear();
            
            //Checks if the textboxes are empty. If they are empty it throws a error to the user
            if (startNumberTextBox.Text == "" || endNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //Retrieves the data from the textboxes
                GetData();

                //Declaring the counter
                int counter;

                //If the start number is greater than endnumber, send a error message
                if (startNumber > endNumber)
                {
                    MessageBox.Show("The start number cannot be greater than the end number", "Error Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                //If the start number is less than or equal to 0, send a error message
                if ((startNumber <= 0))
                {
                    MessageBox.Show("Cannot input anything less than or equal to zero", "Error Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    //This for loop goes through every value between the start number and end number
                    for (counter = startNumber; counter <= endNumber; counter++)
                    {
                        //Declaring a boolean. This is used for prime checking
                        bool isPrime = true;
                        
                        // This for loop test ever value from start number to 2. If a remainder is found
                        // it will set the boolean to false
                        for (int j = 2; j < counter; j++)
                        {
                            if (isPrime == false)
                            {
                                break;
                            }
                            else if ((counter % j) == 0)
                            {
                                isPrime = false;
                            }
                        }
                        //If the counter variable goes through the second loop without the boolean turn off, output counter as prime
                        if (isPrime == true)
                        {
                            resultsListBox.Items.Add("Number " + counter + " is a prime!");
                            startNumberTextBox.Focus();
                        }
                        else
                        //If the counter variable goes through the second loop with the boolean turn off, output counter as not prime

                        {
                            resultsListBox.Items.Add("Number " + counter + " is not a prime!");
                            startNumberTextBox.Focus();
                        }
                    }
                }
            }
        }


        private void pythagoreanButton_Click(object sender, EventArgs e)
        {
            //Clears the listbox
            resultsListBox.Items.Clear();
            
            //Checks if the textboxes are empty. If they are empty it throws a error to the user
            if (startNumberTextBox.Text == "" || endNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //Retrieves the data from the textboxes
                GetData();

                //Checks if the inputed values are less than or equal to zero. If true send a error message
                if ((startNumber <= 0) || (endNumber <= 0))
                {
                    MessageBox.Show("The start or end number cannot be less than or equal to zero", "Error Message",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    //Creating unicodes
                    var a = "a\xb2";
                    var b = "b\xb2";
                    var c = "c\xb2";

                    //Declare new variables to be used for the caluclation
                    int squareA, squareB;
                    double abTotal, result;

                    //outputs the formula into the listbox
                    resultsListBox.Items.Add(a + " + " + b + " = " + c);

                    //Squaring the input
                    squareA = startNumber * startNumber;
                    squareB = endNumber * endNumber;

                    //outputs the squaring intot the listbox
                    resultsListBox.Items.Add(squareA + " + " + squareB + " = " + c);

                    //Adding the squared values
                    abTotal = squareA + squareB;

                    //outputting the total squared values
                    resultsListBox.Items.Add(abTotal + " = " + c + " " + " ");

                    //Square rooting the total square values
                    result = Math.Sqrt(abTotal);

                    //Displaying the final anwser
                    resultsListBox.Items.Add(result.ToString("N2") + " = c");
                    startNumberTextBox.Focus();
                }

            }
        }

        private void standardDeviationButton_Click(object sender, EventArgs e)
        {
            //Clears the listbox
            resultsListBox.Items.Clear();
            
            //Checks if the textboxes are empty. If they are empty it throws a error to the user
            if (startNumberTextBox.Text == "" || endNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //Retrieves the data from the textboxes
                GetData();

                //Declaring two new variables
                int begin, end;

                //checks if both the start number and the end number are zero
                if ((startNumber == 0) && (endNumber == 0))
                {
                    MessageBox.Show("Both start number and end number cannot be zero", "Error Message",
                                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    // If the start number is greater than the endnumber, it flips the variable
                    if (startNumber > endNumber)
                    {
                        begin = endNumber;
                        end = startNumber;

                    }
                    else
                    {
                        begin = startNumber;
                        end = endNumber;
                    }
                    // Sample size minus 1
                    int n = end - begin;

                    //Finding the average of the range of values. Set 2.0 as a float so the average doesnt round to a whole number
                    double average = (begin + end) / (float)2.0; 

                    //Declaring new variables for the for loop
                    double error;
                    double errorTotal = 0;

                    //Calculates the error for each sample and totals it up.
                    for (int counter = begin; counter <= end; counter++)
                    {
                        error = counter - (double)average;
                        errorTotal = errorTotal + Math.Pow(error, 2);
                    }
                    //Finds the mean square error
                    double MSE = errorTotal / n;

                    //square roots the MSE to find the std
                    double std = Math.Sqrt(MSE);

                    //Displays it into the listbox
                    resultsListBox.Items.Add("Standard deviation for range " + begin + " to " + end + ": " + std.ToString());

                    startNumberTextBox.Focus();
                }
            }
        }

        private void rangeButton_Click(object sender, EventArgs e)
        {
            //Clears the listbox
            resultsListBox.Items.Clear();
            
            //Checks if the textboxes are empty. If they are empty it throws a error to the user
            if (startNumberTextBox.Text == "" || endNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
                startNumberTextBox.Focus();
            }
            else
            {
                //Retrieves the data from the textboxes
                GetData();

                //Subtracts the end number and start number. if it is negative the absolute method makes it positive
                int range = Math.Abs(endNumber - startNumber);

                //displats the result
                resultsListBox.Items.Add("The range of value between " + startNumber + " and " + endNumber + ": " + range);
                startNumberTextBox.Focus();

            }
        }

        private void sumOfSquaresButton_Click(object sender, EventArgs e)
        {
            //Clears the listbox
            resultsListBox.Items.Clear();
           
            //Checks if the textboxes are empty. If they are empty it throws a error to the user
            if (startNumberTextBox.Text == "" || endNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
                startNumberTextBox.Focus();
            }
            else
            {
                //Retrieves the data from the textboxes
                GetData();
                
                //Declaring new variables to be used in the for loop
                double sumOfSquare, sumOfSquareTotal = 0, counterTotal = 0;

                //Check if the values are equal to zero. If true then send a error message
                if ((startNumber == 0) || (endNumber == 0))
                {
                    MessageBox.Show("The start or end number cannot be zero", "Error Message",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    startNumberTextBox.Focus();
                }
                else
                {
                    //Check if the start number is greater than the end number. If true then send a error message

                    if (startNumber > endNumber)
                    {
                        MessageBox.Show("The starting number cannot be greater than the end number.", "Error Message",
                          MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        startNumberTextBox.Focus();
                    }
                    //finds the square value of each variable in the inputed range. Also totals the square values and range value
                    for (int counter = startNumber; counter <= endNumber; counter++)
                    {
                        sumOfSquare = Math.Pow(counter, 2);
                        resultsListBox.Items.Add("The number is: " + counter + " and its square is " + sumOfSquare);
                        sumOfSquareTotal += sumOfSquare;
                        counterTotal = counter;
                    }

                    //Displays the results into the listbox
                    resultsListBox.Items.Add("" + "" + "" + "");
                    resultsListBox.Items.Add("Sum of numbers: " + counterTotal + " Sum of squares: " + sumOfSquareTotal);
                    startNumberTextBox.Focus();

                }


            }
        }

        private void permutationButton_Click(object sender, EventArgs e)
        {
            // Finds all the possible combination from a range of values

            //Clears the listbox
            resultsListBox.Items.Clear();

            //Checks if the textboxes are empty. If they are empty it throws a error to the user
            if (startNumberTextBox.Text == "" || endNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
                startNumberTextBox.Focus();
            }
            else
            {
                //Retrieves the data from the textboxes
                GetData();
                long top = startNumber;
                long bottom = (top - endNumber);
                long result;

                //Check if the endnumber is larger than the startnumber. If true then send a error message
                if (endNumber > startNumber)
                {
                    MessageBox.Show("Error bottom can't be greater than top", "Error Message",
                       MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    startNumberTextBox.Focus();
                }
                else
                {
                    if (startNumber == 0 || endNumber == 0 )
                    {
                        MessageBox.Show("Error Values cannot be zero", "Error Message",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        startNumberTextBox.Focus();
                    }
                    else
                    {
                        //Doing the top portion of the permutation formula
                        for (int i = 1; i < startNumber; i++)
                        {
                            top = top * i;
                        }
                        //Calculates the bottom portion of the permutation formula
                        for (int i = 1; i < startNumber - endNumber; i++)
                        {
                            bottom = bottom * i;
                        }

                        result = top / bottom;

                        //displaying the result
                        resultsListBox.Items.Add(string.Format("Permutation P(startNumber, endNumber) = " + result + "."));
                        startNumberTextBox.Focus();
                    }
                    
                }
            }
        }

        private void startNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            //Clears the listbox
            resultsListBox.Items.Clear();
        }

        private void endNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            //Clears the listbox
            resultsListBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //When user click exit, give them the option to either leave or not
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", this.Text, MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
                this.Close(); 
        }

        private void startNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Disallows anything but digits, control characters, period, and negatives
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
                return;
            }
        }

        private void endNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Disallows anything but digits, control characters, period, and negatives
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.' && e.KeyChar !='-')
            {
                e.Handled = true;
                return;
            }
        }

        private void startNumberTextBox_Click(object sender, EventArgs e)
        {
            //Selects all values in the start number textbox
            startNumberTextBox.SelectAll();
        }

        private void endNumberTextBox_Click(object sender, EventArgs e)
        {
            //Selects all values in the end number textbox
            endNumberTextBox.SelectAll();

        }

        private void startNumberTextBox_Enter(object sender, EventArgs e)
        {
            //Selects all values in the start number textbox
            startNumberTextBox.SelectAll();
        }

        private void endNumberTextBox_Enter(object sender, EventArgs e)
        {
            //Selects all values in the end number textbox
            endNumberTextBox.SelectAll();
        }

        private void absoluteValueButton_Click(object sender, EventArgs e)
        {
            //Clears the listbox
            resultsListBox.Items.Clear();
            
            //Checks if the textboxes are empty. If they are empty it throws a error to the user
            if (startNumberTextBox.Text == "" || endNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
                startNumberTextBox.Focus();
            }
            else
            {
                //Declaring two new variables for the caluclation
                int startNumberNew, endNumberNew;
                
                //Retrieves the data from the textboxes
                GetData();

                //Finds the absolute value of the two inputed values
                startNumberNew = Math.Abs(startNumber);
                endNumberNew = Math.Abs(endNumber);

                //displays the results into the listbox
                resultsListBox.Items.Add("The absolute value of " + startNumber.ToString() + ": " + startNumberNew.ToString());
                resultsListBox.Items.Add("The absolute value of " + endNumber.ToString() + ": " + endNumberNew.ToString());
                startNumberTextBox.Focus();
            } }
    }
}
