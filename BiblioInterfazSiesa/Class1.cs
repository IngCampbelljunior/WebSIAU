using LiloSoft.Web.ProveedorWeb;
using System.ComponentModel;

namespace LiloSoft.Siesa.Interfaz
{
    class Class1
    {
        [DataObjectField(true)]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
    }
    public class Class2
    {

    }

    public class Clase3
    {

    }

    public class ExampleDB : BaseDB
    {
        public ExampleDB()
        {
            this.ComportamientoIndividualComandos = true;
            TipoComandoIndividual = TipoComando.InstruccionSQL;
        }
        public void algo()
        {
            Insert(new Class1() { Codigo = "12", Nombre = "Jorge" });
            Update(new Class1() { Codigo = "12", Nombre = "Jorge" });
            var lst = Get<Class1>();
        }
    }
}
