using LiloSoft.Types.Data;

namespace LiloSoft.Siesa.Interfaz
{
    /// <summary>
    /// Representa las Facturas de un Control de Cargue
    /// </summary>
    public class FacturasControl
    {
        public string NoFactura { get; set; }
        public string NoCuenta { get; set; }
        public string NitEntidad { get; set; }
        public string CodConvenio { get; set; }
        public Fecha Fecha_Emision { get; set; }
        public Fecha Fecha_Radicacion { get; set; }
    }
}
