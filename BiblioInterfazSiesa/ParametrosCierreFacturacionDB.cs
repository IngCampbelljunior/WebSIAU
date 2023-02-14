using LiloSoft.DataBase.ConectaDB;
using LiloSoft.Web.ProveedorWeb;
using System.Collections.Generic;

namespace LiloSoft.Siesa.Interfaz
{
    public class ParametrosCierreFacturacionDB : BaseDB
    {
        #region Constructores
        public ParametrosCierreFacturacionDB()
        {
            ComportamientoIndividualComandos = true;
            TipoComandoIndividual = TipoComando.InstruccionSQL;
        }

        public ParametrosCierreFacturacionDB(DB pSQLDb)
          : this()
        {
            SqlDb = pSQLDb;
        }

        #endregion



#pragma warning disable CS0436 // El tipo 'ParametrosCierreFacturacion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosCierreFacturacion.cs' está en conflicto con el tipo importado 'ParametrosCierreFacturacion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosCierreFacturacion.cs'.
        public ParametrosCierreFacturacion GetUnParametrosCierreFacturacion(string Empresa)
#pragma warning restore CS0436 // El tipo 'ParametrosCierreFacturacion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosCierreFacturacion.cs' está en conflicto con el tipo importado 'ParametrosCierreFacturacion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosCierreFacturacion.cs'.
        {
#pragma warning disable CS0436 // El tipo 'ParametrosCierreFacturacion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosCierreFacturacion.cs' está en conflicto con el tipo importado 'ParametrosCierreFacturacion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosCierreFacturacion.cs'.
            var sql = GetSelect<ParametrosCierreFacturacion>();
#pragma warning restore CS0436 // El tipo 'ParametrosCierreFacturacion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosCierreFacturacion.cs' está en conflicto con el tipo importado 'ParametrosCierreFacturacion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosCierreFacturacion.cs'.
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", Empresa);
#pragma warning disable CS0436 // El tipo 'ParametrosCierreFacturacion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosCierreFacturacion.cs' está en conflicto con el tipo importado 'ParametrosCierreFacturacion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosCierreFacturacion.cs'.
            return ExecuteGetUnLista<ParametrosCierreFacturacion>(sql, false, lstPars.ToArray());
#pragma warning restore CS0436 // El tipo 'ParametrosCierreFacturacion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosCierreFacturacion.cs' está en conflicto con el tipo importado 'ParametrosCierreFacturacion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosCierreFacturacion.cs'.
        }

    }
}
