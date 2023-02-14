using LiloSoft.Utils;
using System.ComponentModel;

namespace LiloSoft.Siesa.Interfaz
{
    /// <summary>
    /// Dependencias de la Institución
    /// </summary>
    public class Dependencias
    {
        [DataObjectField(true)]
        public string CodDependencia { get; set; }

        public string NomDependecia { get; set; }

        public string NomDependeciaExtendido
        {
            get { return "{0} - {1}".Formato(CodDependencia, NomDependecia); }
        }
        public string Estado { get; set; }
    }//fin clase
}//fin namespace
