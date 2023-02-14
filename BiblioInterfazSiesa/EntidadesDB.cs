using LiloSoft.DataBase.ConectaDB;
using LiloSoft.Utils;
using LiloSoft.Web.ProveedorWeb;
using System.Collections.Generic;
using System.Data;

namespace LiloSoft.Siesa.Interfaz
{
    public class EntidadesDB : BaseDB
    {
        #region Constructores
        /// <summary>
        /// Constructor por Defecto
        /// </summary>
        public EntidadesDB() : base()
        {
            ComportamientoIndividualComandos = true;
            TipoComandoIndividual = LiloSoft.Web.ProveedorWeb.TipoComando.InstruccionSQL;
        }
        /// <summary>
        /// Constructor con Objeto de Acceso a Datos
        /// </summary>
        /// <param name="pSqlDb"></param>
        public EntidadesDB(DB pSqlDb) : this()
        {
            this.SqlDb = pSqlDb;
        }
        #endregion

        #region Métodos de Acceso a Datos
#pragma warning disable CS0436 // El tipo 'Entidades' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs' está en conflicto con el tipo importado 'Entidades' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs'.
        public List<Entidades> GetEntidades(string Criterio, string Empresa)
#pragma warning restore CS0436 // El tipo 'Entidades' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs' está en conflicto con el tipo importado 'Entidades' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs'.
        {
            var lstParam = new List<Parametro>();
            lstParam.AddParametro("Empresa", Empresa);
            var sqlText = "";
            if (string.IsNullOrEmpty(Criterio))
            {
#pragma warning disable CS0436 // El tipo 'Entidades' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs' está en conflicto con el tipo importado 'Entidades' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs'.
                sqlText = GetInstruccionSql<Entidades>(TiposProcedimientosAlmacenados.Activo);
#pragma warning restore CS0436 // El tipo 'Entidades' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs' está en conflicto con el tipo importado 'Entidades' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs'.
            }
            else
            {
#pragma warning disable CS0436 // El tipo 'Entidades' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs' está en conflicto con el tipo importado 'Entidades' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs'.
                sqlText = GetInstruccionSql<Entidades>(TiposProcedimientosAlmacenados.CriterioActivos);
#pragma warning restore CS0436 // El tipo 'Entidades' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs' está en conflicto con el tipo importado 'Entidades' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs'.
                lstParam.AddParametro("Criterio", Criterio);

            }
#pragma warning disable CS0436 // El tipo 'Entidades' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs' está en conflicto con el tipo importado 'Entidades' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs'.
            var lista = ExecuteGetLista<Entidades>(sqlText, EsProcedimientoAlmacenado, lstParam.ToArray());
#pragma warning restore CS0436 // El tipo 'Entidades' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs' está en conflicto con el tipo importado 'Entidades' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs'.
            return lista;

        }
        #endregion

        #region Listas de Valores
        /// <summary>
        /// Lista de Valores de las EstadosTrazabilidad por Criterio
        /// </summary>
        /// <param name="criterio">Criterio de Busqueda</param>
        /// <param name="parametros">Lista de Parametros</param>
        /// <returns></returns>
        public override DataTable GetLista(string criterio, List<LiloSoft.Web.ProveedorWeb.LOVParams> parametros)
        {
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
            EmpresaConeccion emp = null;
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
            var empresa = parametros.ValorParametro<string>("Empresa");
#pragma warning disable CS0436 // El tipo 'ConsultaInstitucionDB' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaInstitucionDB.cs' está en conflicto con el tipo importado 'ConsultaInstitucionDB' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaInstitucionDB.cs'.
            var SqlDbMysql = ConsultaInstitucionDB.ObtenerBaseMySqL(empresa, SqlDb, ref emp);
#pragma warning restore CS0436 // El tipo 'ConsultaInstitucionDB' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaInstitucionDB.cs' está en conflicto con el tipo importado 'ConsultaInstitucionDB' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaInstitucionDB.cs'.
            var EmpresaEsculapio = emp.EmpresaEsculapio;
#pragma warning disable CS0436 // El tipo 'EntidadesDB' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EntidadesDB.cs' está en conflicto con el tipo importado 'EntidadesDB' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EntidadesDB.cs'.
            var dataDb = new EntidadesDB(SqlDbMysql);
#pragma warning restore CS0436 // El tipo 'EntidadesDB' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EntidadesDB.cs' está en conflicto con el tipo importado 'EntidadesDB' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EntidadesDB.cs'.
#pragma warning disable CS0436 // El tipo 'Entidades' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs' está en conflicto con el tipo importado 'Entidades' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs'.
            return Tablas<Entidades>.ToDataTable(dataDb.GetEntidades(criterio, EmpresaEsculapio));
#pragma warning restore CS0436 // El tipo 'Entidades' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs' está en conflicto con el tipo importado 'Entidades' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs'.
        }

        /// <summary>
        /// Lista de Valores de las EstadosTrazabilidad por Criterio Activos
        /// </summary>
        /// <param name="criterio">Criterio de Busqueda</param>
        /// <param name="parametros">Lista de Parametros</param>
        /// <returns></returns>
        public override DataTable GetListaActiva(string criterio, List<LiloSoft.Web.ProveedorWeb.LOVParams> parametros)
        {

            return GetLista(criterio, parametros);
        }

        #endregion

    }//fin clase
}//fin namespace
