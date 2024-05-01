using System;
using System.Windows.Forms;

namespace WinFormsApp10
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numofhour = new Label();
            rate = new Label();
            number_hours = new TextBox();
            number_rate = new TextBox();
            wage = new Button();
            salary = new Button();
            slary = new TextBox();
            wge = new TextBox();
            tax = new Label();
            Tax1 = new TextBox();
            SuspendLayout();
            // 
            // numofhour
            // 
            numofhour.Location = new Point(-1, 30);
            numofhour.Margin = new Padding(2, 0, 2, 0);
            numofhour.Name = "numofhour";
            numofhour.Size = new Size(124, 23);
            numofhour.TabIndex = 0;
            numofhour.Text = "Number of Hours";
            // 
            // rate
            // 
            rate.Location = new Point(-1, 69);
            rate.Margin = new Padding(2, 0, 2, 0);
            rate.Name = "rate";
            rate.Size = new Size(110, 22);
            rate.TabIndex = 1;
            rate.Text = "Rate of Hours";
            rate.Click += rate_Click;
            // 
            // number_hours
            // 
            number_hours.Location = new Point(138, 30);
            number_hours.Margin = new Padding(2, 2, 2, 2);
            number_hours.Name = "number_hours";
            number_hours.Size = new Size(161, 27);
            number_hours.TabIndex = 2;
            // 
            // number_rate
            // 
            number_rate.Location = new Point(138, 66);
            number_rate.Margin = new Padding(2, 2, 2, 2);
            number_rate.Name = "number_rate";
            number_rate.Size = new Size(161, 27);
            number_rate.TabIndex = 3;
            number_rate.TextChanged += number_rate_TextChanged;
            // 
            // wage
            // 
            wage.BackColor = Color.SkyBlue;
            wage.Location = new Point(457, 210);
            wage.Margin = new Padding(2, 2, 2, 2);
            wage.Name = "wage";
            wage.Size = new Size(96, 48);
            wage.TabIndex = 4;
            wage.Text = "Wage";
            wage.UseVisualStyleBackColor = false;
            wage.Click += Wage_Click;
            // 
            // salary
            // 
            salary.BackColor = Color.SkyBlue;
            salary.Location = new Point(72, 210);
            salary.Margin = new Padding(2, 2, 2, 2);
            salary.Name = "salary";
            salary.Size = new Size(96, 48);
            salary.TabIndex = 5;
            salary.Text = "Salary";
            salary.UseVisualStyleBackColor = false;
            salary.Click += Salary_Click;
            // 
            // slary
            // 
            slary.Location = new Point(45, 298);
            slary.Margin = new Padding(2, 2, 2, 2);
            slary.Name = "slary";
            slary.Size = new Size(161, 27);
            slary.TabIndex = 6;
            // 
            // wge
            // 
            wge.Location = new Point(418, 298);
            wge.Margin = new Padding(2, 2, 2, 2);
            wge.Name = "wge";
            wge.Size = new Size(161, 27);
            wge.TabIndex = 7;
            // 
            // tax
            // 
            tax.Location = new Point(-1, 109);
            tax.Margin = new Padding(2, 0, 2, 0);
            tax.Name = "tax";
            tax.Size = new Size(91, 24);
            tax.TabIndex = 8;
            tax.Text = "Tax";
            tax.Click += tax_Click;
            // 
            // Tax1
            // 
            Tax1.Location = new Point(138, 109);
            Tax1.Margin = new Padding(2, 2, 2, 2);
            Tax1.Name = "Tax1";
            Tax1.Size = new Size(161, 27);
            Tax1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(numofhour);
            Controls.Add(rate);
            Controls.Add(number_hours);
            Controls.Add(number_rate);
            Controls.Add(wage);
            Controls.Add(salary);
            Controls.Add(slary);
            Controls.Add(wge);
            Controls.Add(tax);
            Controls.Add(Tax1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        Label numofhour;
        Label rate;
        TextBox number_hours;
        TextBox number_rate;
        TextBox wge;
        TextBox slary;
        Button wage;
        Button salary;
        PictureBox company;
        Label tax;
        TextBox Tax1;
        #endregion
    }
}