using LiloSoft.DataBase.ConectaDB;
using LiloSoft.Types.Data;

namespace LiloSoft.Siesa.Interfaz
{
    public class ResumenVentasNoFacturadas
    {
        [BooleanEquivalent("S", "N")]
        public bool UtilizarNitFactura { get; set; }
        public string NitEndidad { get; set; }
        public string CodServicio { get; set; }
        public string CodDependencia { get; set; }
        public Moneda ValorVenta { get; set; }
    }
}
