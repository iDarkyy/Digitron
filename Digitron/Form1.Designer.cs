using System.Windows.Forms;

namespace Digitron
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.result = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.clear = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.@equals = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.decimalPoint = new System.Windows.Forms.Button();
            this.openingBracket = new System.Windows.Forms.Button();
            this.closingBracket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.result.Location = new System.Drawing.Point(3, 1);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(286, 78);
            this.result.TabIndex = 12;
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(123, 457);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(100, 23);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.clear.ForeColor = System.Drawing.Color.MidnightBlue;
            this.clear.Location = new System.Drawing.Point(3, 82);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(70, 70);
            this.clear.TabIndex = 15;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.ClickClear);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.back.ForeColor = System.Drawing.Color.MidnightBlue;
            this.back.Location = new System.Drawing.Point(75, 82);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(70, 70);
            this.back.TabIndex = 17;
            this.back.Text = "◄";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.ClickBack);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.Gray;
            this.seven.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.seven.FlatAppearance.BorderSize = 0;
            this.seven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.seven.Location = new System.Drawing.Point(3, 155);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(70, 70);
            this.seven.TabIndex = 20;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.ClickSeven);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.Gray;
            this.eight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.eight.FlatAppearance.BorderSize = 0;
            this.eight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.eight.Location = new System.Drawing.Point(75, 155);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(70, 70);
            this.eight.TabIndex = 21;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.ClickEight);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.Gray;
            this.nine.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.nine.FlatAppearance.BorderSize = 0;
            this.nine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.nine.Location = new System.Drawing.Point(147, 155);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(70, 70);
            this.nine.TabIndex = 22;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.ClickNine);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.divide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.divide.FlatAppearance.BorderSize = 0;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.divide.Location = new System.Drawing.Point(219, 155);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(70, 70);
            this.divide.TabIndex = 23;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.ClickDivide);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.multiply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.multiply.FlatAppearance.BorderSize = 0;
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.multiply.Location = new System.Drawing.Point(219, 228);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(70, 70);
            this.multiply.TabIndex = 27;
            this.multiply.Text = "×";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.ClickMultiply);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.Gray;
            this.six.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.six.FlatAppearance.BorderSize = 0;
            this.six.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.six.Location = new System.Drawing.Point(147, 228);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(70, 70);
            this.six.TabIndex = 26;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.ClickSix);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.Gray;
            this.five.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.five.FlatAppearance.BorderSize = 0;
            this.five.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.five.Location = new System.Drawing.Point(75, 228);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(70, 70);
            this.five.TabIndex = 25;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.ClickFive);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.Gray;
            this.four.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.four.FlatAppearance.BorderSize = 0;
            this.four.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.four.Location = new System.Drawing.Point(3, 228);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(70, 70);
            this.four.TabIndex = 24;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.ClickFour);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.Gray;
            this.one.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.one.FlatAppearance.BorderSize = 0;
            this.one.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.one.Location = new System.Drawing.Point(3, 301);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(70, 70);
            this.one.TabIndex = 28;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.ClickOne);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.Gray;
            this.two.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.two.FlatAppearance.BorderSize = 0;
            this.two.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.two.Location = new System.Drawing.Point(75, 301);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(70, 70);
            this.two.TabIndex = 29;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.ClickTwo);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.Gray;
            this.three.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.three.FlatAppearance.BorderSize = 0;
            this.three.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.three.Location = new System.Drawing.Point(147, 301);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(70, 70);
            this.three.TabIndex = 30;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.ClickThree);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.minus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.minus.FlatAppearance.BorderSize = 0;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.minus.Location = new System.Drawing.Point(219, 301);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(70, 70);
            this.minus.TabIndex = 31;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.ClickMinus);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.plus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.plus.FlatAppearance.BorderSize = 0;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.plus.Location = new System.Drawing.Point(219, 374);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(70, 70);
            this.plus.TabIndex = 32;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.ClickPlus);
            // 
            // equals
            // 
            this.@equals.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.@equals.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.@equals.FlatAppearance.BorderSize = 0;
            this.@equals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.@equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.@equals.Location = new System.Drawing.Point(147, 374);
            this.@equals.Name = "equals";
            this.@equals.Size = new System.Drawing.Size(70, 70);
            this.@equals.TabIndex = 33;
            this.@equals.Text = "=";
            this.@equals.UseVisualStyleBackColor = false;
            this.@equals.Click += new System.EventHandler(this.ClickEquals);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.Gray;
            this.zero.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.zero.FlatAppearance.BorderSize = 0;
            this.zero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.zero.Location = new System.Drawing.Point(75, 374);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(70, 70);
            this.zero.TabIndex = 34;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.ClickZero);
            // 
            // decimalPoint
            // 
            this.decimalPoint.BackColor = System.Drawing.Color.DimGray;
            this.decimalPoint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.decimalPoint.FlatAppearance.BorderSize = 0;
            this.decimalPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.decimalPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.decimalPoint.Location = new System.Drawing.Point(3, 374);
            this.decimalPoint.Name = "decimalPoint";
            this.decimalPoint.Size = new System.Drawing.Size(70, 70);
            this.decimalPoint.TabIndex = 35;
            this.decimalPoint.Text = ".";
            this.decimalPoint.UseVisualStyleBackColor = false;
            this.decimalPoint.Click += new System.EventHandler(this.ClickDecimalPoint);
            // 
            // openingBracket
            // 
            this.openingBracket.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.openingBracket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.openingBracket.FlatAppearance.BorderSize = 0;
            this.openingBracket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.openingBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.openingBracket.Location = new System.Drawing.Point(147, 82);
            this.openingBracket.Name = "openingBracket";
            this.openingBracket.Size = new System.Drawing.Size(70, 70);
            this.openingBracket.TabIndex = 36;
            this.openingBracket.Text = "(";
            this.openingBracket.UseVisualStyleBackColor = false;
            this.openingBracket.Click += new System.EventHandler(this.ClickOpeningBracket);
            // 
            // closingBracket
            // 
            this.closingBracket.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.closingBracket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.closingBracket.FlatAppearance.BorderSize = 0;
            this.closingBracket.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closingBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.closingBracket.Location = new System.Drawing.Point(219, 82);
            this.closingBracket.Name = "closingBracket";
            this.closingBracket.Size = new System.Drawing.Size(70, 70);
            this.closingBracket.TabIndex = 37;
            this.closingBracket.Text = ")";
            this.closingBracket.UseVisualStyleBackColor = false;
            this.closingBracket.Click += new System.EventHandler(this.ClickClosingBracket);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(292, 450);
            this.Controls.Add(this.closingBracket);
            this.Controls.Add(this.openingBracket);
            this.Controls.Add(this.decimalPoint);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.@equals);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.back);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.Text = "Digitron";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button closingBracket;

        private System.Windows.Forms.Button openingBracket;

        private System.Windows.Forms.Button divide;

        private System.Windows.Forms.Button multiply;

        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;

        private System.Windows.Forms.Button @equals;

        private System.Windows.Forms.Button decimalPoint;

        private System.Windows.Forms.Button zero;

        private System.Windows.Forms.Button three;

        private System.Windows.Forms.Button two;

        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button one;

        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button six;

        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;

        private System.Windows.Forms.Button seven;

        private System.Windows.Forms.Button back;

        private System.Windows.Forms.Button clear;

        private System.Windows.Forms.LinkLabel linkLabel1;

        private System.Windows.Forms.Label result;

        #endregion
    }
}