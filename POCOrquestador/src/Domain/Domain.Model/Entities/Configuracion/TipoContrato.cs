using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Entities.Configuracion
{
    public class TipoContrato
    {
        /// <summary>
        /// Retorna o asigna el/la identifier.
        /// </summary>
        /// <value>el/la identifcador.</value>
        public string Id { get; set; }

        /// <summary>
        /// Retorna o asigna el/la identifier.
        /// </summary>
        /// <value>el/la identificador del tipo de contrato.</value>
        public string IdTipoContrato { get; set; }

        /// <summary>
        /// Gets or sets the nombre.
        /// </summary>
        /// <value>
        /// The nombre.
        /// </value>
        public string Nombre { get; set; }

        /// <summary>
        /// Gets or sets the descripcion.
        /// </summary>
        /// <value>
        /// The descripcion.
        /// </value>
        public string Descripcion { get; set; }

        /// <summary>
        /// Retorna o asigna el/la identifier.
        /// </summary>
        /// <value>el/la core.</value>
        public string Core { get; set; }

        /// <summary>
        /// Retorna o asigna el/la vigente desde.
        /// </summary>
        /// <value>el/la fecha de creación.</value>
        public DateTime FechaCreacion { get; set; }

        /// <summary>
        /// Retorna o asigna el/la vigente desde.
        /// </summary>
        /// <value>el/la fecha actualización.</value>
        public DateTime FechaActualizacion { get; set; }

        /// <summary>
        /// Retorna o asigna el/la configuracion.
        /// </summary>
        /// <value>el/la vigencia.</value>
        public List<Vigencia> Vigencias { get; set; }
    }
}
