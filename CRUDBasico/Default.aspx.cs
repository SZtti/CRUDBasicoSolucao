using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDBasico
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            h1Titulo.InnerText = "Conhecendo Asp.Net e C#";
        }

        protected void btnCalcular_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(txtN1.Text);
            int n2 = Convert.ToInt32(txtN2.Text);
            string op = txtOperador.Text;
            bool validacao = true;

            double resultado = 0;

            switch (op)
            {
                case "+":
                    resultado = Somar(n1, n2);
                    break;
                case "-":
                    resultado = Subtrair(n1, n2);
                    break;
                case "*":
                    resultado = Multiplicar(n1, n2);
                    break;
                case "/":
                    resultado = Dividir(n1, n2);
                    if(resultado == -1)
                    {
                       validacao = false;
                    }
                    break;
                default:
                        validacao = false;
                    break;
            }
            if (validacao)
            {
                string mensagem = "O resultado da operação é " + resultado + ".";
                MostrarMensagem(mensagem);
            }
            else
            {
                MostrarMensagem("Não foi possível realizar a operação!");
            }
        }

        /// <summary>
        /// Quando retornar -1, significa uma divisão inválida
        /// </summary>
        /// <returns></returns>
        private double Dividir(int n1, int n2)
        {
            double resultado;
            if(n2 > 0) { 
                resultado = n1 / n2;
            }
            else
            {
                resultado = -1;
            }
            return resultado;
        }

        private double Multiplicar(int n1, int n2)
        {
            double resultado = n1 * n2;
            return resultado;
        }

        private double Subtrair(int n1, int n2)
        {
            double resultado = n1 - n2;
            return resultado;
        }

        private double Somar(int n1, int n2)
        {
            double resultado = n1 + n2;
            //MostrarMensagem(resultado.ToString());
            return resultado;
        }


        private void MostrarMensagem(string mensagem)
        {
            lblResultado.InnerText = mensagem;
        }
    }
}