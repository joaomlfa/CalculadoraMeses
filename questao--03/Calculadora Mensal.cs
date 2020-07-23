using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace questao__03
{
    public partial class Form1 : Form
    {        
        private const decimal porcentagem_entrada = 0.25M;
        private const decimal r = 0.04M;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //Verificar se os campos estão Digitados.
            if (textSalario.Text.Equals(""))
            {
                MessageBox.Show("Digite o valor do Salário.");
                textSalario.Focus();
                return;
            }else if (textEconomizar.Text.Equals(""))
            {
                MessageBox.Show("Digite o percentual de economia Mensal.");
                textEconomizar.Focus();
                return;
            }
            else if (textValorApartamento.Text.Equals(""))
            {
                MessageBox.Show("Digite o valor do Apartamento.");
                textValorApartamento.Focus();
                return;
            }

            //Declaração de Variáveis
            int quantidade_meses_necessario = 0;
            decimal salario_anual;
            decimal salario_mensal;
            decimal valor_entrada;
            decimal economias_atuais = 0;
            decimal percentual_economizado;
            decimal custo_total;

            //Atribuir os campos a suas Respectivas Variáveis.

            salario_anual = Convert.ToDecimal(textSalario.Text.Replace(",",".")) ;
            percentual_economizado = Convert.ToDecimal(textEconomizar.Text.Replace(",", ".")) /100;
            custo_total = Convert.ToDecimal(textValorApartamento.Text.Replace(",", "."));

            if(percentual_economizado > 1)
            {
                MessageBox.Show("Percentual Economizado mensalmente deve ser menor que 100%");
                textEconomizar.Focus();
                return;
            }

            //Calcular salario Mensal.
            salario_mensal = salario_anual / 12;

            //Calcular o valor da entrada do Apartamento.
            valor_entrada = custo_total * porcentagem_entrada;

            //Calcular meses necessários.
            for(int i = 1; economias_atuais < valor_entrada; i++)
            {
                
                decimal retorno;

                // Verifica se a economia Atual é 0 ou se possui valor para calcular  retorno anual.
                if(economias_atuais == 0)
                {
                    retorno = 0;
                }
                else
                {
                    retorno = economias_atuais * r / 12;
                    economias_atuais += retorno;
                }
                //Calcular percentual mensal do salário
                economias_atuais += salario_mensal * percentual_economizado;

                //Acrescentar um mes na quantidade necessária.
                quantidade_meses_necessario++;
            }
            //Exibe a quantidade de mês necessário.
            MessageBox.Show("Serão Necessários " + quantidade_meses_necessario.ToString() + " Meses de Economia");
        }




        // Permitir apenas Números e Vírgula/Ponto
        private void textSalario_TextChanged(object sender, EventArgs e)
        {
            textSalario.Text = Regex.Replace(textSalario.Text, "[^0-9,.]", "");
        }

        private void textEconomizar_TextChanged(object sender, EventArgs e)
        {
            textSalario.Text = Regex.Replace(textSalario.Text, "[^0-9,.]", "");
        }

        private void textValorApartamento_TextChanged(object sender, EventArgs e)
        {
            textSalario.Text = Regex.Replace(textSalario.Text, "[^0-9,.]", "");
        }
    }
}
