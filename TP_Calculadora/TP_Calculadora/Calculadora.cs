using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Calculadora
{
    public class Calculadora
    {
        #region Métodos

        /// <summary>
        /// Realiza la operacion requerida entre dos operandos
        /// </summary>
        /// <param name="numero1">Numero a operar del tipo NUMERO</param>
        /// <param name="numero2">Numero a operar del tipo NUMERO</param>
        /// <param name="operador">Tipo de operacion a realizar del caracter string</param>
        /// <returns>Resultado de ka operacion del tipo double</returns>
        public static double Operar(Numero numero1, Numero numero2, string operador)
        {
            double resultado = 0;

            switch (Calculadora.ValidarOperador(operador))
            {
                case "+":
                    resultado = numero1.getNumero() + numero2.getNumero();
                    break;

                case "-":
                    resultado = numero1.getNumero() - numero2.getNumero();
                    break;

                case "*":
                    resultado = numero1.getNumero() * numero2.getNumero();
                    break;

                case "/":
                    if (numero2.getNumero() == 0)
                        break;
                    resultado = numero1.getNumero() / numero2.getNumero();
                    break;
            }

            return resultado;
        }

        /// <summary>
        /// Valida que el string contenga un operador valido
        /// </summary>
        /// <param name="operador">string a validar</param>
        /// <returns>Si el operador es válido retornara dicho operador, caso contrario retorna "+"</returns>
        public static string ValidarOperador(string operador)
        {
            if (operador == "")
                return "+";
            return operador;
        }

        #endregion
    }
}
