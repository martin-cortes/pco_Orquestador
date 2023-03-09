using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Model.Interfaces
{
    public interface IAdapterCache
    {
        /// <summary>
        /// Obtener el tipo transaccion asincrónicamente.
        /// </summary>
        /// <param name="idTipoContrato">The identifier tipo contrato.</param>
        /// <param name="fechaTransaccion">The fecha transaccion.</param>
        /// <returns></returns>
        Task<T> ObtenerConfiguracion<T>(string idTipoContrato, DateTime fechaTransaccion = default);
    }
}
