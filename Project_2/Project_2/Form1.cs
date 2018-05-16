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
        string formatcode = "{0,23}{1,5}{2,3}{3,5}";
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
            int endNumberNew, count;

            GetData();

            endNumberNew = endNumber + 1;
            count = endNumberNew - startNumber;

            string format = "{0,25}{1,2}{2,4}{3,2}{4,1}{5,3}";
            resultsListBox.Items.Add(string.Format(format, "Count of values between", startNumber.ToString(), " and ", endNumber.ToString(),
                ": ", count.ToString()));

        }

        private void descendingSortButton_Click(object sender, EventArgs e)
        {
            GetData();

            int x;
            string formatDescending = "{0,25}{1,4}{2,4}{3,4}{4,1}";
            resultsListBox.Items.Add(string.Format(formatDescending, "Descending values between", startNumber.ToString(), "and ", endNumber.ToString(), ":"));
            for (x = endNumber; x >= startNumber; x--)
            {
                resultsListBox.Items.Add(x.ToString());
            }
        }

        private void exponentationButton_Click(object sender, EventArgs e)
        {
            GetData();
            double exponentation;

            exponentation = Math.Pow(startNumber, endNumber);
            string formatExponentation = "{0,3}{1,24}{2,3}{3,2}{4,4}";
            resultsListBox.Items.Add(string.Format(formatExponentation, startNumber.ToString(), "raised to the power of", endNumber.ToString(), ":", exponentation.ToString()));
        }

        private void factorialButton_Click(object sender, EventArgs e)
        {
            GetData();
            string formatFactorial = "{0,1}{1,1}{2,2}{3,9}";
            int results = startNumber;

            for (int i = 1; i < startNumber; i++)
            {
                results = results * i;
            }
            resultsListBox.Items.Add(string.Format(formatFactorial, startNumber.ToString(), "!", "= ", results.ToString()));
        }

        private void fibonacciButton_Click(object sender, EventArgs e)
        {
            GetData();
            int[] fibonacci = new int[2];
            fibonacci[0] = 0;
            fibonacci[1] = 1;
            if (startNumber < 0)
            {
                MessageBox.Show("The start number cannot be less than 0.", "Error Message",
                   MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                if (startNumber == 1)
                {
                    resultsListBox.Items.Add(fibonacci[0]);
                    resultsListBox.Items.Add(fibonacci[1]);
                }

                int fibMin2 = 0;
                int fibMin1 = 1;
                int fib = 1;
                resultsListBox.Items.Add(fib);

                while (fib <= startNumber)
                {
                    fibMin2 = fibMin1;
                    fibMin1 = fib;
                    fib = fibMin2 + fibMin1;
                    if (fib <= startNumber)
                    {
                        resultsListBox.Items.Add(fib);
                    }
                }
            }
        }

            

        private void multiplicationButton_Click(object sender, EventArgs e)
        {
            GetData();
            int result;
            string formatMulti = "{0,2}{1,1}{2,2}{3,1}{4,3}";
            for (int counter = 1; counter <= 12; counter++)
            {
                result = startNumber * counter;
                resultsListBox.Items.Add(string.Format(formatMulti, counter, "*", startNumber, "=", result));

            }

        }

        private void perimeterButton_Click(object sender, EventArgs e)
        {
            GetData();

            if (startNumber > endNumber)
            {
                MessageBox.Show("The start number is larger than end number.", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }

            int Perimeter;
            string formatPerimeter = "{0,30}{1,2}{2,1}{3,2}{4,1}{5,3}{6,3}";
            Perimeter = startNumber * 2 + endNumber * 2;

            resultsListBox.Items.Add(string.Format(formatPerimeter, "Rectangle perimeter: Width =", startNumber, ";", "length =",
                endNumber, ":", Perimeter));



        }

        private void primeButton_Click(object sender, EventArgs e)
        {
            GetData();
            int counter;
            string formatPrime = "{0,3}{1,12}";

            if (startNumber > endNumber)
            {
                MessageBox.Show("The start number cannot be greater than the end number", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            if ((startNumber == 0))
            {
                MessageBox.Show("0 is an invalid input", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

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


        private void pythagoreanButton_Click(object sender, EventArgs e)
        {
            GetData();

            if ((startNumber == 0) || (endNumber == 0))
            {
                MessageBox.Show("The start or end number cannot be zero", "Error Message",
                  MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            var a = "a\xb2";
            var b = "b\xb2";
            var c = "c\xb2";
            

            int squareA, squareB;
            double abTotal, result;

            string format1 = "{0,3}{1,3}{2,3}{3,3}{4,3}";
            resultsListBox.Items.Add(string.Format(format1,a, " + ", b,  " = ", c));

            squareA = startNumber * startNumber;
            squareB = endNumber * endNumber;

            resultsListBox.Items.Add(string.Format(format1, squareA, " + ", squareB, " = ", c));

            abTotal = squareA + squareB;

            resultsListBox.Items.Add(string.Format(format1, abTotal.ToString("N2"), " = ", c, " ", " "));

            result = Math.Sqrt(abTotal);

            resultsListBox.Items.Add(result.ToString("N2") +  " = c");

        }

        private void standardDeviationButton_Click(object sender, EventArgs e)
        {
            GetData();

            int begin, end;
            if(startNumber > endNumber)
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
            double average = (begin + end) / 2;
            double error;
            double errorTotal = 0;

            for(int counter = begin; counter <= end; counter++)
            {
                error = counter - average;
                errorTotal = errorTotal + Math.Pow(error, 2);
            }

            double MSE = errorTotal / n;
            double std = Math.Sqrt(MSE);

            string formatStd = "{0,25}{1,3}{2,3}{3,2}{4,1}{5,5}";

            resultsListBox.Items.Add(string.Format(formatStd,"Standard deviation for range ", begin, " to ", end, ":", std.ToString("N2")));

            
        }

        private void rangeButton_Click(object sender, EventArgs e)
        {
            GetData();


        }

        private void sumOfSquaresButton_Click(object sender, EventArgs e)
        {
            GetData();


        }

        private void permutationButton_Click(object sender, EventArgs e)
        {
            GetData();
            string formatFactorial = "{0,1}{1,1}{2,2}{3,9}";
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
                resultsListBox.Items.Add(top);
                for (int i = 1; i < startNumber-endNumber; i++)
                {
                    bottom = bottom * i;
                }
                resultsListBox.Items.Add(bottom);
                result = top / bottom;

                

            resultsListBox.Items.Add(string.Format("Permutation P(startNumber, endNumber) = " + result + "."));
            }
        }

            private void absoluteValueButton_Click(object sender, EventArgs e)
        {
            int startNumberNew, endNumberNew;

            GetData();

            startNumberNew = Math.Abs(startNumber);
            endNumberNew = Math.Abs(endNumber);

            resultsListBox.Items.Add(string.Format(formatcode, "The absolute value of ", startNumber.ToString(), ": ", startNumberNew.ToString()));
            resultsListBox.Items.Add(string.Format(formatcode, "The absolute value of ", endNumber.ToString(), ": ", endNumberNew.ToString()));
        }
    }
}
