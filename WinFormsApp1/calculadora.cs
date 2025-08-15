using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class calculadora : Form
    {
        string var;
        String resultado;
        string in1;
        string in2;
        int opcion = 0;


        public calculadora()
        {
            InitializeComponent();
        }

        private void calculadora_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var += "1";
            in2 += "1";
            Console.WriteLine(resultado);
            label1.Text = var.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(resultado);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            var += "2";
            in2 += "2";
            Console.WriteLine(resultado);
            label1.Text = var.ToString();

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            var += "3";
            in2 += "3";
            Console.WriteLine(resultado);
            label1.Text = var.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            var += "4";
            in2 += "4";
            Console.WriteLine(resultado);
            label1.Text = var.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            var += "5";
            in2 += "5";
            Console.WriteLine(resultado);
            label1.Text = var.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            var += "6";
            in2 += "6";
            Console.WriteLine(resultado);
            label1.Text = var.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            var += "7";
            in2 += "7";
            Console.WriteLine(resultado);
            label1.Text = var.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            var += "8";
            in2 += "8";
            Console.WriteLine(resultado);
            label1.Text = var.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            var += "9";
            in2 += "9";
            Console.WriteLine(resultado);
            label1.Text = var.ToString();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            opcion = 1;
            in1 = var;
            in2 = "";

        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            opcion = 2;
            in1 = var;
            in2 = "";

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            opcion = 3;
            in1 = var;
            in2 = "";

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            opcion = 4;
            in1 = var;
            in2 = "";

        }

        private void btnEquals_Click(object sender, EventArgs e)

        {


            switch (opcion)
            {
                case 1:

                    resultado = (float.Parse(in1) + float.Parse(in2)).ToString();

                    break;

                case 2:
                    resultado = (float.Parse(in1) - float.Parse(in2)).ToString();
                    break;
                case 3:
                    resultado = (float.Parse(in1) * float.Parse(in2)).ToString();
                    break;
                case 4:
                    resultado = (float.Parse(in1) / float.Parse(in2)).ToString();
                    break;
                default:
                    break;
            }
            label1.Text = resultado.ToString();
            in1 = "";
            in2 = "";
            var = "";
            resultado = "";

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            var += "0";
            in2 += "0";
            label1.Text = var;
        }

        private void btnCe_Click(object sender, EventArgs e)
        {
            var = "";
            in1 = "";
            in2 = "";
            resultado = "";
            label1.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(var))
            {
                var = var.Substring(0, var.Length - 1);
                if (!string.IsNullOrEmpty(in2))
                {
                    in2 = in2.Substring(0, in2.Length - 1);
                }
                label1.Text = var;
            }
        }

        
            
        
    }
}
