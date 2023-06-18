using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {   
        bool valueEntered = false; // value Entered
        String operation = "";
        Double result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {               //The size of the calculator
            this.Width = 340;
            resultTextBox1.Width = 280;
        }             

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {             // Scientific calculator size
            this.Width = 680;
            resultTextBox1.Width = 620;
        }               

        private void button_click(object sender, EventArgs e)
        {           //A button for all the numbers and a point
            if (resultTextBox1.Text == "0" || (valueEntered))
            
                resultTextBox1.Text = " ";
            valueEntered = false;

            Button num = (Button)sender;

            if (num.Text == ".")
            {
                if (!resultTextBox1.Text.Contains("."))
                     resultTextBox1.Text = resultTextBox1.Text + num.Text;
            }
            else
                resultTextBox1.Text =resultTextBox1.Text + num.Text;
                           
        }

        private void button2_Click(object sender, EventArgs e)
        {           //Clear button
            resultTextBox1.Clear();
            labelSow.Text = " ";
        }
        private void label2_Click(object sender, EventArgs e)// אני לא מבין למה צריך את זה
        {
            //Clear button
        }

        private void button1_Click(object sender, EventArgs e)
        {                   // Delete button
            if (resultTextBox1.Text.Length > 0)
            {
                resultTextBox1.Text = resultTextBox1.Text.Remove(resultTextBox1.Text.Length - 1, 1);
            }
            if(resultTextBox1.Text == " ")
            {
                resultTextBox1.Text = "0";
            }
        }

        private void opertor_click1(object sender, EventArgs e)
        {           // //opertor_click  (+,-,*,/,mod)
            Button num = (Button)sender;
            operation = num.Text;

            result = Double.Parse(resultTextBox1.Text);
            resultTextBox1.Text = "";
            labelSow.Text = result + " " + operation;
        }
        private void button17_Click(object sender, EventArgs e)
        {               // Equal
            switch (operation)
            {
                case "+":
                    resultTextBox1.Text = (result + Double.Parse(resultTextBox1.Text)).ToString();
                    break;
                case "-":
                    resultTextBox1.Text = (result - Double.Parse(resultTextBox1.Text)).ToString();
                    break;
                case "*":
                    resultTextBox1.Text = (result * Double.Parse(resultTextBox1.Text)).ToString();
                    break;
                case "/":
                    resultTextBox1.Text = (result / Double.Parse(resultTextBox1.Text)).ToString();
                    break;
                case "mod":
                    resultTextBox1.Text = (result % Double.Parse(resultTextBox1.Text)).ToString();
                    break;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {    //  Pi
            resultTextBox1.Text = "3.14159265358997";
        }

        private void button29_Click(object sender, EventArgs e)
        {           //   log
            double log = double.Parse(resultTextBox1.Text);
            labelSow.Text = "log" + "(" + (resultTextBox1.Text) + ")";
            log = Math.Log10(log);
            resultTextBox1.Text = log.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {               // sqrt
            double sqrt = double.Parse(resultTextBox1.Text);
            labelSow.Text = "sqrt" + "(" + (resultTextBox1.Text) + ")";
            sqrt = Math.Sqrt(sqrt);
            resultTextBox1.Text = sqrt.ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {           //  sinh
            double sinh = double.Parse(resultTextBox1.Text);
            labelSow.Text = "sinh" + "(" + (resultTextBox1.Text) + ")";
            sinh = Math.Sinh(sinh);
            resultTextBox1.Text = sinh.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {           //  cosh
            double cosh = double.Parse(resultTextBox1.Text);
            labelSow.Text = "cosh" + "(" + (resultTextBox1.Text) + ")";
            cosh = Math.Cosh(cosh);
            resultTextBox1.Text = cosh.ToString();
        }

        private void button38_Click(object sender, EventArgs e)
        {                   // tanh
            double tanh = double.Parse(resultTextBox1.Text);
            labelSow.Text = "tanh" + "(" + (resultTextBox1.Text) + ")";
            tanh = Math.Tanh(tanh);
            resultTextBox1.Text = tanh.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {               // sin
            double sin = double.Parse(resultTextBox1.Text);
            labelSow.Text = "sin" + "(" + (resultTextBox1.Text) + ")";
            sin = Math.Sin(sin);
            resultTextBox1.Text = sin.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {           // cos
            double cos = double.Parse(resultTextBox1.Text);
            labelSow.Text = "cos" + "(" + (resultTextBox1.Text) + ")";
            cos = Math.Cos(cos);
            resultTextBox1.Text = cos.ToString();
        }

        private void button37_Click(object sender, EventArgs e)
        {               // tan
            double tan = double.Parse(resultTextBox1.Text);
            labelSow.Text = "tan" + "(" + (resultTextBox1.Text) + ")";
            tan = Math.Tan(tan);
            resultTextBox1.Text = tan.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {           // BIN
            int BIN = int.Parse(resultTextBox1.Text);
            resultTextBox1.Text = System.Convert.ToString(BIN, 2);
        }

        private void button36_Click(object sender, EventArgs e)
        {               // HEX
            int HEX = int.Parse(resultTextBox1.Text);
            resultTextBox1.Text = System.Convert.ToString(HEX, 16) ;
        }

        private void button32_Click(object sender, EventArgs e)
        {           //   OCT
            int OCT = int.Parse(resultTextBox1.Text);
            resultTextBox1.Text = System.Convert.ToString(OCT, 8) ;
        }

        private void button24_Click(object sender, EventArgs e)
        {           // DEC
            int DEC = int.Parse(resultTextBox1.Text);
            resultTextBox1.Text = System.Convert.ToString(DEC);
        }

        private void button27_Click(object sender, EventArgs e)
        {           // x^2
            Double x;
            x = Convert.ToDouble(resultTextBox1.Text) * Convert.ToDouble(resultTextBox1.Text);
            resultTextBox1.Text = x.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {           // x^3
            Double x;
            x = Convert.ToDouble(resultTextBox1.Text) * Convert.ToDouble(resultTextBox1.Text) * Convert.ToDouble(resultTextBox1.Text);
            resultTextBox1.Text = x.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {           // 1/x
            Double x;
            x = Convert.ToDouble(1.0 / Convert.ToDouble(resultTextBox1.Text));
            resultTextBox1.Text = x.ToString();
        }

        private void button35_Click(object sender, EventArgs e)
        {           // lnx
            double lnx = double.Parse(resultTextBox1.Text);
            labelSow.Text = "lnx" + "(" + (resultTextBox1.Text) + ")";
            lnx = Math.Log(lnx);
            resultTextBox1.Text = lnx.ToString();
        }

        private void button31_Click(object sender, EventArgs e)
        {           // %
            Double x;
            x = Convert.ToDouble(resultTextBox1.Text) / Convert.ToDouble(100);
            resultTextBox1.Text = System.Convert.ToString(x);
        }
    }
}
