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
        int startNumber, endNumber;
        public MainForm()
        {
            InitializeComponent();
        }

        private void GetData()
        {

            int.TryParse(startNumberTextBox.Text, out startNumber);
            int.TryParse(endNumberTextBox.Text, out endNumber);
          
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            resultsListBox.Items.Clear();
            if (startNumberTextBox.Text == "" || endNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                int endNumberNew, count, start, end;

                GetData();
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
                endNumberNew = end + 1;
                count = endNumberNew - start;

                resultsListBox.Items.Add("Count of values between " + start + " and " + end +
                    ": " + count);

            }
        }

        private void descendingSortButton_Click(object sender, EventArgs e)
        {
            resultsListBox.Items.Clear();
            if (startNumberTextBox.Text == "" || endNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                GetData();

                int x, start, end;
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

                resultsListBox.Items.Add("Descending values between " + start + " and" + end + ":");
                for (x = end; x >= start; x--)
                {
                    resultsListBox.Items.Add(x.ToString());
                }
            }
        }

        private void exponentationButton_Click(object sender, EventArgs e)
        {
            resultsListBox.Items.Clear();
            if (startNumberTextBox.Text == "" || endNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                GetData();
                double exponentation;

                exponentation = Math.Pow(startNumber, endNumber);
                resultsListBox.Items.Add(startNumber + " raised to the power of " + endNumber + ":" + exponentation);
            }
        }

        private void factorialButton_Click(object sender, EventArgs e)
        {
            resultsListBox.Items.Clear();
            if (startNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                GetData();
                int results = startNumber;
                if (startNumber < 0)
                {
                    MessageBox.Show("The start number cannot be less than 0.", "Error Message",
                       MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    for (int i = 1; i < startNumber; i++)
                    {
                        results = results * i;
                    }
                    resultsListBox.Items.Add(startNumber + "!" + "= " + results);
                }

            }
        }

        private void fibonacciButton_Click(object sender, EventArgs e)
        {
            resultsListBox.Items.Clear();
            GetData();
            if (startNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                int[] fibonacci = new int[30];

                fibonacci[0] = 0;
                fibonacci[1] = 1;

                for (int i = 2; i < startNumber; i++)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
                foreach (int index in fibonacci)
                {
                    resultsListBox.Items.Add(index);
                }
            }
        }



        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            resultsListBox.Items.Clear();
            if (startNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                GetData();
                int result;

                if ((startNumber <= 0) || (startNumber > 12))
                {
                    MessageBox.Show("The start number can only be in the range of 1-12.", "Error Message",
                     MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    for (int counter = 1; counter <= 12; counter++)
                    {
                        result = startNumber * counter;
                        resultsListBox.Items.Add(counter + "*" + startNumber + "=" + result);

                    }
                }

            }
        }

        private void perimeterButton_Click(object sender, EventArgs e)
        {
            resultsListBox.Items.Clear();
            if (startNumberTextBox.Text == "" || endNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                GetData();
                if ((startNumber <= 0) || (endNumber <= 0))
                {
                    MessageBox.Show("Start number and end number cannot be zero.", "Error Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if (startNumber > endNumber)
                    {
                        MessageBox.Show("The start number is larger than end number.", "Error Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    }
                    else
                    {
                        int Perimeter;
                        Perimeter = startNumber * 2 + endNumber * 2;

                        resultsListBox.Items.Add("Rectangle perimeter: Width =" + startNumber + ";" + "length =" +
                            endNumber + ":" + Perimeter);

                    }
                }

            }
        }

        private void primeButton_Click(object sender, EventArgs e)
        {
            resultsListBox.Items.Clear();
            if (startNumberTextBox.Text == "" || endNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                GetData();
                int counter;

                if (startNumber > endNumber)
                {
                    MessageBox.Show("The start number cannot be greater than the end number", "Error Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                if ((startNumber <= 0))
                {
                    MessageBox.Show("Cannot input anything less than or equal to zero", "Error Message",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    for (counter = startNumber; counter <= endNumber; counter++)
                    {
                        bool isPrime = true;
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
                        if (isPrime == true)
                        {
                            resultsListBox.Items.Add("Number " + counter + " is a prime!");
                        }
                        else
                        {
                            resultsListBox.Items.Add("Number " + counter + " is not a prime!");
                        }
                    }
                }
            }
        }


        private void pythagoreanButton_Click(object sender, EventArgs e)
        {
            resultsListBox.Items.Clear();
            if (startNumberTextBox.Text == "" || endNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                GetData();

                if ((startNumber <= 0) || (endNumber <= 0))
                {
                    MessageBox.Show("The start or end number cannot be less than or equal to zero", "Error Message",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    var a = "a\xb2";
                    var b = "b\xb2";
                    var c = "c\xb2";


                    int squareA, squareB;
                    double abTotal, result;

                    resultsListBox.Items.Add(a + " + " + b + " = " + c);

                    squareA = startNumber * startNumber;
                    squareB = endNumber * endNumber;

                    resultsListBox.Items.Add(squareA + " + " + squareB + " = " + c);

                    abTotal = squareA + squareB;

                    resultsListBox.Items.Add(abTotal + " = " + c + " " + " ");

                    result = Math.Sqrt(abTotal);

                    resultsListBox.Items.Add(result.ToString("N2") + " = c");
                }

            }
        }

        private void standardDeviationButton_Click(object sender, EventArgs e)
        {
            resultsListBox.Items.Clear();
            if (startNumberTextBox.Text == "" || endNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                GetData();

                int begin, end;
                if ((startNumber == 0) && (endNumber == 0))
                {
                    MessageBox.Show("Both start number and end number cannot be zero", "Error Message",
                                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
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

                    int n = end - begin;
                    double average = (begin + end) / (float)2.0; //Average is rounding to a whole number
                    double error;
                    double errorTotal = 0;

                    for (int counter = begin; counter <= end; counter++)
                    {
                        error = counter - (double)average;
                        errorTotal = errorTotal + Math.Pow(error, 2);
                    }

                    double MSE = errorTotal / n;
                    double std = Math.Sqrt(MSE);

                    string formatStd = "{0,25}{1,3}{2,3}{3,2}{4,1}{5,5}";

                    resultsListBox.Items.Add(string.Format(formatStd, "Standard deviation for range ", begin, " to ", end, ":", std.ToString()));
                }
            }
        }

        private void rangeButton_Click(object sender, EventArgs e)
        {
            resultsListBox.Items.Clear();
            if (startNumberTextBox.Text == "" || endNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                GetData();

                int range = Math.Abs(endNumber - startNumber);
                string formatRange = "{0,25}{1,5}{2,3}{3,5}{4,1}{5,5}";

                resultsListBox.Items.Add(string.Format(formatRange, "The range of value between", startNumber, "-", endNumber, ":", range));

            }
        }

        private void sumOfSquaresButton_Click(object sender, EventArgs e)
        {
            resultsListBox.Items.Clear();
            if (startNumberTextBox.Text == "" || endNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                GetData();
                double sumOfSquare, sumOfSquareTotal = 0, counterTotal = 0;
                string formatSum = "{0,15}{1,3}{2,15}{3,15}";

                if ((startNumber == 0) || (endNumber == 0))
                {
                    MessageBox.Show("The start or end number cannot be zero", "Error Message",
                      MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    if (startNumber > endNumber)
                    {
                        MessageBox.Show("The starting number cannot be greater than the end number.", "Error Message",
                          MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }

                    for (int counter = startNumber; counter <= endNumber; counter++)
                    {
                        sumOfSquare = Math.Pow(counter, 2);
                        resultsListBox.Items.Add(string.Format(formatSum, "The number is: ", counter, " and its square is ", sumOfSquare));
                        sumOfSquareTotal += sumOfSquare;
                        counterTotal = counter;
                    }
                    resultsListBox.Items.Add(formatSum + "" + "" + "" + "");
                    resultsListBox.Items.Add("Sum of numbers: " + counterTotal + " Sum of squares: " + sumOfSquareTotal);

                }


            }
        }

        private void permutationButton_Click(object sender, EventArgs e)
        {
            resultsListBox.Items.Clear();
            if (startNumberTextBox.Text == "" || endNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                GetData();
                long top = startNumber;
                long bottom = (top - endNumber);
                long result;

                if (endNumber > startNumber)
                {
                    MessageBox.Show("Error bottom can't be greater than top", "Error Message",
                       MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    for (int i = 1; i < startNumber; i++)
                    {
                        top = top * i;
                    }
                    for (int i = 1; i < startNumber - endNumber; i++)
                    {
                        bottom = bottom * i;
                    }
                    result = top / bottom;

                    resultsListBox.Items.Add(string.Format("Permutation P(startNumber, endNumber) = " + result + "."));
                }
            }
        }

        private void startNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            resultsListBox.Items.Clear();
        }

        private void endNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            resultsListBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", this.Text, MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
                this.Close(); 
        }

        private void absoluteValueButton_Click(object sender, EventArgs e)
        {
            resultsListBox.Items.Clear();
            if (startNumberTextBox.Text == "" || endNumberTextBox.Text == "")
            {
                MessageBox.Show("Enter a value", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                int startNumberNew, endNumberNew;

                GetData();

                startNumberNew = Math.Abs(startNumber);
                endNumberNew = Math.Abs(endNumber);

                resultsListBox.Items.Add("The absolute value of " + startNumber.ToString() + ": " + startNumberNew.ToString());
                resultsListBox.Items.Add("The absolute value of " + endNumber.ToString() + ": " + endNumberNew.ToString());
            } }
    }
}
