using LiloSoft.Types.Data;
using System.ComponentModel;

namespace LiloSoft.Siesa.Interfaz
{
    /// <summary>
    /// Parámetros Generales Cierre de Facturación
    /// </summary>

    public class ParametrosCierreFacturacion
    {
        /// <summary>
        /// Empresa de Trabajo
        /// </summary>
        [DataObjectField(true)]
        public string Empresa { get; set; }
        /// <summary>
        /// Fecha del Primer Cierre
        /// </summary>
        public Fecha FechaPrimerCierre { get; set; }
        /// <summary>
        /// Fecha del Ultimo Cierre
        /// </summary>
        public Fecha FechaUltimoCierre { get; set; }
        /// <summary>
        /// Periodo del Primer Cierre
        /// </summary>
        public string PeriodoPrimerCierre { get; set; }
        public string PeriodoUltimoCierre { get; set; }
    }
}
