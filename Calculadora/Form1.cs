using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class cal : Form
    {
        string Op;
        double num1, num2;


        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "")
            {
                txtResultado.Text = "1";
            }
            else
            {
                txtResultado.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "")
            {
                txtResultado.Text = "2";
            }
            else
            {
                txtResultado.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "")
            {
                txtResultado.Text = "3";
            }
            else
            {
                txtResultado.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "")
            {
                txtResultado.Text = "4";
            }
            else
            {
                txtResultado.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "")
            {
                txtResultado.Text = "5";
            }
            else
            {
                txtResultado.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "")
            {
                txtResultado.Text = "6";
            }
            else
            {
                txtResultado.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "")
            {
                txtResultado.Text = "7";
            }
            else
            {
                txtResultado.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "")
            {
                txtResultado.Text = "8";
            }
            else
            {
                txtResultado.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "")
            {
                txtResultado.Text = "9";
            }
            else
            {
                txtResultado.Text += "9";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == "")
            {
                txtResultado.Text = ",";
            }
            else
            {
                txtResultado.Text += ",";
            }
        }

  
    

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtResultado.Text);
            Op = "/";
            txtResultado.Clear();
            txtResultado.Focus();

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtResultado.Text);
            Op = "*";
            txtResultado.Clear();
            txtResultado.Focus();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtResultado.Text);
            Op = "-";
            txtResultado.Clear();
            txtResultado.Focus();
        }


        private void btnAdicao_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtResultado.Text);
            Op = "+";
            txtResultado.Clear();
            txtResultado.Focus();
        }

     
        public cal()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtResultado.Text);

            switch(Op)
            {
                case "+":
                    txtResultado.Text = Convert.ToString(num1 + num2);
                    break;

                case "-":
                    txtResultado.Text = Convert.ToString(num1 - num2);
                    break;
                case "*":
                    txtResultado.Text = Convert.ToString(num1 * num2);
                    break;
                case "/":
                    txtResultado.Text = Convert.ToString(num1 / num2);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtResultado.Equals(""))
            {
                txtResultado.Text = "0";
            }
            else
            {
                txtResultado.Text += "0";
            }
        }

        private void clean_Click(object sender, EventArgs e)
        {
           
            num1 = 0;
            num2 = 0;
            txtResultado.Clear();
        }
  


       



    }
}
