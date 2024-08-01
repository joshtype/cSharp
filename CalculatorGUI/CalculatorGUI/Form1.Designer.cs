namespace CalculatorGUI
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
            btn_n1 = new Button();
            btn_n2 = new Button();
            btn_n3 = new Button();
            btn_n4 = new Button();
            btn_n5 = new Button();
            btn_n6 = new Button();
            btn_n7 = new Button();
            btn_n8 = new Button();
            btn_n9 = new Button();
            btn_add = new Button();
            btn_subtract = new Button();
            btn_multiply = new Button();
            btn_divide = new Button();
            btn_clear = new Button();
            btn_equal = new Button();
            tbox1 = new TextBox();
            btn_n0 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbox_fibo = new TextBox();
            label5 = new Label();
            label6 = new Label();
            tbox_fiboResult = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // btn_n1
            // 
            btn_n1.Location = new Point(25, 180);
            btn_n1.Name = "btn_n1";
            btn_n1.Size = new Size(94, 29);
            btn_n1.TabIndex = 0;
            btn_n1.Text = "1";
            btn_n1.UseVisualStyleBackColor = true;
            btn_n1.Click += btn_n1_Click;
            // 
            // btn_n2
            // 
            btn_n2.Location = new Point(125, 180);
            btn_n2.Name = "btn_n2";
            btn_n2.Size = new Size(94, 29);
            btn_n2.TabIndex = 1;
            btn_n2.Text = "2";
            btn_n2.UseVisualStyleBackColor = true;
            btn_n2.Click += btn_n2_Click;
            // 
            // btn_n3
            // 
            btn_n3.Location = new Point(225, 180);
            btn_n3.Name = "btn_n3";
            btn_n3.Size = new Size(94, 29);
            btn_n3.TabIndex = 2;
            btn_n3.Text = "3";
            btn_n3.UseVisualStyleBackColor = true;
            btn_n3.Click += btn_n3_Click;
            // 
            // btn_n4
            // 
            btn_n4.Location = new Point(25, 215);
            btn_n4.Name = "btn_n4";
            btn_n4.Size = new Size(94, 29);
            btn_n4.TabIndex = 3;
            btn_n4.Text = "4";
            btn_n4.UseVisualStyleBackColor = true;
            btn_n4.Click += btn_n4_Click;
            // 
            // btn_n5
            // 
            btn_n5.Location = new Point(125, 215);
            btn_n5.Name = "btn_n5";
            btn_n5.Size = new Size(94, 29);
            btn_n5.TabIndex = 4;
            btn_n5.Text = "5";
            btn_n5.UseVisualStyleBackColor = true;
            btn_n5.Click += btn_n5_Click;
            // 
            // btn_n6
            // 
            btn_n6.Location = new Point(225, 215);
            btn_n6.Name = "btn_n6";
            btn_n6.Size = new Size(94, 29);
            btn_n6.TabIndex = 5;
            btn_n6.Text = "6";
            btn_n6.UseVisualStyleBackColor = true;
            btn_n6.Click += btn_n6_Click;
            // 
            // btn_n7
            // 
            btn_n7.Location = new Point(25, 250);
            btn_n7.Name = "btn_n7";
            btn_n7.Size = new Size(94, 29);
            btn_n7.TabIndex = 6;
            btn_n7.Text = "7";
            btn_n7.UseVisualStyleBackColor = true;
            btn_n7.Click += btn_n7_Click;
            // 
            // btn_n8
            // 
            btn_n8.Location = new Point(125, 250);
            btn_n8.Name = "btn_n8";
            btn_n8.Size = new Size(94, 29);
            btn_n8.TabIndex = 7;
            btn_n8.Text = "8";
            btn_n8.UseVisualStyleBackColor = true;
            btn_n8.Click += btn_n8_Click;
            // 
            // btn_n9
            // 
            btn_n9.Location = new Point(225, 250);
            btn_n9.Name = "btn_n9";
            btn_n9.Size = new Size(94, 29);
            btn_n9.TabIndex = 8;
            btn_n9.Text = "9";
            btn_n9.UseVisualStyleBackColor = true;
            btn_n9.Click += btn_n9_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(25, 285);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(70, 62);
            btn_add.TabIndex = 9;
            btn_add.Text = "+";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_subtract
            // 
            btn_subtract.Location = new Point(101, 285);
            btn_subtract.Name = "btn_subtract";
            btn_subtract.Size = new Size(70, 62);
            btn_subtract.TabIndex = 10;
            btn_subtract.Text = "-";
            btn_subtract.UseVisualStyleBackColor = true;
            btn_subtract.Click += btn_subtract_Click;
            // 
            // btn_multiply
            // 
            btn_multiply.Location = new Point(254, 285);
            btn_multiply.Name = "btn_multiply";
            btn_multiply.Size = new Size(65, 62);
            btn_multiply.TabIndex = 11;
            btn_multiply.Text = "x";
            btn_multiply.UseVisualStyleBackColor = true;
            btn_multiply.Click += btn_multiply_Click;
            // 
            // btn_divide
            // 
            btn_divide.Location = new Point(180, 285);
            btn_divide.Name = "btn_divide";
            btn_divide.Size = new Size(65, 62);
            btn_divide.TabIndex = 12;
            btn_divide.Text = "/";
            btn_divide.UseVisualStyleBackColor = true;
            btn_divide.Click += btn_divide_Click;
            // 
            // btn_clear
            // 
            btn_clear.Font = new Font("Segoe UI", 20F);
            btn_clear.Location = new Point(25, 119);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(94, 55);
            btn_clear.TabIndex = 16;
            btn_clear.Text = "C";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_equal
            // 
            btn_equal.Font = new Font("Segoe UI", 20F);
            btn_equal.Location = new Point(125, 119);
            btn_equal.Name = "btn_equal";
            btn_equal.Size = new Size(94, 55);
            btn_equal.TabIndex = 17;
            btn_equal.Text = "=";
            btn_equal.UseVisualStyleBackColor = true;
            btn_equal.Click += button18_Click;
            // 
            // tbox1
            // 
            tbox1.Font = new Font("Segoe UI", 15F);
            tbox1.Location = new Point(25, 52);
            tbox1.Name = "tbox1";
            tbox1.Size = new Size(294, 41);
            tbox1.TabIndex = 18;
            // 
            // btn_n0
            // 
            btn_n0.Font = new Font("Segoe UI", 20F);
            btn_n0.Location = new Point(225, 119);
            btn_n0.Name = "btn_n0";
            btn_n0.Size = new Size(94, 55);
            btn_n0.TabIndex = 19;
            btn_n0.Text = "0";
            btn_n0.UseVisualStyleBackColor = true;
            btn_n0.Click += btn_n0_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 9);
            label1.Name = "label1";
            label1.Size = new Size(193, 20);
            label1.TabIndex = 20;
            label1.Text = "Calculator by Josh Gregory";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 368);
            label2.Name = "label2";
            label2.Size = new Size(305, 20);
            label2.TabIndex = 21;
            label2.Text = "Fibonacci Sequence up to n (enter integer n):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 446);
            label3.Name = "label3";
            label3.Size = new Size(180, 20);
            label3.TabIndex = 22;
            label3.Text = "% modulo (enter x then y)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 530);
            label4.Name = "label4";
            label4.Size = new Size(140, 20);
            label4.TabIndex = 23;
            label4.Text = "n! factorial (enter n)";
            // 
            // tbox_fibo
            // 
            tbox_fibo.Location = new Point(64, 403);
            tbox_fibo.Name = "tbox_fibo";
            tbox_fibo.Size = new Size(55, 27);
            tbox_fibo.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 406);
            label5.Name = "label5";
            label5.Size = new Size(25, 20);
            label5.TabIndex = 25;
            label5.Text = "F (";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(125, 406);
            label6.Name = "label6";
            label6.Size = new Size(28, 20);
            label6.TabIndex = 26;
            label6.Text = ") =";
            // 
            // tbox_fiboResult
            // 
            tbox_fiboResult.Location = new Point(159, 403);
            tbox_fiboResult.Name = "tbox_fiboResult";
            tbox_fiboResult.Size = new Size(148, 27);
            tbox_fiboResult.TabIndex = 27;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 480);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(61, 27);
            textBox1.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(98, 483);
            label7.Name = "label7";
            label7.Size = new Size(21, 20);
            label7.TabIndex = 29;
            label7.Text = "%";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 480);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(61, 27);
            textBox2.TabIndex = 30;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(192, 480);
            label8.Name = "label8";
            label8.Size = new Size(19, 20);
            label8.TabIndex = 31;
            label8.Text = "=";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(346, 609);
            Controls.Add(label8);
            Controls.Add(textBox2);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(tbox_fiboResult);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tbox_fibo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_n0);
            Controls.Add(tbox1);
            Controls.Add(btn_equal);
            Controls.Add(btn_clear);
            Controls.Add(btn_divide);
            Controls.Add(btn_multiply);
            Controls.Add(btn_subtract);
            Controls.Add(btn_add);
            Controls.Add(btn_n9);
            Controls.Add(btn_n8);
            Controls.Add(btn_n7);
            Controls.Add(btn_n6);
            Controls.Add(btn_n5);
            Controls.Add(btn_n4);
            Controls.Add(btn_n3);
            Controls.Add(btn_n2);
            Controls.Add(btn_n1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_n1;
        private Button btn_n2;
        private Button btn_n3;
        private Button btn_n4;
        private Button btn_n5;
        private Button btn_n6;
        private Button btn_n7;
        private Button btn_n8;
        private Button btn_n9;
        private Button btn_add;
        private Button btn_subtract;
        private Button btn_multiply;
        private Button btn_divide;
        private Button btn_clear;
        private Button btn_equal;
        private TextBox tbox1;
        private Button btn_n0;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbox_fibo;
        private Label label5;
        private Label label6;
        private TextBox tbox_fiboResult;
        private TextBox textBox1;
        private Label label7;
        private TextBox textBox2;
        private Label label8;
    }
}
