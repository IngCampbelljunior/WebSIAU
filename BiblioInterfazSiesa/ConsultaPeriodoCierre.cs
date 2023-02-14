using LiloSoft.Types.Data;

namespace LiloSoft.Siesa.Interfaz
{
    /// <summary>
    /// Consulta para Periodo de Cierre
    /// </summary>
    public class ConsultaPeriodoCierre
    {
        /// <summary>
        /// Código del Servicio
        /// </summary>
        public string CodServicio { get; set; }
        /// <summary>
        /// Nombre del servicio
        /// </summary>
        public string NombreServicio { get; set; }
        /// <summary>
        /// Código de la Dependencia
        /// </summary>
        public string CodDependencia { get; set; }
        /// <summary>
        /// Nombre de la Dependencia
        /// </summary>
        public string NombreDependencia { get; set; }
        /// <summary>
        /// Valor de la Venta
        /// </summary>
        public Moneda ValorVenta { get; set; }
    }//fin clase
}//fin namespace
