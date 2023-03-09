using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Entities.Configuracion
{
    public class Vigencia
    {
        /// <summary>
        /// Retorna o asigna el/la identifier.
        /// </summary>
        /// <value>el/la identifier.</value>
        public string IdVigencia { get; set; }

        /// <summary>
        /// Retorna o asigna el/la nombre.
        /// </summary>
        /// <value>el/la nombre.</value>
        public string Nombre { get; set; }

        /// <summary>
        /// Retorna o asigna el/la descripcion.
        /// </summary>
        /// <value>el/la descripcion.</value>
        public string Descripcion { get; set; }

        /// <summary>
        /// Retorna o asigna el/la vigente desde.
        /// </summary>
        /// <value>el/la vigente desde.</value>
        public DateTime VigenteDesde { get; set; }

        /// <summary>
        /// Retorna o asigna el/la configuracion.
        /// </summary>
        /// <value>el/la configuracion.</value>
        public string Configuracion { get; set; }

    }
}
