using LiloSoft.DataBase.ConectaDB;
using System.ComponentModel;

namespace LiloSoft.Siesa.Interfaz
{
    [TableName("Empresa")]
    public class EmpresaEsculapioIps
    {
        [DataObjectField(true)]
        public string empresa { get; set; }
        public string Nombre_Empresa { get; set; }
        public string Nit { get; set; }
        public string Ciudad { get; set; }
        public string CodHabilitacion { get; set; }
        public string CodPrestador { get; set; }
        public string NombreComercial { get; set; }
        [NoDataBase]
        public string NombreEmpresaCompleto => $"{Nombre_Empresa} {NombreComercial}";

        [NoDataBase]
        public string NombreEmpresaExtendido => $"{empresa}-{NombreEmpresaCompleto}";

    }
}
