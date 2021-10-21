using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double Valor1, Valor2;
        string Op;

        public Form1()
        {
            InitializeComponent();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "1";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "1";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Valor1 = 0;
            Valor2 = 0;
            txtPantalla.Clear();
            txtPantalla.Focus();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "2";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "2";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "3";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "3";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "4";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "5";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "5";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "5";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "6";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "7";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "7";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "8";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "8";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "9";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "0";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {

            }
            else
            {
                Valor1 = Convert.ToDouble(txtPantalla.Text);
                Op = "/";
                txtPantalla.Clear();
                txtPantalla.Focus();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {

            }
            else
            {
                Valor1 = Convert.ToDouble(txtPantalla.Text);
                Op = "*";
                txtPantalla.Clear();
                txtPantalla.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {

            }
            else
            {
                Valor1 = Convert.ToDouble(txtPantalla.Text);
                Op = "-";
                txtPantalla.Clear();
                txtPantalla.Focus();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {

            }
            else
            {
                Valor1 = Convert.ToDouble(txtPantalla.Text);
                Op = "+";
                txtPantalla.Clear();
                txtPantalla.Focus();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {

            }
            else
            {
                Valor2 = Convert.ToDouble(txtPantalla.Text);
                switch (Op)
                {
                    case "+": txtPantalla.Text = Convert.ToString(Valor1 + Valor2); break;
                    case "-": txtPantalla.Text = Convert.ToString(Valor1 - Valor2); break;
                    case "*": txtPantalla.Text = Convert.ToString(Valor1 * Valor2); break;
                    case "/": txtPantalla.Text = Convert.ToString(Valor1 / Valor2); break;
                }
            }
        }

        private void copiarResultadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
                txtPantalla.SelectAll();
                txtPantalla.Copy();

        }

        public void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AcercaDe acercade = new AcercaDe();
            acercade.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = ".";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + ".";
            }
        }
    }
}
