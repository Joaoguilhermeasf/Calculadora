using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        double resultado = 0;
        string operation = "";
        bool opform = false;
        bool resultadoexibido = false;
        public Form1()
        {
            InitializeComponent();

        }


        private void Button_click(object sender, EventArgs e)
        {
            if ((textBox_result.Text == "0") || (opform))
            {
                textBox_result.Clear();
            }
            opform = false;
            Button button = (Button)sender;
            if (textBox_result.Text == ".")
            {
                if (!textBox_result.Text.Contains("."))
                {
                    textBox_result.Text += button.Text;
                }
            }
            else
            {
                textBox_result.Text += button.Text;
            }
        }

        private void Button_click1(object sender, EventArgs e)
        {

            Button button = (Button)sender;

            if (resultado != 0)
            {
                button12.PerformClick();
                operation = button.Text;
                label.Text = resultado + " " + operation;
                opform = true;
            }

            else
            {
                operation = button.Text;
                resultado = double.Parse(textBox_result.Text);
                label.Text = resultado + " " + operation;
                opform = true;
            }
        }


        private void Button_clickC1(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
        }
        private void Button_clickC(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            resultado = 0;

        }

        private void Button_clickig(object sender, EventArgs e)
        {
            double operand = double.Parse(textBox_result.Text);

            if (!string.IsNullOrEmpty(operation))
            {
                switch (operation)
                {
                    case "+":
                        resultado += operand;
                        break;
                    case "-":
                        resultado = resultado - operand;
                        break;
                    case "X":
                        resultado *= operand;
                        break;
                    case "/":
                        resultado /= operand;
                        break;
                    default:
                        resultado = operand;
                        break;
                }
            }
            else
            {
                resultado = operand;
            }

            textBox_result.Text = resultado.ToString();
            label.Text = "";
            operation = "";

            resultadoexibido = true; // Defina para true após exibir o resultado
        }

        // Método para redefinir a variável resultadoExibido
        private void ResetResultadoExibido()
        {
            resultadoexibido = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click_1(object sender, EventArgs e)
        {

        }

        private void exitclick(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}