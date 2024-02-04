namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int num1;
        int num2;
        int num3;
        int num4;
        int total;

        string opt;


        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "2";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "1";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "9";
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + ".";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            opt = "+";
            num1 = Convert.ToInt32(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(txtTotal.Text);
            if (opt == "+")
            {
                total = num1 + num2;
            }
                      
            if (opt == "-")
            {
                total = num1 - num2;
            }

            if (opt == "*")
            {
                total = num1 * num2;
            }

            if (opt == "/")
            {
                total = num1 / num2;

            }

            txtTotal.Clear();

            txtTotal.Text = total.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            total = (0);
            num1 = (0);
            num2 = (0);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            opt = "-";
            num1 = Convert.ToInt32(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            opt = "*";
            num1 = Convert.ToInt32(txtTotal.Text);
            txtTotal.Clear();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            opt = "/";
            num1 = Convert.ToInt32(txtTotal.Text);
            txtTotal.Clear();
        }
    }
}
