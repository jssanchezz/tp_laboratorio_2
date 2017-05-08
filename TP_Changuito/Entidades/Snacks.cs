using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_2017
{
    public class Snacks : Producto
    {

        #region "Constructor"

        public Snacks(EMarca marca, string codigoDeBarra, ConsoleColor color)
            : base(codigoDeBarra, marca, color)
        {
        }

        #endregion

        #region "Propiedades"

        /// <summary>
        /// Los snacks tienen 104 calorías
        /// </summary>
        public override short CantidadCalorias
        {
            get
            {
                return 104;
            }
        }

        #endregion

        #region "Métodos"

        /// <summary>
        /// Publica todos los datos del objeto Snacks
        /// </summary>
        /// <returns>String con todos los datos del objeto.</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SNACKS");
            sb.AppendLine((string)this);
            sb.AppendFormat("CALORIAS : {0}", this.CantidadCalorias);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}
