using LiloSoft.DataBase.ConectaDB;
using LiloSoft.Types.Data;
using LiloSoft.Utils;
using LiloSoft.Web.ProveedorWeb;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiloSoft.Siesa.Interfaz
{
    public class ConsultaInstitucionDB : BaseDB
    {
        #region Contructores
        /// <summary>
        /// Constructor por Defecto
        /// </summary>
        public ConsultaInstitucionDB()
        {
            ComportamientoIndividualComandos = true;
            TipoComandoIndividual = TipoComando.InstruccionSQL;
        }

        /// <summary>
        /// Constructo con Objeto de Acceso a Datos
        /// </summary>
        /// <param name="pSqlDb"></param>
        public ConsultaInstitucionDB(DB pSqlDb) : this()
        {
            SqlDb = pSqlDb;
        }
        #endregion

        /// <summary>
        /// Dependencias Activas de la Institución
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo</param>
        /// <returns>Lista de Dependencias</returns>
#pragma warning disable CS0436 // El tipo 'Dependencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Dependencias.cs' está en conflicto con el tipo importado 'Dependencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Dependencias.cs'.
        public List<Dependencias> GetDependencias(string Empresa)
#pragma warning restore CS0436 // El tipo 'Dependencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Dependencias.cs' está en conflicto con el tipo importado 'Dependencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Dependencias.cs'.
        {
            var lstParams = new List<Parametro>();
            lstParams.AddParametro("Empresa", Empresa);
#pragma warning disable CS0436 // El tipo 'Dependencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Dependencias.cs' está en conflicto con el tipo importado 'Dependencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Dependencias.cs'.
            var sql = new StringBuilder(GetSelectAll<Dependencias>(false));
#pragma warning restore CS0436 // El tipo 'Dependencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Dependencias.cs' está en conflicto con el tipo importado 'Dependencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Dependencias.cs'.
            sql.AppendLine(@" Where Empresa = :Empresa and Estado = 'A' and
    ( Servicios = 'S'  Or
      ( Servicios = 'N' and CodDependencia = (Select DependenciaExterna 
                     From Parametros_Facturacion Where Empresa = :Empresa ) 
      ) 
    )    
Order by 2");
#pragma warning disable CS0436 // El tipo 'Dependencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Dependencias.cs' está en conflicto con el tipo importado 'Dependencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Dependencias.cs'.
            return ExecuteGetLista<Dependencias>(sql.ToString(), false, lstParams.ToArray());
#pragma warning restore CS0436 // El tipo 'Dependencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Dependencias.cs' está en conflicto con el tipo importado 'Dependencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Dependencias.cs'.
        }

        /// <summary>
        /// Servicios Activos de la Institución
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo</param>
        /// <returns>Lista de Servicios_Clinica</returns>
#pragma warning disable CS0436 // El tipo 'Servicios_Clinica' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Servicios_Clinica.cs' está en conflicto con el tipo importado 'Servicios_Clinica' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Servicios_Clinica.cs'.
        public List<Servicios_Clinica> GetServiciosClinica(string Empresa)
#pragma warning restore CS0436 // El tipo 'Servicios_Clinica' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Servicios_Clinica.cs' está en conflicto con el tipo importado 'Servicios_Clinica' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Servicios_Clinica.cs'.
        {
            var lstParams = new List<Parametro>();
            lstParams.AddParametro("Empresa", Empresa);
#pragma warning disable CS0436 // El tipo 'Servicios_Clinica' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Servicios_Clinica.cs' está en conflicto con el tipo importado 'Servicios_Clinica' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Servicios_Clinica.cs'.
            var sql = new StringBuilder(GetSelectAll<Servicios_Clinica>(false));
#pragma warning restore CS0436 // El tipo 'Servicios_Clinica' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Servicios_Clinica.cs' está en conflicto con el tipo importado 'Servicios_Clinica' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Servicios_Clinica.cs'.
            sql.AppendLine(" Where Empresa = :Empresa and Estado = 'A' Order by 2");
#pragma warning disable CS0436 // El tipo 'Servicios_Clinica' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Servicios_Clinica.cs' está en conflicto con el tipo importado 'Servicios_Clinica' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Servicios_Clinica.cs'.
            return ExecuteGetLista<Servicios_Clinica>(sql.ToString(), false, lstParams.ToArray());
#pragma warning restore CS0436 // El tipo 'Servicios_Clinica' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Servicios_Clinica.cs' está en conflicto con el tipo importado 'Servicios_Clinica' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Servicios_Clinica.cs'.
        }

        public object GetUnCasoEsculapio(string empresa, object noCuenta)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Origenes de la Institución
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo</param>
        /// <returns>Lista de Origen</returns>
#pragma warning disable CS0436 // El tipo 'Origen' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Origen.cs' está en conflicto con el tipo importado 'Origen' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Origen.cs'.
        public List<Origen> GetOrigenesClinica(string Empresa)
#pragma warning restore CS0436 // El tipo 'Origen' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Origen.cs' está en conflicto con el tipo importado 'Origen' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Origen.cs'.
        {
            var lstParams = new List<Parametro>();
            lstParams.AddParametro("Empresa", Empresa);
#pragma warning disable CS0436 // El tipo 'Origen' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Origen.cs' está en conflicto con el tipo importado 'Origen' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Origen.cs'.
            var sql = new StringBuilder(GetSelectAll<Origen>(false));
#pragma warning restore CS0436 // El tipo 'Origen' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Origen.cs' está en conflicto con el tipo importado 'Origen' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Origen.cs'.
            sql.AppendLine(" Where Empresa = :Empresa and Estado = 'A' Order by 2");
#pragma warning disable CS0436 // El tipo 'Origen' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Origen.cs' está en conflicto con el tipo importado 'Origen' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Origen.cs'.
            return ExecuteGetLista<Origen>(sql.ToString(), false, lstParams.ToArray());
#pragma warning restore CS0436 // El tipo 'Origen' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Origen.cs' está en conflicto con el tipo importado 'Origen' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Origen.cs'.
        }

#pragma warning disable CS0436 // El tipo 'Entidades' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs' está en conflicto con el tipo importado 'Entidades' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs'.
        public Entidades GetUnEntidades(string Empresa, string NitEntidad)
#pragma warning restore CS0436 // El tipo 'Entidades' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs' está en conflicto con el tipo importado 'Entidades' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs'.
        {
#pragma warning disable CS0436 // El tipo 'Entidades' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs' está en conflicto con el tipo importado 'Entidades' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs'.
            var sql = GetSelect<Entidades>();
#pragma warning restore CS0436 // El tipo 'Entidades' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs' está en conflicto con el tipo importado 'Entidades' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs'.
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", Empresa);
            lstPars.AddParametro("NitEntidad", NitEntidad);
#pragma warning disable CS0436 // El tipo 'Entidades' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs' está en conflicto con el tipo importado 'Entidades' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs'.
            return ExecuteGetUnLista<Entidades>(sql, false, lstPars.ToArray());
#pragma warning restore CS0436 // El tipo 'Entidades' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs' está en conflicto con el tipo importado 'Entidades' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Entidades.cs'.
        }

#pragma warning disable CS0436 // El tipo 'EmpresaEsculapioIps' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaEsculapioIps.cs' está en conflicto con el tipo importado 'EmpresaEsculapioIps' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaEsculapioIps.cs'.
        public EmpresaEsculapioIps GetUnEmpresaEsculapioIps(string Empresa)
#pragma warning restore CS0436 // El tipo 'EmpresaEsculapioIps' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaEsculapioIps.cs' está en conflicto con el tipo importado 'EmpresaEsculapioIps' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaEsculapioIps.cs'.
        {
            var sql = "GetEmpresaEsculapio";//GetSelect<EmpresaEsculapioIps>();
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", Empresa);
#pragma warning disable CS0436 // El tipo 'EmpresaEsculapioIps' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaEsculapioIps.cs' está en conflicto con el tipo importado 'EmpresaEsculapioIps' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaEsculapioIps.cs'.
            return ExecuteGetUnLista<EmpresaEsculapioIps>(sql, true, lstPars.ToArray());
#pragma warning restore CS0436 // El tipo 'EmpresaEsculapioIps' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaEsculapioIps.cs' está en conflicto con el tipo importado 'EmpresaEsculapioIps' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaEsculapioIps.cs'.
        }

        /// <summary>
        /// Obtener las Empresas del Usuario
        /// </summary>
        /// <param name="Usuario">Nombre del Usuario</param>
        /// <returns>Lista de Empresas</returns>
#pragma warning disable CS0436 // El tipo 'EmpresaEsculapioIps' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaEsculapioIps.cs' está en conflicto con el tipo importado 'EmpresaEsculapioIps' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaEsculapioIps.cs'.
        public List<EmpresaEsculapioIps> GetEmpresaEsculapioUsuario(string Usuario)
#pragma warning restore CS0436 // El tipo 'EmpresaEsculapioIps' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaEsculapioIps.cs' está en conflicto con el tipo importado 'EmpresaEsculapioIps' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaEsculapioIps.cs'.
        {
            var sql = "GetUsuariosEmpresa";
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("Usuario", Usuario);
#pragma warning disable CS0436 // El tipo 'EmpresaEsculapioIps' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaEsculapioIps.cs' está en conflicto con el tipo importado 'EmpresaEsculapioIps' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaEsculapioIps.cs'.
            return ExecuteGetLista<EmpresaEsculapioIps>(sql, true, lstPars.ToArray());
#pragma warning restore CS0436 // El tipo 'EmpresaEsculapioIps' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaEsculapioIps.cs' está en conflicto con el tipo importado 'EmpresaEsculapioIps' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaEsculapioIps.cs'.
        }

#pragma warning disable CS0436 // El tipo 'EmpresasWeb' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresasWeb.cs' está en conflicto con el tipo importado 'EmpresasWeb' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresasWeb.cs'.
        public List<EmpresasWeb> Get_EmpresasWeb()
#pragma warning restore CS0436 // El tipo 'EmpresasWeb' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresasWeb.cs' está en conflicto con el tipo importado 'EmpresasWeb' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresasWeb.cs'.
        {
            string sql = "Get_EmpresasWeb";
            List<Parametro> lstPars = new List<Parametro>();
#pragma warning disable CS0436 // El tipo 'EmpresasWeb' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresasWeb.cs' está en conflicto con el tipo importado 'EmpresasWeb' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresasWeb.cs'.
            return base.ExecuteGetLista<EmpresasWeb>(sql, true, null);
#pragma warning restore CS0436 // El tipo 'EmpresasWeb' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresasWeb.cs' está en conflicto con el tipo importado 'EmpresasWeb' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresasWeb.cs'.
        }

#pragma warning disable CS0436 // El tipo 'EmpresasWeb' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresasWeb.cs' está en conflicto con el tipo importado 'EmpresasWeb' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresasWeb.cs'.
        public List<EmpresasWeb> Get_UnaEmpresasWeb(string codEmpresa)
#pragma warning restore CS0436 // El tipo 'EmpresasWeb' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresasWeb.cs' está en conflicto con el tipo importado 'EmpresasWeb' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresasWeb.cs'.
        {
            string sql = string.Concat("Select a.Empresa, b.EmpresaEsculapio, a.NombreEmpresa, b.Servidor,b.Puerto,b.BaseDatos ", "From Empresas a Inner Join EmpresaConeccion b On a.empresa = b.Empresa ");
            sql = string.Concat(sql, "Where b.Empresa = :codEmpresa and a.Estado = 'A'");
            List<Parametro> lstParams = new List<Parametro>();
            lstParams.AddParametro("codEmpresa", codEmpresa);
#pragma warning disable CS0436 // El tipo 'EmpresasWeb' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresasWeb.cs' está en conflicto con el tipo importado 'EmpresasWeb' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresasWeb.cs'.
            return base.ExecuteGetLista<EmpresasWeb>(sql, false, lstParams.ToArray());
#pragma warning restore CS0436 // El tipo 'EmpresasWeb' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresasWeb.cs' está en conflicto con el tipo importado 'EmpresasWeb' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresasWeb.cs'.
        }

#pragma warning disable CS0436 // El tipo 'Convenios' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Convenios.cs' está en conflicto con el tipo importado 'Convenios' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Convenios.cs'.
        public Convenios GetUnConvenio(string Empresa, string CodConvenio)
#pragma warning restore CS0436 // El tipo 'Convenios' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Convenios.cs' está en conflicto con el tipo importado 'Convenios' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Convenios.cs'.
        {
#pragma warning disable CS0436 // El tipo 'Convenios' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Convenios.cs' está en conflicto con el tipo importado 'Convenios' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Convenios.cs'.
            var sql = GetSelect<Convenios>();
#pragma warning restore CS0436 // El tipo 'Convenios' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Convenios.cs' está en conflicto con el tipo importado 'Convenios' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Convenios.cs'.
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", Empresa);
            lstPars.AddParametro("Cod_Convenio", CodConvenio);
#pragma warning disable CS0436 // El tipo 'Convenios' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Convenios.cs' está en conflicto con el tipo importado 'Convenios' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Convenios.cs'.
            return ExecuteGetUnLista<Convenios>(sql, false, lstPars.ToArray());
#pragma warning restore CS0436 // El tipo 'Convenios' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Convenios.cs' está en conflicto con el tipo importado 'Convenios' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Convenios.cs'.
        }

        public bool ExisteFactura(string Empresa, string NoFactura)
        {
            var resp = true;
            var sql = "Select NoFactura From Facturas Where Empresa = :Empresa and NoFactura = :NoFactura";
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", Empresa);
            lstPars.AddParametro("NoFactura", NoFactura);
            var dt = SqlDb.EjecutarConsulta(sql, false, lstPars.ToArray());
            if (dt == null && SqlDb.UltimaExcepcion != null) throw SqlDb.UltimaExcepcion;
            if (dt != null && dt.Rows.Count == 0)
                resp = false;
            return resp;
        }

#pragma warning disable CS0436 // El tipo 'DetalleFacturas' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\DetalleFacturas.cs' está en conflicto con el tipo importado 'DetalleFacturas' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\DetalleFacturas.cs'.
        public List<DetalleFacturas> GetInterfazFacturas(
#pragma warning restore CS0436 // El tipo 'DetalleFacturas' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\DetalleFacturas.cs' está en conflicto con el tipo importado 'DetalleFacturas' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\DetalleFacturas.cs'.
             string Empresa, // Empresa 
       string TipoFechas, // Tipo de Fechas E:Emisión R:Radicación
       string TipoFactura, // Facturas a Traer T: Todas las Facturas U:Una Factura 
                           // N: De un Responsable, C:Convenio,  A:Anuladas
       string ProcesarMarcadas, // Procesar Marcadas S:Sí o N:No
       Fecha FechaInicial, // -- Fecha Inicial
       Fecha FechaFinal, // Fecha Final
       string NoFactura, // -- No. de Factura a Buscar
       string NitEntidad, // -- Nit de la Entidad a Buscar	
       string CodConvenio //-- Código del Convenio a Buscar
           )
        {
            var sql = "GetFacturasInterfaz";
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", Empresa);
            lstPars.AddParametro("TipoFechas", TipoFechas);
            lstPars.AddParametro("TipoFactura", TipoFactura);
            lstPars.AddParametro("ProcesarMarcadas", ProcesarMarcadas);
            lstPars.AddParametro("FechaInicial", FechaInicial);
            lstPars.AddParametro("FechaFinal", FechaFinal);
            lstPars.AddParametro("NoFactura", NoFactura);
            lstPars.AddParametro("NitEntidad", NitEntidad);
            lstPars.AddParametro("CodConvenio", CodConvenio);
#pragma warning disable CS0436 // El tipo 'DetalleFacturas' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\DetalleFacturas.cs' está en conflicto con el tipo importado 'DetalleFacturas' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\DetalleFacturas.cs'.
            return ExecuteGetLista<DetalleFacturas>(sql, true, lstPars.ToArray());
#pragma warning restore CS0436 // El tipo 'DetalleFacturas' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\DetalleFacturas.cs' está en conflicto con el tipo importado 'DetalleFacturas' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\DetalleFacturas.cs'.
        }

        /// <summary>
        /// Detalle de Glosas para Interfaz con S1ESA
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo</param>
        /// <param name="FechaInicial">Fecha Inicial</param>
        /// <param name="FechaFinal">Fecha Final</param>
        /// <returns></returns>
#pragma warning disable CS0436 // El tipo 'GlosasDetalle' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\GlosasDetalle.cs' está en conflicto con el tipo importado 'GlosasDetalle' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\GlosasDetalle.cs'.
        public List<GlosasDetalle> GetInterfazGlosas(string Empresa, Fecha FechaInicial, Fecha FechaFinal)
#pragma warning restore CS0436 // El tipo 'GlosasDetalle' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\GlosasDetalle.cs' está en conflicto con el tipo importado 'GlosasDetalle' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\GlosasDetalle.cs'.
        {
            var sql = "GetGlosasInterfaz";
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", Empresa);
            lstPars.AddParametro("FechaInicial", FechaInicial);
            lstPars.AddParametro("FechaFinal", FechaFinal);
#pragma warning disable CS0436 // El tipo 'GlosasDetalle' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\GlosasDetalle.cs' está en conflicto con el tipo importado 'GlosasDetalle' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\GlosasDetalle.cs'.
            return ExecuteGetLista<GlosasDetalle>(sql, true, lstPars.ToArray());
#pragma warning restore CS0436 // El tipo 'GlosasDetalle' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\GlosasDetalle.cs' está en conflicto con el tipo importado 'GlosasDetalle' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\GlosasDetalle.cs'.

        }

#pragma warning disable CS0436 // El tipo 'CuentaEsculapio' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CuentaEsculapio.cs' está en conflicto con el tipo importado 'CuentaEsculapio' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CuentaEsculapio.cs'.
        public CuentaEsculapio GetUnCasoEsculapio(string Empresa, string NoCuenta)
#pragma warning restore CS0436 // El tipo 'CuentaEsculapio' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CuentaEsculapio.cs' está en conflicto con el tipo importado 'CuentaEsculapio' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CuentaEsculapio.cs'.
        {
            var sql = "GetunCaso";
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", Empresa);
            lstPars.AddParametro("NoCuenta", NoCuenta);
#pragma warning disable CS0436 // El tipo 'CuentaEsculapio' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CuentaEsculapio.cs' está en conflicto con el tipo importado 'CuentaEsculapio' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CuentaEsculapio.cs'.
            return ExecuteGetUnLista<CuentaEsculapio>(sql, true, lstPars.ToArray());
#pragma warning restore CS0436 // El tipo 'CuentaEsculapio' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CuentaEsculapio.cs' está en conflicto con el tipo importado 'CuentaEsculapio' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CuentaEsculapio.cs'.
        }

#pragma warning disable CS0436 // El tipo 'AdmisionesCorreos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\AdmisionesCorreos.cs' está en conflicto con el tipo importado 'AdmisionesCorreos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\AdmisionesCorreos.cs'.
        public List<AdmisionesCorreos> GetCorreosAdmisiones(string Empresa)
#pragma warning restore CS0436 // El tipo 'AdmisionesCorreos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\AdmisionesCorreos.cs' está en conflicto con el tipo importado 'AdmisionesCorreos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\AdmisionesCorreos.cs'.
        {
#pragma warning disable CS0436 // El tipo 'AdmisionesCorreos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\AdmisionesCorreos.cs' está en conflicto con el tipo importado 'AdmisionesCorreos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\AdmisionesCorreos.cs'.
            var sqlBld = new StringBuilder(GetSelectAll<AdmisionesCorreos>())
#pragma warning restore CS0436 // El tipo 'AdmisionesCorreos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\AdmisionesCorreos.cs' está en conflicto con el tipo importado 'AdmisionesCorreos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\AdmisionesCorreos.cs'.
              .AppendWhere("Empresa = :Empresa ");
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", Empresa);
            var sql = sqlBld.ToString();
#pragma warning disable CS0436 // El tipo 'AdmisionesCorreos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\AdmisionesCorreos.cs' está en conflicto con el tipo importado 'AdmisionesCorreos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\AdmisionesCorreos.cs'.
            return ExecuteGetLista<AdmisionesCorreos>(sql, false, lstPars.ToArray());
#pragma warning restore CS0436 // El tipo 'AdmisionesCorreos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\AdmisionesCorreos.cs' está en conflicto con el tipo importado 'AdmisionesCorreos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\AdmisionesCorreos.cs'.
        }

#pragma warning disable CS0436 // El tipo 'AdmisionesCorreos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\AdmisionesCorreos.cs' está en conflicto con el tipo importado 'AdmisionesCorreos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\AdmisionesCorreos.cs'.
        public AdmisionesCorreos GetUnCorreosAdmisiones(string Empresa, string Correo)
#pragma warning restore CS0436 // El tipo 'AdmisionesCorreos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\AdmisionesCorreos.cs' está en conflicto con el tipo importado 'AdmisionesCorreos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\AdmisionesCorreos.cs'.
        {
#pragma warning disable CS0436 // El tipo 'AdmisionesCorreos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\AdmisionesCorreos.cs' está en conflicto con el tipo importado 'AdmisionesCorreos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\AdmisionesCorreos.cs'.
            var sqlBld = new StringBuilder(GetSelectAll<AdmisionesCorreos>())
#pragma warning restore CS0436 // El tipo 'AdmisionesCorreos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\AdmisionesCorreos.cs' está en conflicto con el tipo importado 'AdmisionesCorreos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\AdmisionesCorreos.cs'.
              .AppendWhere("Empresa = :Empresa and Correo = :Correo ");
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", Empresa);
            lstPars.AddParametro("Correo", Correo);
            var sql = sqlBld.ToString();
#pragma warning disable CS0436 // El tipo 'AdmisionesCorreos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\AdmisionesCorreos.cs' está en conflicto con el tipo importado 'AdmisionesCorreos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\AdmisionesCorreos.cs'.
            return ExecuteGetUnLista<AdmisionesCorreos>(sql, false, lstPars.ToArray());
#pragma warning restore CS0436 // El tipo 'AdmisionesCorreos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\AdmisionesCorreos.cs' está en conflicto con el tipo importado 'AdmisionesCorreos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\AdmisionesCorreos.cs'.
        }

        #region Métodos Estaticos
        /// <summary>
        /// Obtener Conexion a Base de Datos MySQL de las Instituciones
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo</param>
        /// <param name="pSqlDb">Objeto de Acceso a Datos Local</param>
        /// <returns>Objeto de Acceso a Datos MySql</returns>
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
        public static DB ObtenerBaseMySqL(string Empresa, DB pSqlDb, ref EmpresaConeccion emp)
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
        {
#pragma warning disable CS0436 // El tipo 'EmpresaConeccionDB' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccionDB.cs' está en conflicto con el tipo importado 'EmpresaConeccionDB' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccionDB.cs'.
            var empDb = new EmpresaConeccionDB(pSqlDb);
#pragma warning restore CS0436 // El tipo 'EmpresaConeccionDB' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccionDB.cs' está en conflicto con el tipo importado 'EmpresaConeccionDB' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccionDB.cs'.
            var dbMySQl = DB.NuevaDB(DataBase.ManejadorBaseDatos.MySql);
            emp = empDb.GetUnEmpresaConeccion(Empresa);
            if (emp == null)
                throw new Exception("No Hay Parametros de Conexión Definidos para la Empresa {0}".Formato(Empresa));
            dbMySQl.Servidor = emp.Servidor;
            dbMySQl.Puerto = emp.Puerto;
            dbMySQl.BaseDatos = emp.BaseDatos;
            dbMySQl.Usuario = emp.Usuario;
            dbMySQl.Clave = emp.Clave;
            if (!dbMySQl.AbrirConexion())
                throw dbMySQl.UltimaExcepcion;
            return dbMySQl;
        }

        /// <summary>
        /// Buscar Periodo de Cierre
        /// </summary>
        /// <param name="Empresa"></param>
        /// <param name="Periodo"></param>
        /// <returns></returns>
#pragma warning disable CS0436 // El tipo 'CierreFacturasPeriodo' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs' está en conflicto con el tipo importado 'CierreFacturasPeriodo' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs'.
        public CierreFacturasPeriodo GetCierrePeriodoFacturacion(string Empresa, string Periodo)
#pragma warning restore CS0436 // El tipo 'CierreFacturasPeriodo' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs' está en conflicto con el tipo importado 'CierreFacturasPeriodo' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs'.
        {
#pragma warning disable CS0436 // El tipo 'CierreFacturasPeriodo' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs' está en conflicto con el tipo importado 'CierreFacturasPeriodo' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs'.
#pragma warning disable CS0436 // El tipo 'CierreFacturasPeriodo' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs' está en conflicto con el tipo importado 'CierreFacturasPeriodo' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs'.
            return GetUn<CierreFacturasPeriodo>(new CierreFacturasPeriodo
#pragma warning restore CS0436 // El tipo 'CierreFacturasPeriodo' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs' está en conflicto con el tipo importado 'CierreFacturasPeriodo' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs'.
#pragma warning restore CS0436 // El tipo 'CierreFacturasPeriodo' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs' está en conflicto con el tipo importado 'CierreFacturasPeriodo' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs'.
            {
                Empresa = Empresa,
                PeriodoCierre = Periodo
            });
        }

        /// <summary>
        /// Control de Cargue de Consecutivos para Interfaz de S1ESA
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo</param>
        /// <param name="MotivoCargue">Mótivo del Cargue</param>
        /// <param name="Usuario">Usuario que realiza el cargue</param>
        /// <returns>Objeto ControlCargueSiesa</returns>
#pragma warning disable CS0436 // El tipo 'ControlCargueSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs' está en conflicto con el tipo importado 'ControlCargueSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs'.
        public ControlCargueSiesa GetControlCargueSiesa(string Empresa, string MotivoCargue, string Usuario)
#pragma warning restore CS0436 // El tipo 'ControlCargueSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs' está en conflicto con el tipo importado 'ControlCargueSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs'.
        {
            var sql = "GetControlCargueSiesa";
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", Empresa);
            lstPars.AddParametro("MotivoCargue", MotivoCargue);
            lstPars.AddParametro("Usuario", Usuario);
#pragma warning disable CS0436 // El tipo 'ControlCargueSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs' está en conflicto con el tipo importado 'ControlCargueSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs'.
            return ExecuteGetUnLista<ControlCargueSiesa>(sql, true, lstPars.ToArray());
#pragma warning restore CS0436 // El tipo 'ControlCargueSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs' está en conflicto con el tipo importado 'ControlCargueSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs'.
        }

        /// <summary>
        /// Obtener los Controles de Cargue Entre Fechas
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo</param>
        /// <param name="FechaInicial">Fecha Inicial</param>
        /// <param name="FechaFinal">Fecha Final</param>
        /// <returns>Lista de Control de Cargues</returns>
#pragma warning disable CS0436 // El tipo 'ControlCargueSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs' está en conflicto con el tipo importado 'ControlCargueSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs'.
        public List<ControlCargueSiesa> GetControlCargueSiesaFechas(string Empresa, Fecha FechaInicial, Fecha FechaFinal)
#pragma warning restore CS0436 // El tipo 'ControlCargueSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs' está en conflicto con el tipo importado 'ControlCargueSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs'.
        {
            var sql = new StringBuilder();
#pragma warning disable CS0436 // El tipo 'ControlCargueSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs' está en conflicto con el tipo importado 'ControlCargueSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs'.
            sql.AppendLine(GetSelectAll<ControlCargueSiesa>(false));
#pragma warning restore CS0436 // El tipo 'ControlCargueSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs' está en conflicto con el tipo importado 'ControlCargueSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs'.
            sql.AppendLine(" WHERE Fecha between :FechaInicial and :FechaFinal");
            sql.AppendLine(" ORDER by IdControlCargue ");
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", Empresa);
            lstPars.AddParametro("FechaInicial", FechaInicial);
            lstPars.AddParametro("FechaFinal", FechaFinal);
#pragma warning disable CS0436 // El tipo 'ControlCargueSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs' está en conflicto con el tipo importado 'ControlCargueSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs'.
            return ExecuteGetLista<ControlCargueSiesa>(sql.ToString(), false, lstPars.ToArray());
#pragma warning restore CS0436 // El tipo 'ControlCargueSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs' está en conflicto con el tipo importado 'ControlCargueSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs'.
        }

#pragma warning disable CS0436 // El tipo 'FacturasControl' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\FacturasControl.cs' está en conflicto con el tipo importado 'FacturasControl' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\FacturasControl.cs'.
        public List<FacturasControl> GetFacturasControlCargue(string Empresa, EnteroLargo IdControlCargue)
#pragma warning restore CS0436 // El tipo 'FacturasControl' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\FacturasControl.cs' está en conflicto con el tipo importado 'FacturasControl' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\FacturasControl.cs'.
        {
#pragma warning disable CS0436 // El tipo 'ControlCargueSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs' está en conflicto con el tipo importado 'ControlCargueSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs'.
#pragma warning disable CS0436 // El tipo 'ControlCargueSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs' está en conflicto con el tipo importado 'ControlCargueSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs'.
            var control = GetUn<ControlCargueSiesa>(new ControlCargueSiesa { Empresa = Empresa, IdControlCargue = IdControlCargue });
#pragma warning restore CS0436 // El tipo 'ControlCargueSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs' está en conflicto con el tipo importado 'ControlCargueSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs'.
#pragma warning restore CS0436 // El tipo 'ControlCargueSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs' está en conflicto con el tipo importado 'ControlCargueSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs'.
            if (control != null)
            {
                var sql = @"
SELECT NoFactura,NoCuenta, NitEntidad,CodConvenio, Fecha_Emision, Fecha_Radicacion
FROM facturas
WHERE empresa = :Empresa and {0} = :IdControlCargue
Order by Fecha_Emision, NoFactura
".Formato((control.MotivoCargue.ToUpper() == "FACTURACION" ? "IdControlCargueFacturacion" : "IdControlCargueRadicacion"));
                var lstPars = new List<Parametro>();
                lstPars.AddParametro("Empresa", Empresa);
                lstPars.AddParametro("IdControlCargue", IdControlCargue);
#pragma warning disable CS0436 // El tipo 'FacturasControl' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\FacturasControl.cs' está en conflicto con el tipo importado 'FacturasControl' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\FacturasControl.cs'.
                return ExecuteGetLista<FacturasControl>(sql, false, lstPars.ToArray());
#pragma warning restore CS0436 // El tipo 'FacturasControl' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\FacturasControl.cs' está en conflicto con el tipo importado 'FacturasControl' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\FacturasControl.cs'.
            }
            else throw new Exception("El Control de Facturacion No. {0} de la Empresa {1} No Existe".Formato(IdControlCargue, Empresa));
        }

        public void DesmarcarFacturasControlCargue(string Empresa, EnteroLargo IdControlCargue)
        {
#pragma warning disable CS0436 // El tipo 'ControlCargueSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs' está en conflicto con el tipo importado 'ControlCargueSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs'.
#pragma warning disable CS0436 // El tipo 'ControlCargueSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs' está en conflicto con el tipo importado 'ControlCargueSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs'.
            var control = GetUn<ControlCargueSiesa>(new ControlCargueSiesa { Empresa = Empresa, IdControlCargue = IdControlCargue });
#pragma warning restore CS0436 // El tipo 'ControlCargueSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs' está en conflicto con el tipo importado 'ControlCargueSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs'.
#pragma warning restore CS0436 // El tipo 'ControlCargueSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs' está en conflicto con el tipo importado 'ControlCargueSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ControlCargueSiesa.cs'.
            if (control != null)
            {
                var sql = @"
Update facturas
Set {1} = 'N'
WHERE empresa = :Empresa and {0} = :IdControlCargue
Order by Fecha_Emision, NoFactura
".Formato((control.MotivoCargue.ToUpper() == "FACTURACION" ? "IdControlCargueFacturacion" : "IdControlCargueRadicacion"),
         (control.MotivoCargue.ToUpper() == "FACTURACION" ? "ProcesoContable" : "ProcesoContableRadicado"));
                var lstPars = new List<Parametro>();
                lstPars.AddParametro("Empresa", Empresa);
                lstPars.AddParametro("IdControlCargue", IdControlCargue);
                if (!SqlDb.EjecutarComando(sql, false, lstPars.ToArray()))
                    throw SqlDb.UltimaExcepcion;
            }
            else throw new Exception("El Control de Facturacion No. {0} de la Empresa {1} No Existe".Formato(IdControlCargue, Empresa));
        }

        /// <summary>
        /// Procesar el Cierre de Facturación
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo</param>
        /// <param name="Usuario">Usuairo que Realiza el Cierre</param>
        /// <returns></returns>
#pragma warning disable CS0436 // El tipo 'CierreFacturacionResultado' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturacionResultado.cs' está en conflicto con el tipo importado 'CierreFacturacionResultado' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturacionResultado.cs'.
        public CierreFacturacionResultado CierreFacturacion(string Empresa, string Usuario)
#pragma warning restore CS0436 // El tipo 'CierreFacturacionResultado' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturacionResultado.cs' está en conflicto con el tipo importado 'CierreFacturacionResultado' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturacionResultado.cs'.
        {
            var sql = "CierreFacturacion";
            var pars = new List<Parametro>();
            pars.AddParametro("Empresa", Empresa);
            pars.AddParametro("Usuario", Usuario);
#pragma warning disable CS0436 // El tipo 'CierreFacturacionResultado' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturacionResultado.cs' está en conflicto con el tipo importado 'CierreFacturacionResultado' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturacionResultado.cs'.
            return ExecuteGetUnLista<CierreFacturacionResultado>(sql, true, pars.ToArray());
#pragma warning restore CS0436 // El tipo 'CierreFacturacionResultado' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturacionResultado.cs' está en conflicto con el tipo importado 'CierreFacturacionResultado' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturacionResultado.cs'.
        }

        /// <summary>
        /// Procesar el Cierre de Facturación
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo</param>
        /// <param name="Usuario">Usuairo que Realiza el Cierre</param>
        /// <returns></returns>
#pragma warning disable CS0436 // El tipo 'CierreFacturacionResultado' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturacionResultado.cs' está en conflicto con el tipo importado 'CierreFacturacionResultado' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturacionResultado.cs'.
        public CierreFacturacionResultado CierreFacturacionEspecial(string Empresa, string Usuario)
#pragma warning restore CS0436 // El tipo 'CierreFacturacionResultado' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturacionResultado.cs' está en conflicto con el tipo importado 'CierreFacturacionResultado' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturacionResultado.cs'.
        {
            var sql = "CierreFacturaEspecial";
            var pars = new List<Parametro>();
            pars.AddParametro("Empresa", Empresa);
            pars.AddParametro("Usuario", Usuario);
#pragma warning disable CS0436 // El tipo 'CierreFacturacionResultado' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturacionResultado.cs' está en conflicto con el tipo importado 'CierreFacturacionResultado' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturacionResultado.cs'.
            return ExecuteGetUnLista<CierreFacturacionResultado>(sql, true, pars.ToArray());
#pragma warning restore CS0436 // El tipo 'CierreFacturacionResultado' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturacionResultado.cs' está en conflicto con el tipo importado 'CierreFacturacionResultado' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturacionResultado.cs'.
        }

        /// <summary>
        /// Cancelar el Cierre de Facturación de Un Periodo
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo</param>
        /// <param name="PeriodoCierre">Periodo a Cancelar Cierre</param>
        /// <param name="Usuario">Usuario que Realiza la Cancelación</param>
        public void CancelarCierreFacturacion(string Empresa, string PeriodoCierre, string Usuario)
        {
            var sql = "CancelarCierrePeriodo";
            var pars = new List<Parametro>();
            pars.AddParametro("Empresa", Empresa);
            pars.AddParametro("PeriodoCierre", PeriodoCierre);
            pars.AddParametro("Usuario", Usuario);
            if (!SqlDb.EjecutarComando(sql, true, pars.ToArray()))
                throw SqlDb.UltimaExcepcion;
        }
        /// <summary>
        /// Lista de Cierres No Contabilizados
        /// </summary>
        /// <param name="Empresa">Empres de Trabajo</param>
        /// <returns>Cierres no Contabilizados</returns>
#pragma warning disable CS0436 // El tipo 'CierreFacturasPeriodo' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs' está en conflicto con el tipo importado 'CierreFacturasPeriodo' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs'.
        public List<CierreFacturasPeriodo> GetCierreFacturasNoContabilizados(string Empresa)
#pragma warning restore CS0436 // El tipo 'CierreFacturasPeriodo' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs' está en conflicto con el tipo importado 'CierreFacturasPeriodo' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs'.
        {
#pragma warning disable CS0436 // El tipo 'CierreFacturasPeriodo' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs' está en conflicto con el tipo importado 'CierreFacturasPeriodo' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs'.
            var sql = GetSelectAll<CierreFacturasPeriodo>(false)
#pragma warning restore CS0436 // El tipo 'CierreFacturasPeriodo' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs' está en conflicto con el tipo importado 'CierreFacturasPeriodo' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs'.
               + " Where Empresa = :Empresa and Contabilizado = 'N' ";
            var pars = new List<Parametro>();
            pars.AddParametro("Empresa", Empresa);
#pragma warning disable CS0436 // El tipo 'CierreFacturasPeriodo' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs' está en conflicto con el tipo importado 'CierreFacturasPeriodo' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs'.
            return ExecuteGetLista<CierreFacturasPeriodo>(sql, false, pars.ToArray());
#pragma warning restore CS0436 // El tipo 'CierreFacturasPeriodo' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs' está en conflicto con el tipo importado 'CierreFacturasPeriodo' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs'.
        }

        /// <summary>
        /// Resumen de VEntas No Facturadas de un Periodo de Cierre
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo</param>
        /// <param name="PeriodoContabilizar">Periodo a Contabilizar</param>
        /// <returns></returns>
#pragma warning disable CS0436 // El tipo 'ResumenVentasNoFacturadas' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ResumenVentasNoFacturadas.cs' está en conflicto con el tipo importado 'ResumenVentasNoFacturadas' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ResumenVentasNoFacturadas.cs'.
        public List<ResumenVentasNoFacturadas> GetVentasNoFacturadas(string Empresa, string PeriodoContabilizar)
#pragma warning restore CS0436 // El tipo 'ResumenVentasNoFacturadas' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ResumenVentasNoFacturadas.cs' está en conflicto con el tipo importado 'ResumenVentasNoFacturadas' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ResumenVentasNoFacturadas.cs'.
        {
            var sql = "GetVentasNoFacturadas";
            var pars = new List<Parametro>();
            pars.AddParametro("Empresa", Empresa);
            pars.AddParametro("PeriodoContabilizar", PeriodoContabilizar);
#pragma warning disable CS0436 // El tipo 'ResumenVentasNoFacturadas' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ResumenVentasNoFacturadas.cs' está en conflicto con el tipo importado 'ResumenVentasNoFacturadas' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ResumenVentasNoFacturadas.cs'.
            return ExecuteGetLista<ResumenVentasNoFacturadas>(sql, true, pars.ToArray());
#pragma warning restore CS0436 // El tipo 'ResumenVentasNoFacturadas' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ResumenVentasNoFacturadas.cs' está en conflicto con el tipo importado 'ResumenVentasNoFacturadas' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ResumenVentasNoFacturadas.cs'.
        }

#pragma warning disable CS0436 // El tipo 'Planes_Tarifarios' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs' está en conflicto con el tipo importado 'Planes_Tarifarios' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs'.
        public List<Planes_Tarifarios> GetPlanesTarifarios(string Empresa)
#pragma warning restore CS0436 // El tipo 'Planes_Tarifarios' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs' está en conflicto con el tipo importado 'Planes_Tarifarios' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs'.
        {
#pragma warning disable CS0436 // El tipo 'Planes_Tarifarios' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs' está en conflicto con el tipo importado 'Planes_Tarifarios' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs'.
            var sql = GetSelectAll<Planes_Tarifarios>(false) + " Where Empresa = :Empresa Order by NombrePlan";
#pragma warning restore CS0436 // El tipo 'Planes_Tarifarios' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs' está en conflicto con el tipo importado 'Planes_Tarifarios' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs'.
            var pars = new List<Parametro>();
            pars.AddParametro("Empresa", Empresa);
#pragma warning disable CS0436 // El tipo 'Planes_Tarifarios' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs' está en conflicto con el tipo importado 'Planes_Tarifarios' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs'.
            return ExecuteGetLista<Planes_Tarifarios>(sql, false, pars.ToArray());
#pragma warning restore CS0436 // El tipo 'Planes_Tarifarios' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs' está en conflicto con el tipo importado 'Planes_Tarifarios' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs'.
        }

#pragma warning disable CS0436 // El tipo 'Planes_Tarifarios' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs' está en conflicto con el tipo importado 'Planes_Tarifarios' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs'.
        public Planes_Tarifarios GetUnPlanesTarifario(string Empresa, string CodPlan)
#pragma warning restore CS0436 // El tipo 'Planes_Tarifarios' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs' está en conflicto con el tipo importado 'Planes_Tarifarios' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs'.
        {
#pragma warning disable CS0436 // El tipo 'Planes_Tarifarios' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs' está en conflicto con el tipo importado 'Planes_Tarifarios' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs'.
            var sql = GetSelectAll<Planes_Tarifarios>(false)
#pragma warning restore CS0436 // El tipo 'Planes_Tarifarios' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs' está en conflicto con el tipo importado 'Planes_Tarifarios' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs'.
              + " Where Empresa = :Empresa and CodPlan = :CodPlan ";
            var pars = new List<Parametro>();
            pars.AddParametro("Empresa", Empresa);
            pars.AddParametro("CodPlan", CodPlan);
#pragma warning disable CS0436 // El tipo 'Planes_Tarifarios' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs' está en conflicto con el tipo importado 'Planes_Tarifarios' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs'.
            return ExecuteGetUnLista<Planes_Tarifarios>(sql, false, pars.ToArray());
#pragma warning restore CS0436 // El tipo 'Planes_Tarifarios' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs' está en conflicto con el tipo importado 'Planes_Tarifarios' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs'.
        }

#pragma warning disable CS0436 // El tipo 'Planes_Tarifarios' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs' está en conflicto con el tipo importado 'Planes_Tarifarios' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs'.
        public void UpdatePlanTarifario(Planes_Tarifarios plan)
#pragma warning restore CS0436 // El tipo 'Planes_Tarifarios' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs' está en conflicto con el tipo importado 'Planes_Tarifarios' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs'.
        {
            var Sql = "UpdatePlanTarifarioSiesa";
            List<Parametro> lst = new List<Parametro>();
            lst.AddParametro("Empresa", plan.Empresa);
            lst.AddParametro("CodPlan", plan.CodPlan);
            lst.AddParametro("IncluirInterfazSiesa", (plan.IncluirInterfazSiesa ? "S" : "N"));
            lst.AddParametro("UtilizarNitFactura", (plan.UtilizarNitFactura ? "S" : "N"));
            if (!SqlDb.EjecutarComando(Sql, true, lst.ToArray()))
            {
                throw new Exception(SqlDb.UltimoError);
            }

        }

#pragma warning disable CS0436 // El tipo 'Resolucion_Facturacion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Resolucion_Facturacion.cs' está en conflicto con el tipo importado 'Resolucion_Facturacion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Resolucion_Facturacion.cs'.
        public List<Resolucion_Facturacion> GetResolucionesActivas(string Empresa)
#pragma warning restore CS0436 // El tipo 'Resolucion_Facturacion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Resolucion_Facturacion.cs' está en conflicto con el tipo importado 'Resolucion_Facturacion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Resolucion_Facturacion.cs'.
        {
#pragma warning disable CS0436 // El tipo 'Resolucion_Facturacion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Resolucion_Facturacion.cs' está en conflicto con el tipo importado 'Resolucion_Facturacion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Resolucion_Facturacion.cs'.
            var sql = GetSelectAll<Resolucion_Facturacion>(false) + " Where Empresa = :Empresa and Estado = 'A' Order by NoResolucion";
#pragma warning restore CS0436 // El tipo 'Resolucion_Facturacion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Resolucion_Facturacion.cs' está en conflicto con el tipo importado 'Resolucion_Facturacion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Resolucion_Facturacion.cs'.
            var pars = new List<Parametro>();
            pars.AddParametro("Empresa", Empresa);
#pragma warning disable CS0436 // El tipo 'Resolucion_Facturacion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Resolucion_Facturacion.cs' está en conflicto con el tipo importado 'Resolucion_Facturacion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Resolucion_Facturacion.cs'.
            return ExecuteGetLista<Resolucion_Facturacion>(sql, false, pars.ToArray());
#pragma warning restore CS0436 // El tipo 'Resolucion_Facturacion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Resolucion_Facturacion.cs' está en conflicto con el tipo importado 'Resolucion_Facturacion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Resolucion_Facturacion.cs'.
        }

#pragma warning disable CS0436 // El tipo 'Resolucion_Facturacion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Resolucion_Facturacion.cs' está en conflicto con el tipo importado 'Resolucion_Facturacion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Resolucion_Facturacion.cs'.
        public List<Resolucion_Facturacion> GetResolucionesTodas(string Empresa)
#pragma warning restore CS0436 // El tipo 'Resolucion_Facturacion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Resolucion_Facturacion.cs' está en conflicto con el tipo importado 'Resolucion_Facturacion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Resolucion_Facturacion.cs'.
        {
#pragma warning disable CS0436 // El tipo 'Resolucion_Facturacion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Resolucion_Facturacion.cs' está en conflicto con el tipo importado 'Resolucion_Facturacion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Resolucion_Facturacion.cs'.
            var sql = GetSelectAll<Resolucion_Facturacion>(false) + " Where Empresa = :Empresa Order by NoResolucion";
#pragma warning restore CS0436 // El tipo 'Resolucion_Facturacion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Resolucion_Facturacion.cs' está en conflicto con el tipo importado 'Resolucion_Facturacion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Resolucion_Facturacion.cs'.
            var pars = new List<Parametro>();
            pars.AddParametro("Empresa", Empresa);
#pragma warning disable CS0436 // El tipo 'Resolucion_Facturacion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Resolucion_Facturacion.cs' está en conflicto con el tipo importado 'Resolucion_Facturacion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Resolucion_Facturacion.cs'.
            return ExecuteGetLista<Resolucion_Facturacion>(sql, false, pars.ToArray());
#pragma warning restore CS0436 // El tipo 'Resolucion_Facturacion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Resolucion_Facturacion.cs' está en conflicto con el tipo importado 'Resolucion_Facturacion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Resolucion_Facturacion.cs'.
        }

#pragma warning disable CS0436 // El tipo 'VentasNoFacturadas' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\VentasNoFacturadas.cs' está en conflicto con el tipo importado 'VentasNoFacturadas' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\VentasNoFacturadas.cs'.
        public List<VentasNoFacturadas> GetReversaVentasNoFacturads(String Empresa, Fecha FechaInicial, Fecha FechaFinal, bool ProcesarMarcadas)
#pragma warning restore CS0436 // El tipo 'VentasNoFacturadas' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\VentasNoFacturadas.cs' está en conflicto con el tipo importado 'VentasNoFacturadas' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\VentasNoFacturadas.cs'.
        {
            var sql = "GetReversaVentasNoFacturadas";
            var pars = new List<Parametro>();
            pars.AddParametro("Empresa", Empresa);
            pars.AddParametro("FechaInicial", FechaInicial);
            pars.AddParametro("FechaFinal", FechaFinal);
            pars.AddParametro("ProcesarMarcadas", (ProcesarMarcadas ? "S" : "N"));
#pragma warning disable CS0436 // El tipo 'VentasNoFacturadas' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\VentasNoFacturadas.cs' está en conflicto con el tipo importado 'VentasNoFacturadas' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\VentasNoFacturadas.cs'.
            return ExecuteGetLista<VentasNoFacturadas>(sql, true, pars.ToArray());
#pragma warning restore CS0436 // El tipo 'VentasNoFacturadas' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\VentasNoFacturadas.cs' está en conflicto con el tipo importado 'VentasNoFacturadas' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\VentasNoFacturadas.cs'.
        }

        /// <summary>
        /// Marcar Factura de la interdfaz
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo</param>
        /// <param name="NoCuenta">No. de Cuenta</param>
        /// <param name="ConsInterno">Cons Interno Factura</param>
        /// <param name="Usuario">Usuario que realiza el proceso</param>
        /// <param name="IdControlCargue">Id. Control de Cargue para Facturacion</param>
        public void MarcarFactura(string Empresa, Entero NoCuenta, Entero ConsInterno, string Usuario, EnteroLargo IdControlCargue)
        {
            var sql = @"
Update Facturas
Set ProcesoContable = 'S',
    FechaProcesoContable = current_date(),
    HoraProcesoContable = SUBSTRING(CURRENT_TIME(),1,5),
    UsuarioProcesoContable = :Usuario,
    IdControlCargueFacturacion = :IdControlCargue
Where Empresa = :Empresa and
      NoCuenta = :NoCuenta and
      ConsInterno  = :ConsInterno
";
            var lpars = new List<Parametro>();
            lpars.AddParametro("Usuario", Usuario);
            lpars.AddParametro("Empresa", Empresa);
            lpars.AddParametro("NoCuenta", NoCuenta);
            lpars.AddParametro("ConsInterno", ConsInterno);
            lpars.AddParametro("IdControlCargue", IdControlCargue);
            if (!SqlDb.EjecutarComando(sql, false, lpars.ToArray()))
                throw SqlDb.UltimaExcepcion;
        }

        /// <summary>
        /// Marcar Factura de la interdfaz
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo</param>
        /// <param name="NoCuenta">No. de Cuenta</param>
        /// <param name="ConsInterno">Cons Interno Factura</param>
        /// <param name="Usuario">Usuario que realiza el proceso</param>
        /// <param name="IdControlCargue">Id. Control de Cargue para Radicación</param>
        public void MarcarFacturaRadicado(string Empresa, Entero NoCuenta, Entero ConsInterno, string Usuario, EnteroLargo IdControlCargue)
        {
            var sql = @"
Update Facturas 
Set ProcesoContableRadicado = 'S',
    FechaProcesoContableRadicado = current_date(),
    HoraProcesoContableRadicado = SUBSTRING(CURRENT_TIME(),1,5),
    UsuarioProcesoContableRadicado = :Usuario,
    IdControlCargueRadicacion = :IdControlCargue
Where Empresa = :Empresa and
      NoCuenta = :NoCuenta and
      ConsInterno  = :ConsInterno
";
            var lpars = new List<Parametro>();
            lpars.AddParametro("Usuario", Usuario);
            lpars.AddParametro("Empresa", Empresa);
            lpars.AddParametro("NoCuenta", NoCuenta);
            lpars.AddParametro("ConsInterno", ConsInterno);
            lpars.AddParametro("IdControlCargue", IdControlCargue);
            if (!SqlDb.EjecutarComando(sql, false, lpars.ToArray()))
                throw SqlDb.UltimaExcepcion;
        }

        /// <summary>
        /// Marcar Factura de Reversión de Ventas No Facturadas
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo</param>
        /// <param name="NoCuenta">No. de Cuenta</param>
        /// <param name="ConsInterno">Cons Interno Factura</param>
        /// <param name="Usuario">Usuario que realiza el proceso</param>
        public void MarcarFacturaReversaVentaNoFacturada(string Empresa, Entero NoCuenta, Entero ConsInterno, string Usuario)
        {
            var sql = @"
Update CierreFacturas 
Set Contabilizado = 'S',
    FechaContabiliza = current_date(),
    HoraContabiliza = SUBSTRING(CURRENT_TIME(),1,5),
    UsuarioContabiliza = :Usuario
Where Empresa = :Empresa and
      NoCuenta = :NoCuenta and
      ConsInternoFactura  = :ConsInterno
";
            var lpars = new List<Parametro>();
            lpars.AddParametro("Usuario", Usuario);
            lpars.AddParametro("Empresa", Empresa);
            lpars.AddParametro("NoCuenta", NoCuenta);
            lpars.AddParametro("ConsInterno", ConsInterno);
            if (!SqlDb.EjecutarComando(sql, false, lpars.ToArray()))
                throw SqlDb.UltimaExcepcion;
        }
        #endregion

        #region Consultas de Cierre de Facturación
        /// <summary>
        /// Traer la Lista de Periodos Cerrados
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo</param>
        /// <returns>Lista de los Periodos Cerrados</returns>
#pragma warning disable CS0436 // El tipo 'CierreFacturasPeriodo' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs' está en conflicto con el tipo importado 'CierreFacturasPeriodo' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs'.
        public List<CierreFacturasPeriodo> GetPeriodosCerrados(string Empresa)
#pragma warning restore CS0436 // El tipo 'CierreFacturasPeriodo' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs' está en conflicto con el tipo importado 'CierreFacturasPeriodo' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs'.
        {
#pragma warning disable CS0436 // El tipo 'CierreFacturasPeriodo' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs' está en conflicto con el tipo importado 'CierreFacturasPeriodo' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs'.
            var sql = new StringBuilder(GetSelectAll<CierreFacturasPeriodo>(false));
#pragma warning restore CS0436 // El tipo 'CierreFacturasPeriodo' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs' está en conflicto con el tipo importado 'CierreFacturasPeriodo' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs'.
            sql.AppendLine(" WHERE Empresa = :Empresa");
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", Empresa);
#pragma warning disable CS0436 // El tipo 'CierreFacturasPeriodo' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs' está en conflicto con el tipo importado 'CierreFacturasPeriodo' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs'.
            return ExecuteGetLista<CierreFacturasPeriodo>(sql.ToString(), false, lstPars.ToArray());
#pragma warning restore CS0436 // El tipo 'CierreFacturasPeriodo' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs' está en conflicto con el tipo importado 'CierreFacturasPeriodo' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\CierreFacturasPeriodo.cs'.
        }

        /// <summary>
        /// Consulta del Periodo Cerrado por Servicio y Dependencia
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo</param>
        /// <param name="PeriodoCierre">Periodo del Cierre</param>
        /// <returns>Lista de ConsultaPeriodoCierre con los Datos del Cierre</returns>
#pragma warning disable CS0436 // El tipo 'ConsultaPeriodoCierre' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaPeriodoCierre.cs' está en conflicto con el tipo importado 'ConsultaPeriodoCierre' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaPeriodoCierre.cs'.
        public List<ConsultaPeriodoCierre> GetConsultaCierre(string Empresa, string PeriodoCierre)
#pragma warning restore CS0436 // El tipo 'ConsultaPeriodoCierre' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaPeriodoCierre.cs' está en conflicto con el tipo importado 'ConsultaPeriodoCierre' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaPeriodoCierre.cs'.
        {
            var sql = "GetConsultaCierre";
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", Empresa);
            lstPars.AddParametro("PeriodoCierre", PeriodoCierre);
#pragma warning disable CS0436 // El tipo 'ConsultaPeriodoCierre' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaPeriodoCierre.cs' está en conflicto con el tipo importado 'ConsultaPeriodoCierre' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaPeriodoCierre.cs'.
            return ExecuteGetLista<ConsultaPeriodoCierre>(sql, true, lstPars.ToArray());
#pragma warning restore CS0436 // El tipo 'ConsultaPeriodoCierre' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaPeriodoCierre.cs' está en conflicto con el tipo importado 'ConsultaPeriodoCierre' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaPeriodoCierre.cs'.
        }



        /// <summary>
        /// Consulta del Periodo Cerrado por Tercero, Plan, Servicio y Dependencia
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo</param>
        /// <param name="PeriodoCierre">Periodo del Cierre</param>
        /// <returns>Lista de ConsultaPeriodoCierre con los Datos del Cierre</returns>
#pragma warning disable CS0436 // El tipo 'ConsultaPeriodoCierreDetallada' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaPeriodoCierreDetallada.cs' está en conflicto con el tipo importado 'ConsultaPeriodoCierreDetallada' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaPeriodoCierreDetallada.cs'.
        public List<ConsultaPeriodoCierreDetallada> GetConsultaCierreDetalle(string Empresa, string PeriodoCierre)
#pragma warning restore CS0436 // El tipo 'ConsultaPeriodoCierreDetallada' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaPeriodoCierreDetallada.cs' está en conflicto con el tipo importado 'ConsultaPeriodoCierreDetallada' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaPeriodoCierreDetallada.cs'.
        {
            var sql = "GetConsultaCierreDetalle";
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", Empresa);
            lstPars.AddParametro("PeriodoCierre", PeriodoCierre);
#pragma warning disable CS0436 // El tipo 'ConsultaPeriodoCierreDetallada' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaPeriodoCierreDetallada.cs' está en conflicto con el tipo importado 'ConsultaPeriodoCierreDetallada' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaPeriodoCierreDetallada.cs'.
            return ExecuteGetLista<ConsultaPeriodoCierreDetallada>(sql, true, lstPars.ToArray());
#pragma warning restore CS0436 // El tipo 'ConsultaPeriodoCierreDetallada' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaPeriodoCierreDetallada.cs' está en conflicto con el tipo importado 'ConsultaPeriodoCierreDetallada' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaPeriodoCierreDetallada.cs'.
        }
        /// <summary>
        /// Consulta del Periodo Cerrado por Tercero, Plan, Servicio y Dependencia
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo</param>
        /// <param name="PeriodoCierre">Periodo del Cierre</param>
        /// <returns>Lista de ConsultaPeriodoCierre con los Datos del Cierre</returns>
#pragma warning disable CS0436 // El tipo 'ConsultaPeriodoCierreCasos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaPeriodoCierreCasos.cs' está en conflicto con el tipo importado 'ConsultaPeriodoCierreCasos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaPeriodoCierreCasos.cs'.
        public List<ConsultaPeriodoCierreCasos> GetConsultaCierreCasos(string Empresa, string PeriodoCierre)
#pragma warning restore CS0436 // El tipo 'ConsultaPeriodoCierreCasos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaPeriodoCierreCasos.cs' está en conflicto con el tipo importado 'ConsultaPeriodoCierreCasos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaPeriodoCierreCasos.cs'.
        {
            var sql = "GetConsultaCierreCasos";
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", Empresa);
            lstPars.AddParametro("PeriodoCierre", PeriodoCierre);
#pragma warning disable CS0436 // El tipo 'ConsultaPeriodoCierreCasos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaPeriodoCierreCasos.cs' está en conflicto con el tipo importado 'ConsultaPeriodoCierreCasos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaPeriodoCierreCasos.cs'.
            return ExecuteGetLista<ConsultaPeriodoCierreCasos>(sql, true, lstPars.ToArray());
#pragma warning restore CS0436 // El tipo 'ConsultaPeriodoCierreCasos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaPeriodoCierreCasos.cs' está en conflicto con el tipo importado 'ConsultaPeriodoCierreCasos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ConsultaPeriodoCierreCasos.cs'.
        }

#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
        public static object ObtenerBaseMySqL(string empresa, DB sqlDb, ref EmpresaConeccion empresaConeccion, object emp)
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
        {
            throw new NotImplementedException();
        }
        #endregion

    }//fin clase
}//fin namespace
