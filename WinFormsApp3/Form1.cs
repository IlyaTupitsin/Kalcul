namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button28_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox4.Text);
            double b = Convert.ToDouble(textBox5.Text);
            double c = Convert.ToDouble(textBox6.Text);
            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                label8.Text = $" {"Дискриминант меньше нуля. Нет корней."}";
            }
            if (d == 0)
            {
                double x = (-b / 2 * a);
                label8.Text = $" {"Дискриминант равен нулю. Корень равен " + x + "."}";
            }
            if (d > 0)
            {
                double x1 = ((-b - Math.Sqrt(d)) / 2 * a);
                double x2 = ((-b + Math.Sqrt(d)) / 2 * a);
                label8.Text = $" {"Ответ: \nДискриминант равен" + d + ".\n Первый корень равен" + x1 + ".\n Второй корень равен" + x2 + "."}";
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            label4.Text = "_";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double b = Convert.ToDouble(textBox3.Text);
            if (label4.Text == "+")
            {
                double a = Convert.ToDouble(textBox1.Text);
                textBox2.Text = $" {a + b}";
            }
            if (label4.Text == "-")
            {
                double a = Convert.ToDouble(textBox1.Text);
                textBox2.Text = $" {a - b}";
            }
            if (label4.Text == "*")
            {
                double a = Convert.ToDouble(textBox1.Text);
                textBox2.Text = $" {a * b}";
            }
            if (label4.Text == "^")
            {
                double a = Convert.ToDouble(textBox1.Text);
                textBox2.Text = $" {Math.Pow(a, b)}";
            }
            if (textBox1.Text == "cos")
            {
                textBox2.Text = $" {Math.Cos(b)}";
            }
            if (textBox1.Text == "sin")
            {
                textBox2.Text = $" {Math.Sin(b)}";
            }
            if (textBox1.Text == "tg")
            {
                textBox2.Text = $" {Math.Tan(b)}";
            }
            if (textBox1.Text == "ctg")
            {
                textBox2.Text = $" {1 / Math.Tan(b)}";
            }
            if (textBox1.Text == "√")
            {
                textBox2.Text = $" {Math.Sqrt(b)}";
            }
            if (label4.Text == "/")
            {
                if (b == 0)
                {
                    double a = Convert.ToDouble(textBox1.Text);
                    textBox2.Text = "на ноль делить нельзя!!!!!!";
                }
                else
                {
                    double a = Convert.ToDouble(textBox1.Text);
                    textBox2.Text = $" {a / b}";
                }
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = "_";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "+";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = "-";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = "/";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = "*";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "cos";
            label4.Text = "_";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "sin";
            label4.Text = "_";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "ctg";
            label4.Text = "_";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "tg";
            label4.Text = "_";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = "√";
            label4.Text = "_";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            label4.Text = "^";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (label4.Text == "_")
            {
                textBox1.Text = textBox1.Text + 1;
            }
            else
            {
                textBox3.Text = textBox3.Text + 1;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (label4.Text == "_")
            {
                textBox1.Text = textBox1.Text + 2;
            }
            else
            {
                textBox3.Text = textBox3.Text + 2;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (label4.Text == "_")
            {
                textBox1.Text = textBox1.Text + 3;
            }
            else
            {
                textBox3.Text = textBox3.Text + 3;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (label4.Text == "_")
            {
                textBox1.Text = textBox1.Text + 4;
            }
            else
            {
                textBox3.Text = textBox3.Text + 4;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (label4.Text == "_")
            {
                textBox1.Text = textBox1.Text + 5;
            }
            else
            {
                textBox3.Text = textBox3.Text + 5;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (label4.Text == "_")
            {
                textBox1.Text = textBox1.Text + 6;
            }
            else
            {
                textBox3.Text = textBox3.Text + 6;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (label4.Text == "_")
            {
                textBox1.Text = textBox1.Text + 7;
            }
            else
            {
                textBox3.Text = textBox3.Text + 7;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (label4.Text == "_")
            {
                textBox1.Text = textBox1.Text + 8;
            }
            else
            {
                textBox3.Text = textBox3.Text + 8;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (label4.Text == "_")
            {
                textBox1.Text = textBox1.Text + 9;
            }
            else
            {
                textBox3.Text = textBox3.Text + 9;
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (label4.Text == "_")
            {
                textBox1.Text = textBox1.Text + 0;
            }
            else
            {
                textBox3.Text = textBox3.Text + 0;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {

            if (label4.Text == "_")
            {
                textBox1.Text = textBox1.Text + ",";
            }
            else
            {
                textBox3.Text = textBox3.Text + ",";
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {
            label10.Text = "Число в двоичной системе";
            int a= Convert.ToInt32(textBox7.Text);
            textBox8.Text = Convert.ToString(a, 2);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            label10.Text = "Число в шестнадцатиричной системе";
            int a = Convert.ToInt32(textBox7.Text);
            textBox8.Text = Convert.ToString(a, 16);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            label10.Text = "Число в восьмиричной системе";
            int a = Convert.ToInt32(textBox7.Text);
            textBox8.Text = Convert.ToString(a, 8);
        }
    }
}
