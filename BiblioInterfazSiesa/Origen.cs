using System.ComponentModel;

namespace LiloSoft.Siesa.Interfaz
{
    public class Origen
    {
        [DataObjectField(true)]
        public string Empresa { get; set; }
        [DataObjectField(true)]
        public string origen { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
    }//fin clase
}//fin namespace
