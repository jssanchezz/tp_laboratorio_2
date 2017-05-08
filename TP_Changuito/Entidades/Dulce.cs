using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{
    public class Dulce : Producto
    {

        #region "Constructor"

        public Dulce(EMarca marca, string codigoDeBarra, ConsoleColor color)
            : base(codigoDeBarra, marca, color)
        { }

        #endregion

        #region "Propiedades"

        /// <summary>
        /// Los dulces tienen 80 calorías
        /// </summary>
        public override short CantidadCalorias
        {
            get
            {
                return 80;
            }
        }

        #endregion

        #region "Métodos"

        /// <summary>
        /// Publica los datos del objeto tipo Dulce.
        /// </summary>
        /// <returns>String con los datos del objeto.</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");
            sb.AppendLine((string)this);
            sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
