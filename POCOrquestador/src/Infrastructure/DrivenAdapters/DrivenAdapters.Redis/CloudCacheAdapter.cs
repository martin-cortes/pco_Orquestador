using Domain.Model.Entities.Configuracion;
using Domain.Model.Interfaces;
using Helpers.Commons.Exceptions;
using Helpers.ObjectsUtils.Extensions;
using Newtonsoft.Json;
using StackExchange.Redis;
using System.Runtime.InteropServices;

namespace DrivenAdapters.Redis
{
    public class CloudCacheAdapter : IAdapterCache
    {
        private readonly IDatabase _database;

        public CloudCacheAdapter(IDatabase database)
        {
            _database = database;
        }

        public async Task<T?> ObtenerConfiguracion<T>(string idTipoContrato, DateTime fechaTransaccion = default)
        {
            T? configuracion = default;
            string? contratoResponse = await _database.StringGetAsync(idTipoContrato);
            fechaTransaccion = fechaTransaccion == default ? DateTime.UtcNow : fechaTransaccion;

            if (!string.IsNullOrEmpty(contratoResponse))
            {
                TipoContrato tipoContrato = JsonConvert.DeserializeObject<TipoContrato>(contratoResponse);

                // Buscamos la vigencia que aplique para la fecha de la transaccion
                Vigencia vigencia = ObtenerVigenciaConfiguracionActual(tipoContrato.Vigencias, fechaTransaccion)
                    ?? throw new CoreException(TipoExcepcionNegocio.ErrorNoExisteUnaConfiguracionVigenteParaElTipoDeContrato.GetDescription(),
                    (int)TipoExcepcionNegocio.ErrorNoExisteUnaConfiguracionVigenteParaElTipoDeContrato);

                configuracion = JsonConvert.DeserializeObject<T>(vigencia.Configuracion);
            }

            return configuracion;
        }

        /// <summary>
        /// Obtener la vigencia actual de una configuracion .
        /// </summary>
        /// <param name="vigencia">The tipo contrato.</param>
        /// <param name="fechaTransaccion"></param>
        /// <returns></returns>
        private static Vigencia? ObtenerVigenciaConfiguracionActual(List<Vigencia> vigencia, DateTime fechaTransaccion)
        {
            return vigencia
                   .Where(v => v.VigenteDesde <= fechaTransaccion)?
                   .OrderByDescending(t => t.VigenteDesde)
                   .FirstOrDefault();
        }
    }
}