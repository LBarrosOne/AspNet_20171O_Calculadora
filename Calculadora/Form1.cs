using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public double? Valor1 { get; set; }
        public double? Valor2 { get; set; }

        public enum Operacoes
        {
            adicao,
            subtracao,
            multiplicacao,
            divisao
        }

        public Operacoes? Operacao { get; set; }

        public Form1()
        {
            InitializeComponent();
            Valor1 = null;
            Valor2 = null;
            Operacao = null;
        }

        private void btn1_Click(object sender, System.EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "1";
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            if (!Valor1.HasValue || !Operacao.HasValue)
            {
                Valor1 = Convert.ToDouble(txtDisplay.Text);
            }
            else
            {
                Valor2 = Convert.ToDouble(txtDisplay.Text);
            }

            Operacao = Operacoes.adicao;

            txtDisplay.Clear();
        }

        public void ExecutarCalculo()
        {
            if (Valor1.HasValue && Operacao.HasValue)
            {

                Valor2 = Convert.ToDouble(txtDisplay.Text);

                switch (Operacao)
                {
                    case Operacoes.adicao:
                        var result = Valor1.Value + Valor2.Value;
                        txtDisplay.Text = result.ToString();
                        break;

                    case Operacoes.subtracao:
                        break;

                    case Operacoes.multiplicacao:
                        break;

                    case Operacoes.divisao:
                        break;

                    default:
                        break;
                }
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            ExecutarCalculo();
        }
    }
}
