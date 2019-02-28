using System;
using System.Windows.Forms;

namespace Calculator
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public string result;
        public string value1;
        public string value2;
        public string process;
        string[] value = new string[8];

        //Digit buttons are here
        private void button1n_Click(object sender, EventArgs e)
        {
            calc("1");
        }
        private void button9n_Click(object sender, EventArgs e)
        {
            calc("9");
        }
        private void button8n_Click(object sender, EventArgs e)
        {
            calc("8");
        }
        private void button7n_Click(object sender, EventArgs e)
        {
            calc("7");
        }
        private void button4n_Click(object sender, EventArgs e)
        {
            calc("4");
        }
        private void button5n_Click(object sender, EventArgs e)
        {
            calc("5");
        }
        private void button6n_Click(object sender, EventArgs e)
        {
            calc("6");
        }
        private void button2n_Click(object sender, EventArgs e)
        {
            calc("2");
        }
        private void button3n_Click(object sender, EventArgs e)
        {
            calc("3");
        }
        private void button0n_Click(object sender, EventArgs e)
        {
            calc("0");
        }
        private void button_decimal_Click(object sender, EventArgs e)
        {
            calc(".");
        }
        //

        //Operation buttons are here
        private void button_addition_Click(object sender, EventArgs e)
        {
            if (this.value2 != "")
            {
                check();
                this.value2 = this.value1;
                this.value1 = "";
                textBox_result.Text = this.value2;
            }
            else
            {
                this.value1 = (Convert.ToDouble(this.value1) + 0).ToString();
                textBox_result.Text = "";
                this.value2 = this.value1;
                this.value1 = "";
                textBox_result.Text = this.value2;
            }
            this.process = "+";
        }
        private void button_division_Click(object sender, EventArgs e)
        {
            if (this.value2 != null)
            {
                check();
                this.value2 = this.value1;
                this.value1 = "";
                textBox_result.Text = this.value2;
            }
            else
            {
                this.value1 = (Convert.ToDouble(this.value1) / 1).ToString();
                textBox_result.Text = value2;
                textBox_result.Text = "";
                this.value2 = this.value1;
                this.value1 = "";
                textBox_result.Text = this.value2;
            }
            this.process = "/";
        }
        private void button_multiplication_Click(object sender, EventArgs e)
        {
            if (this.value2 != null)
            {
                check();
                this.value2 = this.value1;
                this.value1 = "";
                textBox_result.Text = this.value2;
            }
            else
            {
                this.value1 = (Convert.ToDouble(this.value1) * 1).ToString();
                this.value2 = this.value1;
                this.value1 = "";
                textBox_result.Text = this.value2;
            }
            this.process = "*";
        }
        private void button_substraction_Click(object sender, EventArgs e)
        {
            if (this.value2 != null)
            {
                check();
                this.value2 = this.value1;
                this.value1 = "";
                textBox_result.Text = this.value2;
            }
            else
            {
                this.value1 = (Convert.ToDouble(this.value1) - 0).ToString();
                textBox_result.Text = "";
                this.value2 = this.value1;
                this.value1 = "";
                textBox_result.Text = this.value2;
            }
            this.process = "-";
        }
        private void button_result_Click(object sender, EventArgs e)
        {
            check();
            this.value2 = this.value1;
            this.value1 = "";
            textBox_result.Text = this.value2;
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "";
            this.process = "";
            this.value1 = "";
            this.value2 = "";
            this.result = "";
        }
        //


        // Methods are here
        public void check()
        {
            if (this.process == "+") { this.value1 = (Convert.ToDouble(this.value2) + Convert.ToDouble(this.value1)).ToString(); }
            else if (this.process == "-") { this.value1 = (Convert.ToDouble(this.value2) - Convert.ToDouble(this.value1)).ToString(); }
            else if (this.process == "*") { this.value1 = (Convert.ToDouble(this.value2) * Convert.ToDouble(this.value1)).ToString(); }
            else if (this.process == "/") { this.value1 = (Convert.ToDouble(this.value2) / Convert.ToDouble(this.value1)).ToString(); }
        }
        private string calc(string digit)
        {
            this.value1 += digit;
            this.result = this.value1;
            textBox_result.Text = this.result;
            return this.result;
        }
        //

    }
}

