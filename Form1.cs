namespace lab_1
{
    public partial class Form1 : Form
    {
        // class varible
        double input1 = 0;
        string operation = "";
        public Form1()
        {

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)

                textBox1.Text = Convert.ToDouble(textBox1.Text).ToString("#,##0");
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)

                textBox2.Text = Convert.ToDouble(textBox2.Text).ToString("#,##0");
            textBox2.SelectionStart = textBox2.Text.Length;

        }

        // ปุ่ม 7
        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "7";
            this.textBox2.Text = this.textBox2.Text + "7";
        }

        // ปุ่ม 8
        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "8";
            this.textBox2.Text = this.textBox2.Text + "8";
        }

        // ปุ่ม 9
        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "9";
            this.textBox2.Text = this.textBox2.Text + "9";
        }

        // ปุ่ม +
        private void button4_Click(object sender, EventArgs e)
        {
            input1 = double.Parse(this.textBox1.Text);
            operation = "+";
            this.textBox1.Text = "";
            this.textBox2.Text = this.textBox2.Text + "+";
        }

        // ปุ่ม 4
        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "4";
            this.textBox2.Text = this.textBox2.Text + "4";
        }

        // ปุ่ม 5
        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "5";
            this.textBox2.Text = this.textBox2.Text + "5";
        }

        // ปุ่ม 6
        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "6";
            this.textBox2.Text = this.textBox2.Text + "6";
        }

        // ปุ่ม -
        private void button8_Click(object sender, EventArgs e)
        {
            input1 = double.Parse(this.textBox1.Text);
            operation = "-";
            this.textBox1.Text = "";
            this.textBox2.Text = this.textBox2.Text + "-";
        }

        // ปุ่ม 1
        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "1";
            this.textBox2.Text = this.textBox2.Text + "1";
        }

        // ปุ่ม 2
        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "2";
            this.textBox2.Text = this.textBox2.Text + "2";
        }

        // ปุ่ม 3
        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "3";
            this.textBox2.Text = this.textBox2.Text + "3";
        }

        // ปุ่ม x
        private void button12_Click(object sender, EventArgs e)
        {
            input1 = double.Parse(this.textBox1.Text);
            operation = "x";
            this.textBox1.Text = "";
            this.textBox2.Text = this.textBox2.Text + "x";
        }

        // ปุ่ม 0
        private void button13_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "0";
            this.textBox2.Text = this.textBox2.Text + "0";
        }

        // ปุ่ม .
        private void button14_Click(object sender, EventArgs e)
        {
            input1 = double.Parse(this.textBox1.Text);
            operation = ".";
            this.textBox1.Text = "";
            this.textBox2.Text = this.textBox2.Text + ".";
        }

        // ปุ่ม /
        private void button15_Click(object sender, EventArgs e)
        {
            input1 = double.Parse(this.textBox1.Text);
            operation = "/";
            this.textBox1.Text = "";
            this.textBox2.Text = this.textBox2.Text + "/";
        }

        // ปุ่ม c
        private void button16_Click(object sender, EventArgs e)
        {
            input1 = double.Parse(this.textBox1.Text);
            operation = "c";
            this.textBox1.Text = "";
            this.textBox2.Text = this.textBox2.Text + "c";
        }

        // ปุ่ม =
        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "=";

            if (this.operation == "+")
            {

                double inpul2 = double.Parse(this.textBox1.Text);
                this.textBox2.Text = (input1 + inpul2).ToString("#,##0");

            }
            else if (this.operation == "-")
            {
                double inpul2 = double.Parse(this.textBox1.Text);
                this.textBox2.Text = (input1 - inpul2).ToString("#,##0");

            }
            else if (this.operation == "*")
            {
                double inpul2 = double.Parse(this.textBox1.Text);
                this.textBox2.Text = (input1 * inpul2).ToString("#,##0");
            }
            else if (this.operation == "/")
            {
                double inpul2 = double.Parse(this.textBox1.Text);
                this.textBox2.Text = (input1 / inpul2).ToString("#,##0");

            }


        }
    }
}
