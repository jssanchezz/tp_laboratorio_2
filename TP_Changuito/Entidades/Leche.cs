using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades_2017
{
    public class Leche : Producto
    {
        public enum ETipo { Entera, Descremada }
        ETipo _tipo;

        #region "Constructor"

        /// <summary>
        /// Por defecto, TIPO será ENTERA
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigoDebarra"></param>
        /// <param name="color"></param>
        public Leche(EMarca marca, string codigoDebarra, ConsoleColor color, ETipo tipo)
            : base(codigoDebarra, marca, color)
        {
            this._tipo = tipo;
        }

        public Leche(EMarca marca, string codigoDeBarra, ConsoleColor color)
            : this(marca, codigoDeBarra, color, ETipo.Entera)
        { }

        #endregion

        #region "Propiedades"

        /// <summary>
        /// Las leches tienen 20 calorías
        /// </summary>
        public override short CantidadCalorias
        {
            get
            {
                return 20;
            }
        }

        #endregion

        #region "Métodos"

        /// <summary>
        /// Publica los datos del objeto tipo Leche.
        /// </summary>
        /// <returns>String con los datos del objeto.</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("LECHE");
            sb.AppendLine((string)this);
            sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            sb.AppendLine("TIPO : " + this._tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
