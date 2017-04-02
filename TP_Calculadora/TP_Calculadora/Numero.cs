using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Calculadora
{
    public class Numero
    {
        private double _numero;

        #region Constructores

        /// <summary>
        /// Constructor por defecto, inicializa el atributo _numero en 0
        /// </summary>
        public Numero()
        {
            this._numero = 0;
        }

        /// <summary>
        /// Sobrecarga de constructor, recibe como parametro un string
        /// </summary>
        /// <param name="numero">string a cargar en el objeto</param>
        public Numero(string numero)
        {
            this.setNumero(numero);
        }

        /// <summary>
        /// Sobrecarga de constructor, recibe como parámetro un double y lo carga en el atributo _numero
        /// </summary>
        /// <param name="numero">double a cargar</param>
        public Numero(double numero)
        {
            this._numero = numero;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Realiza la validacion de si un string es parseable a double
        /// </summary>
        /// <param name="numeroString">string a validar</param>
        /// <returns>Retorna string parseado a double, caso contrario retorna cero</returns>
        private static double validarNumero(string numeroString)
        {
            double numAuxiliar;

            if (double.TryParse(numeroString, out numAuxiliar))
                return numAuxiliar;
            return 0;

        }

        /// <summary>
        /// Setea la variale _numero con parametro del tipo string
        /// </summary>
        /// <param name="numeroString">string a cargar en el atributo _numero</param>
        private void setNumero(string numeroString)
        {
            this._numero = Numero.validarNumero(numeroString);
        }

        /// <summary>
        /// Obtenemos el valor del atributo _numero del objeto Numero
        /// </summary>
        /// <returns>retorna el valor de tipo double</returns>
        public double getNumero()
        {
            return this._numero;
        }

        #endregion
    }
}
