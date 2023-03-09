using System.ComponentModel;

namespace Helpers.Commons.Exceptions
{
    /// <summary>
    /// ResponseError
    /// </summary>
    public enum TipoExcepcionNegocio
    {
        /// <summary>
        /// Tipo de exception no controlada
        /// </summary>
        [Description("Excepción de negocio no controlada")]
        ExceptionNoControlada = 555,

        /// <summary>
        /// El tipo de contrato especificado no existe.
        /// </summary>
        [Description("El tipo de contrato especificado no existe.")]
        ErrorNoExisteTipoContrato = 556,

        /// <summary>
        /// El tipo de contrato especificado ya existe
        /// </summary>
        [Description("El tipo de contrato especificado ya existe")]
        ErrorExisteTipoContrato = 557,

        /// <summary>
        /// ¡El esquema del tipo de contrato no existe!
        /// </summary>
        [Description("¡El esquema del tipo de contrato no existe!")]
        ErrorNoExisteExquemaTipoContrato = 558,

        /// <summary>
        /// Caracter invalido en el archivo "Referencia a objeto no establecida como instancia de un objeto."
        /// </summary>
        [Description("La variable a remplazar no esta definida")]
        ErrorCaracterArchivo = 559,

        /// <summary>
        /// Error no controlado al insertar un tipo de contrato
        /// </summary>
        [Description("Error no controlado al insertar un tipo de contrato")]
        ErrorAlInsertarTipoContrato = 560,

        /// <summary>
        /// Error no controlado al insertar una vigencia
        /// </summary>
        [Description("Error no controlado al insertar una vigencia")]
        ErrorAlInsertarVigencia = 561,

        /// <summary>
        /// Excepción al intentar obtener datos de mongo
        /// </summary>
        [Description("Excepción al intentar obtener datos de mongo")]
        ExceptionAlIntentarObtenerDatosDeMongo = 562,

        /// <summary>
        /// No se cumple con el esquema definido para la colección Tipos Contrato
        /// </summary>
        [Description("No se cumple con el esquema definido para la colección Tipos Contrato")]
        ErrorAlCrearTipoContratoNoCumpleEsquema = 563,

        /// <summary>
        /// No se puede crear una vigencia con una fecha/hora anterior a la actual
        /// </summary>
        [Description("No se puede crear una vigencia con una fecha/hora anterior a la actual")]
        ErrorAlCrearVigenciaConFechaAnteriorAlaActual = 564,

        /// <summary>
        /// No se puede modificar una vigencia con una fecha/hora anterior a la actual
        /// </summary>
        [Description("No se puede modificar una vigencia con una fecha/hora anterior a la actual")]
        ErrorAlModificarVigenciaConFechaAnteriorAlaActual = 565,

        /// <summary>
        /// No existen registros en mongo, para recargar
        /// </summary>
        [Description("No existen registros en mongo, para recargar.")]
        ErrorDataMongo = 566,

        /// <summary>
        /// No se cumple con el esquema definido para la colección de Vigencias
        /// </summary>
        [Description("No se cumple con el esquema definido para la colección Vigencias")]
        ErrorAlCrearTipoContratoVigenciaNoCumpleEsquema = 567,

        /// <summary>
        /// El nombre del Core no existe, por favor registrelo
        /// </summary>
        [Description("El nombre del Core no existe, por favor registrelo")]
        ErrorNoExisteCoreTipoContrato = 568,

        /// <summary>
        /// El campo IdTipoContrato es obligatorio
        /// </summary>
        [Description("El campo IdTipoContrato es obligatorio")]
        ErrorIdTipoContratoNulo = 569,

        /// <summary>
        /// Tiempo de respuesta excedido para responder
        /// </summary>
        [Description("Tiempo de respuesta excedido para responder")]
        ErrorTiempoExcedido = 570,

        /// <summary>
        /// Error No Existe Una Configuracion Vigente Para El Tipo De Contrato
        /// </summary>
        [Description("Error No Existe Una Configuracion Vigente Para El Tipo De Contrato")]
        ErrorNoExisteUnaConfiguracionVigenteParaElTipoDeContrato = 1010,

        /// <summary>
        /// The origen requerido
        /// </summary>
        [Description("El origen es requerido")]
        OrigenRequerido = 1011,

        /// <summary>
        /// The identifier transaccion original requerido
        /// </summary>
        [Description("El IdTransaccionOriginal es requerido")]
        IdTransaccionOriginalRequerido = 1012,

        /// <summary>
        /// The descripcion requerida
        /// </summary>
        [Description("La Descripcion es requerida")]
        DescripcionRequerida = 1013,

        /// <summary>
        /// The nombre diario contable requerida
        /// </summary>
        [Description("El Nombre Diario Contable es requerido")]
        NombreDiarioContableRequerida = 1014,

        /// <summary>
        /// The codigo tipo transaccion requerida
        /// </summary>
        [Description("El Codigo Tipo Transaccion es requerido")]
        CodigoTipoTransaccionRequerida = 1015,

        /// <summary>
        /// The codigo tipo linea requerida
        /// </summary>
        [Description("El Codigo Tipo Linea es requerido")]
        CodigoTipoLineaRequerida = 1016,

        /// <summary>
        /// The datos requerida
        /// </summary>
        [Description("Se debe enviar un dato en Datos")]
        DatosRequerida = 1017,

        /// <summary>
        /// The nombre requerido
        /// </summary>
        [Description("El nombre es requerido")]
        NombreRequerido = 1018,

        /// <summary>
        /// The descripcion diario contable requerida
        /// </summary>
        [Description("La Descripcion Diario Contable es requerida")]
        DescripcionDiarioContableRequerida = 1019,

        /// <summary>
        /// The tipo diario contable requerido
        /// </summary>
        [Description("El tipo diario contable es requerido")]
        TipoDiarioContableRequerido = 1020,

        /// <summary>
        /// Todas las variables marcadas para acumular deben ser numéricas
        /// </summary>
        [Description("Todas las variables marcadas para acumular deben ser numéricas")]
        AcumulacionNoNumerica = 1021,

        /// <summary>
        /// The limite lineas diario contable requerido
        /// </summary>
        [Description("El limite lineas diario contable es requerido")]
        LimiteLineasDiarioContableRequerido = 2021,

        /// <summary>
        /// The nombre tipo linea requerida
        /// </summary>
        [Description("El Nombre tipo lineas diario contable es requerido")]
        NombreTipoLineaRequerida = 2022,

        /// <summary>
        /// The descripcion tipo linea requerida
        /// </summary>
        [Description("La descripcion tipo lineas diario contable es requerida")]
        DescripcionTipoLineaRequerida = 2023,

        /// <summary>
        /// No existe el tipo de Transaccion
        /// </summary>
        [Description("No existe el Tipo de Transaccion")]
        NoExisteElTipoDeTransaccion = 2024,

        /// <summary>
        /// Conceptos de la transaccion no compensados
        /// </summary>
        [Description("Los conceptos de una variable no están compensados.")]
        ConceptosDeUnaVariableNoEstanCompensadas = 026
    }
}