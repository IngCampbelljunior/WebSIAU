using LiloSoft.Types.Data;

namespace LiloSoft.Siesa.Interfaz
{
    /// <summary>
    /// Resultado del Cierre de Facturación
    /// </summary>
    public class CierreFacturacionResultado
    {
        public Fecha FechaInicial { get; set; }
        public Fecha FechaFinal { get; set; }
        public string PeriodoCierre { get; set; }
        public Moneda TotalVenta { get; set; }

    }//fin clase
}//fin namespace
