namespace Project_2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startNumberTextBox = new System.Windows.Forms.TextBox();
            this.endNumberTextBox = new System.Windows.Forms.TextBox();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.absoluteValueButton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.descendingSortButton = new System.Windows.Forms.Button();
            this.fibonacciButton = new System.Windows.Forms.Button();
            this.factorialButton = new System.Windows.Forms.Button();
            this.exponentationButton = new System.Windows.Forms.Button();
            this.primeButton = new System.Windows.Forms.Button();
            this.perimeterButton = new System.Windows.Forms.Button();
            this.multiplicationButton = new System.Windows.Forms.Button();
            this.standardDeviationButton = new System.Windows.Forms.Button();
            this.rangeButton = new System.Windows.Forms.Button();
            this.pythagoreanButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.permutationButton = new System.Windows.Forms.Button();
            this.sumOfSquaresButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MathPicBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MathPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // startNumberTextBox
            // 
            this.startNumberTextBox.Location = new System.Drawing.Point(59, 67);
            this.startNumberTextBox.MaxLength = 9;
            this.startNumberTextBox.Name = "startNumberTextBox";
            this.startNumberTextBox.Size = new System.Drawing.Size(116, 23);
            this.startNumberTextBox.TabIndex = 2;
            this.startNumberTextBox.Click += new System.EventHandler(this.startNumberTextBox_Click);
            this.startNumberTextBox.TextChanged += new System.EventHandler(this.startNumberTextBox_TextChanged);
            this.startNumberTextBox.Enter += new System.EventHandler(this.startNumberTextBox_Enter);
            this.startNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.startNumberTextBox_KeyPress);
            // 
            // endNumberTextBox
            // 
            this.endNumberTextBox.Location = new System.Drawing.Point(210, 67);
            this.endNumberTextBox.MaxLength = 9;
            this.endNumberTextBox.Name = "endNumberTextBox";
            this.endNumberTextBox.Size = new System.Drawing.Size(116, 23);
            this.endNumberTextBox.TabIndex = 3;
            this.endNumberTextBox.Click += new System.EventHandler(this.endNumberTextBox_Click);
            this.endNumberTextBox.TextChanged += new System.EventHandler(this.endNumberTextBox_TextChanged);
            this.endNumberTextBox.Enter += new System.EventHandler(this.endNumberTextBox_Enter);
            this.endNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.endNumberTextBox_KeyPress);
            // 
            // resultsListBox
            // 
            this.resultsListBox.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.ItemHeight = 15;
            this.resultsListBox.Location = new System.Drawing.Point(59, 148);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(395, 169);
            this.resultsListBox.TabIndex = 5;
            // 
            // absoluteValueButton
            // 
            this.absoluteValueButton.Location = new System.Drawing.Point(59, 360);
            this.absoluteValueButton.Name = "absoluteValueButton";
            this.absoluteValueButton.Size = new System.Drawing.Size(117, 69);
            this.absoluteValueButton.TabIndex = 6;
            this.absoluteValueButton.Text = "Absolute Value";
            this.absoluteValueButton.UseVisualStyleBackColor = true;
            this.absoluteValueButton.Click += new System.EventHandler(this.absoluteValueButton_Click);
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(198, 360);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(117, 69);
            this.countButton.TabIndex = 7;
            this.countButton.Text = "Count";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // descendingSortButton
            // 
            this.descendingSortButton.Location = new System.Drawing.Point(337, 360);
            this.descendingSortButton.Name = "descendingSortButton";
            this.descendingSortButton.Size = new System.Drawing.Size(117, 69);
            this.descendingSortButton.TabIndex = 8;
            this.descendingSortButton.Text = "Descending Sort";
            this.descendingSortButton.UseVisualStyleBackColor = true;
            this.descendingSortButton.Click += new System.EventHandler(this.descendingSortButton_Click);
            // 
            // fibonacciButton
            // 
            this.fibonacciButton.Location = new System.Drawing.Point(337, 437);
            this.fibonacciButton.Name = "fibonacciButton";
            this.fibonacciButton.Size = new System.Drawing.Size(117, 69);
            this.fibonacciButton.TabIndex = 11;
            this.fibonacciButton.Text = "Fibonacci";
            this.fibonacciButton.UseVisualStyleBackColor = true;
            this.fibonacciButton.Click += new System.EventHandler(this.fibonacciButton_Click);
            // 
            // factorialButton
            // 
            this.factorialButton.Location = new System.Drawing.Point(198, 437);
            this.factorialButton.Name = "factorialButton";
            this.factorialButton.Size = new System.Drawing.Size(117, 69);
            this.factorialButton.TabIndex = 10;
            this.factorialButton.Text = "Factorial";
            this.factorialButton.UseVisualStyleBackColor = true;
            this.factorialButton.Click += new System.EventHandler(this.factorialButton_Click);
            // 
            // exponentationButton
            // 
            this.exponentationButton.Location = new System.Drawing.Point(59, 437);
            this.exponentationButton.Name = "exponentationButton";
            this.exponentationButton.Size = new System.Drawing.Size(117, 69);
            this.exponentationButton.TabIndex = 9;
            this.exponentationButton.Text = "Exponentation";
            this.exponentationButton.UseVisualStyleBackColor = true;
            this.exponentationButton.Click += new System.EventHandler(this.exponentationButton_Click);
            // 
            // primeButton
            // 
            this.primeButton.Location = new System.Drawing.Point(337, 516);
            this.primeButton.Name = "primeButton";
            this.primeButton.Size = new System.Drawing.Size(117, 69);
            this.primeButton.TabIndex = 14;
            this.primeButton.Text = "Prime";
            this.primeButton.UseVisualStyleBackColor = true;
            this.primeButton.Click += new System.EventHandler(this.primeButton_Click);
            // 
            // perimeterButton
            // 
            this.perimeterButton.Location = new System.Drawing.Point(198, 515);
            this.perimeterButton.Name = "perimeterButton";
            this.perimeterButton.Size = new System.Drawing.Size(117, 69);
            this.perimeterButton.TabIndex = 13;
            this.perimeterButton.Text = "Perimeter";
            this.perimeterButton.UseVisualStyleBackColor = true;
            this.perimeterButton.Click += new System.EventHandler(this.perimeterButton_Click);
            // 
            // multiplicationButton
            // 
            this.multiplicationButton.Location = new System.Drawing.Point(59, 515);
            this.multiplicationButton.Name = "multiplicationButton";
            this.multiplicationButton.Size = new System.Drawing.Size(117, 69);
            this.multiplicationButton.TabIndex = 12;
            this.multiplicationButton.Text = "Multiplication Table";
            this.multiplicationButton.UseVisualStyleBackColor = true;
            this.multiplicationButton.Click += new System.EventHandler(this.multiplicationButton_Click);
            // 
            // standardDeviationButton
            // 
            this.standardDeviationButton.Location = new System.Drawing.Point(337, 592);
            this.standardDeviationButton.Name = "standardDeviationButton";
            this.standardDeviationButton.Size = new System.Drawing.Size(117, 69);
            this.standardDeviationButton.TabIndex = 17;
            this.standardDeviationButton.Text = "Standard Deviation";
            this.standardDeviationButton.UseVisualStyleBackColor = true;
            this.standardDeviationButton.Click += new System.EventHandler(this.standardDeviationButton_Click);
            // 
            // rangeButton
            // 
            this.rangeButton.Location = new System.Drawing.Point(198, 592);
            this.rangeButton.Name = "rangeButton";
            this.rangeButton.Size = new System.Drawing.Size(117, 69);
            this.rangeButton.TabIndex = 16;
            this.rangeButton.Text = "Range";
            this.rangeButton.UseVisualStyleBackColor = true;
            this.rangeButton.Click += new System.EventHandler(this.rangeButton_Click);
            // 
            // pythagoreanButton
            // 
            this.pythagoreanButton.Location = new System.Drawing.Point(59, 592);
            this.pythagoreanButton.Name = "pythagoreanButton";
            this.pythagoreanButton.Size = new System.Drawing.Size(117, 69);
            this.pythagoreanButton.TabIndex = 15;
            this.pythagoreanButton.Text = "Pythagorean Theorm";
            this.pythagoreanButton.UseVisualStyleBackColor = true;
            this.pythagoreanButton.Click += new System.EventHandler(this.pythagoreanButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(337, 669);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(117, 69);
            this.exitButton.TabIndex = 20;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // permutationButton
            // 
            this.permutationButton.Location = new System.Drawing.Point(198, 669);
            this.permutationButton.Name = "permutationButton";
            this.permutationButton.Size = new System.Drawing.Size(117, 69);
            this.permutationButton.TabIndex = 19;
            this.permutationButton.Text = "Permutation Button";
            this.permutationButton.UseVisualStyleBackColor = true;
            this.permutationButton.Click += new System.EventHandler(this.permutationButton_Click);
            // 
            // sumOfSquaresButton
            // 
            this.sumOfSquaresButton.Location = new System.Drawing.Point(59, 669);
            this.sumOfSquaresButton.Name = "sumOfSquaresButton";
            this.sumOfSquaresButton.Size = new System.Drawing.Size(117, 69);
            this.sumOfSquaresButton.TabIndex = 18;
            this.sumOfSquaresButton.Text = "Sum of Squares";
            this.sumOfSquaresButton.UseVisualStyleBackColor = true;
            this.sumOfSquaresButton.Click += new System.EventHandler(this.sumOfSquaresButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "End Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Results:";
            // 
            // MathPicBox
            // 
            this.MathPicBox.Image = global::Project_2.Properties.Resources.Math_Girl_;
            this.MathPicBox.InitialImage = null;
            this.MathPicBox.Location = new System.Drawing.Point(337, 45);
            this.MathPicBox.Name = "MathPicBox";
            this.MathPicBox.Size = new System.Drawing.Size(117, 87);
            this.MathPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MathPicBox.TabIndex = 21;
            this.MathPicBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AcceptButton = this.absoluteValueButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(512, 761);
            this.Controls.Add(this.MathPicBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.permutationButton);
            this.Controls.Add(this.sumOfSquaresButton);
            this.Controls.Add(this.standardDeviationButton);
            this.Controls.Add(this.rangeButton);
            this.Controls.Add(this.pythagoreanButton);
            this.Controls.Add(this.primeButton);
            this.Controls.Add(this.perimeterButton);
            this.Controls.Add(this.multiplicationButton);
            this.Controls.Add(this.fibonacciButton);
            this.Controls.Add(this.factorialButton);
            this.Controls.Add(this.exponentationButton);
            this.Controls.Add(this.descendingSortButton);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.absoluteValueButton);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.endNumberTextBox);
            this.Controls.Add(this.startNumberTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.MathPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox startNumberTextBox;
        private System.Windows.Forms.TextBox endNumberTextBox;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.Button absoluteValueButton;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Button descendingSortButton;
        private System.Windows.Forms.Button fibonacciButton;
        private System.Windows.Forms.Button factorialButton;
        private System.Windows.Forms.Button exponentationButton;
        private System.Windows.Forms.Button primeButton;
        private System.Windows.Forms.Button perimeterButton;
        private System.Windows.Forms.Button multiplicationButton;
        private System.Windows.Forms.Button standardDeviationButton;
        private System.Windows.Forms.Button rangeButton;
        private System.Windows.Forms.Button pythagoreanButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button permutationButton;
        private System.Windows.Forms.Button sumOfSquaresButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox MathPicBox;
    }
}

