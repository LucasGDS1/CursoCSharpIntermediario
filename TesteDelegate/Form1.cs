using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TesteDelegate.Operacoes;

namespace TesteDelegate
{
    public partial class Form1 : Form
    {
        private delegate int ExecutarOperacoes(int vl1, int vl2);
        private ExecutarOperacoes minhaOperacao;
        private CalculaSoma opSoma = new CalculaSoma();
        private CalculaDivisao opDivisao = new CalculaDivisao();
        private CalculaMultiplicacao opMultiplicacao = new CalculaMultiplicacao();
        private CalculaSubtracao opSubtracao = new CalculaSubtracao();

        public Form1()
        {
            InitializeComponent();
        }

        private int Calcular()
        {
            int num1 = Convert.ToInt32(txtPrimeiroValor.Text);
            int num2 = Convert.ToInt32(txtSegundoValor.Text);
            return minhaOperacao(num1, num2);
        }
       
        private void btnAdicao_Click(object sender, EventArgs e)
        {
            minhaOperacao = new ExecutarOperacoes(opSoma.Somar);
            txtResultado.Text = Calcular().ToString();
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            minhaOperacao = new ExecutarOperacoes(opSubtracao.Subtracao);
            txtResultado.Text = Calcular().ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            minhaOperacao = new ExecutarOperacoes(opDivisao.Divisao);
            txtResultado.Text = Calcular().ToString();
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            minhaOperacao = new ExecutarOperacoes(opMultiplicacao.Multiplicacao);
            txtResultado.Text = Calcular().ToString();
        }
    }
}
