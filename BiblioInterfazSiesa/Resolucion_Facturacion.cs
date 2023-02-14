using LiloSoft.DataBase.ConectaDB;
using LiloSoft.Types.Data;
using LiloSoft.Utils;
using System.ComponentModel;

namespace LiloSoft.Siesa.Interfaz
{
    /// <summary>
    /// Resoluciones de Facturación Esculapio
    /// </summary>
    public class Resolucion_Facturacion
    {
        [DataObjectField(true)]
        public string empresa { get; set; } //   varchar(4) NOT NULLEmpresa de Trabajo
        [DataObjectField(true)]
        public string NoResolucion { get; set; } //  varchar(20) NOT NULLNo. Resolucion de Facturacion
        public Fecha FechaResolucion { get; set; } //  date NOT NULLFecha de la Resolucion
        public string Prefijo { get; set; } //  varchar(6) NULLPrefijo de la Factura
        public string Estado { get; set; } //  enum('A','I') NOT NULLEstado Activo o Inactivo
        public string NoResolucionMostrar { get; set; } //  varchar(20) NULLNumero de resolucion para morstrar en la factura
        [NoDataBase]
        public string NombreResolucion
        {
            get
            {
                return NoResolucion.IsNullOrEmpty() ? "(Seleccione Resolución)" :
                  "No. {0} Prefijo:{1} - {2}".Formato((NoResolucionMostrar.IsNullOrEmpty() ? NoResolucion : NoResolucionMostrar), Prefijo, FechaResolucion.ToString());
            }
        }
    }//fin clase
}//fin namespace
