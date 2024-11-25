using System;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        private double primeiroNumero = 0;
        private double segundoNumero = 0;
        private string operador = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("1");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.AppendText("2");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.AppendText("3");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox1.AppendText("4");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.AppendText("5");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.AppendText("6");
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.AppendText("7");
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox1.AppendText("8");
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox1.AppendText("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            operador = "+";
            if (double.TryParse(textBox1.Text, out primeiroNumero))
            {
                textBox1.Clear();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operador = "-";
            if (double.TryParse(textBox1.Text, out primeiroNumero))
            {
                textBox1.Clear();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operador = "*";
            if (double.TryParse(textBox1.Text, out primeiroNumero))
            {
                textBox1.Clear();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operador = "/";
            if (double.TryParse(textBox1.Text, out primeiroNumero))
            {
                textBox1.Clear();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("0");
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out segundoNumero))
            {
                double resultado = 0;

                switch (operador)
                {
                    case "+":
                        resultado = primeiroNumero + segundoNumero;
                        break;
                    case "-":
                        resultado = primeiroNumero - segundoNumero;
                        break;
                    case "*":
                        resultado = primeiroNumero * segundoNumero;
                        break;
                    case "/":
                        if (segundoNumero != 0)
                            resultado = primeiroNumero / segundoNumero;
                        else
                        {
                            textBox1.Text = "Erro";
                            MessageBox.Show("Erro, você tentou dividir por zero.");
                            return;
                        }
                        break;
                }

                textBox1.Text = resultado.ToString();
                MessageBox.Show("Resultado: " + resultado.ToString());
            }
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Limpar?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                textBox1.Clear();
                primeiroNumero = 0;
                segundoNumero = 0;
                operador = "";
            }
        }
    }
}