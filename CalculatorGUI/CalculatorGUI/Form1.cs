namespace CalculatorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void button18_Click(object sender, EventArgs e) { }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tbox1.Clear();
        }


        private void btn_n0_Click(object sender, EventArgs e)
        {
            tbox1.Text += "0";
        }
        private void btn_n1_Click(object sender, EventArgs e)
        {
            tbox1.Text += "1";
        }
        private void btn_n2_Click(object sender, EventArgs e)
        {
            tbox1.Text += "2";
        }

        private void btn_n3_Click(object sender, EventArgs e)
        {
            tbox1.Text += "3";
        }

        private void btn_n4_Click(object sender, EventArgs e)
        {
            tbox1.Text += "4";
        }

        private void btn_n5_Click(object sender, EventArgs e)
        {
            tbox1.Text += "5";
        }

        private void btn_n6_Click(object sender, EventArgs e)
        {
            tbox1.Text += "6";
        }

        private void btn_n7_Click(object sender, EventArgs e)
        {
            tbox1.Text += "7";
        }

        private void btn_n8_Click(object sender, EventArgs e)
        {
            tbox1.Text += "8";
        }

        private void btn_n9_Click(object sender, EventArgs e)
        {
            tbox1.Text += "9";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            tbox1.Text = "+";
        }

        private void btn_subtract_Click(object sender, EventArgs e)
        {
            tbox1.Text += "-";
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            tbox1.Text += "/";
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            tbox1.Text += "*";
        }

        private void btn_modulo_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
