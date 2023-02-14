
using LiloSoft.DataBase.ConectaDB;
using LiloSoft.Utils;
using LiloSoft.Web.ProveedorWeb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace LiloSoft.Siesa.Interfaz
{
    /// <summary>
    /// Manejo de EmpresaConeccion
    /// </summary>
    [DataObject(true)]
    [Description("Conexiones a las Empresas")]
    public class EmpresaConeccionDB : LiloSoft.Web.ProveedorWeb.BaseDB
    {
        #region Constructores
        /// <summary>
        /// Constructor por Defecto
        /// </summary>
        public EmpresaConeccionDB()
        {
            ComportamientoIndividualComandos = true;
            TipoComandoIndividual = LiloSoft.Web.ProveedorWeb.TipoComando.InstruccionSQL;
        }
        /// <summary>
        /// Constructor con Objeto de Base de Datos
        /// </summary>
        /// <param name="db">Manejador de Bases de Datos</param>
        public EmpresaConeccionDB(DB db)
          : this()
        {
            SqlDb = db;
        }
        #endregion


        #region Metodos de Acceso a Datos
        /// <summary>
        /// Insertar un Registro en EmpresaConeccion
        /// </summary>
        /// <param name="m">Objeto EmpresaConeccion a Insertar</param>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
        public void Insert(EmpresaConeccion m)
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
        {
            List<Parametro> lst = GetParametros(m);
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
            if (!SqlDb.EjecutarComando(GetInstruccionSql<EmpresaConeccion>(TiposProcedimientosAlmacenados.Insert), EsProcedimientoAlmacenado, lst.ToArray()))
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
            {
                throw new Exception(SqlDb.UltimoError);
            }
        }

        /// <summary>
        /// Actualizar un Registro en EmpresaConeccion
        /// </summary>
        /// <param name="m">Objeto EmpresaConeccion a Actualizar</param>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
        public void Update(EmpresaConeccion m)
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
        {
            List<Parametro> lst = GetParametros(m);
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
            if (!SqlDb.EjecutarComando(GetInstruccionSql<EmpresaConeccion>(TiposProcedimientosAlmacenados.Update), EsProcedimientoAlmacenado, lst.ToArray()))
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
            {
                throw new Exception(SqlDb.UltimoError);
            }
        }

        /// <summary>
        /// Eliminar un Registro EmpresaConeccion
        /// </summary>
        /// <param name="m">Objeto EmpresaConeccion a Eliminar</param>
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
        public void Delete(EmpresaConeccion m)
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
        {
            List<Parametro> lst = GetParametros(m, true);
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
            if (!SqlDb.EjecutarComando(GetInstruccionSql<EmpresaConeccion>(TiposProcedimientosAlmacenados.Delete), EsProcedimientoAlmacenado, lst.ToArray()))
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
            {
                throw new Exception(SqlDb.UltimoError);
            }
        }


        #endregion

        #region Metodos de Listas
        /// <summary>
        /// Lista de Todos los EmpresaConeccion
        /// </summary>
        /// <param name="Criterio">Criterio de Busqueda de la Clase</param>
        /// <param name="Empresa">Empresa de Trabajo Seleccionada</param>
        /// <returns>Lista de EmpresaConeccion</returns>
        [DataObjectMethod(DataObjectMethodType.Select, true)]
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
        public List<EmpresaConeccion> GetEmpresaConeccion(string Criterio, String Empresa)
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
        {
            var lstParam = new List<Parametro>();
            var sqlText = "";
            if (string.IsNullOrEmpty(Criterio))
            {
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
                sqlText = GetInstruccionSql<EmpresaConeccion>(TiposProcedimientosAlmacenados.Todos);
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
                lstParam.AddParametro("Empresa", Empresa);

            }
            else
            {
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
                sqlText = GetInstruccionSql<EmpresaConeccion>(TiposProcedimientosAlmacenados.Criterio);
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
                lstParam.AddParametro("Criterio", Criterio);
                lstParam.AddParametro("Empresa", Empresa);

            }
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
            var lista = ExecuteGetLista<EmpresaConeccion>(sqlText, EsProcedimientoAlmacenado, lstParam.ToArray());
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
            return lista;
        }

        /// <summary>
        /// Lista de Todos los EmpresaConeccion
        /// </summary>      
        /// <param name="Empresa">Empresa de Trabajo Seleccionada</param>
        /// <returns>Lista de EmpresaConeccion</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
        public List<EmpresaConeccion> GetEmpresaConeccion(String Empresa)
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
        {
            return GetEmpresaConeccion("", Empresa);
        }

        /// <summary>
        /// Lista de Todos los EmpresaConeccion
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo Seleccionada</param>
        /// <returns>Lista de EmpresaConeccion</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
        public List<EmpresaConeccion> GetEmpresaConeccionActivo(String Empresa)
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
        {
            return GetEmpresaConeccionActivo("", Empresa);
        }

        /// <summary>
        /// Lista de Todos los EmpresaConeccion Activos
        /// </summary>
        /// <param name="Criterio">Criterio de Busqueda de la Clase</param>
        /// <param name="Empresa">Empresa de Trabajo Seleccionada</param>
        /// <returns>Lista de EmpresaConeccion</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
        public List<EmpresaConeccion> GetEmpresaConeccionActivo(string Criterio, String Empresa)
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
        {
            var lstParam = new List<Parametro>();
            var sqlText = "";
            if (string.IsNullOrEmpty(Criterio))
            {
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
                sqlText = GetInstruccionSql<EmpresaConeccion>(TiposProcedimientosAlmacenados.Activo);
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
                lstParam.AddParametro("Empresa", Empresa);

            }
            else
            {
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
                sqlText = GetInstruccionSql<EmpresaConeccion>(TiposProcedimientosAlmacenados.CriterioActivos);
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
                lstParam.AddParametro("Criterio", Criterio);
                lstParam.AddParametro("Empresa", Empresa);

            }
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
            var lista = ExecuteGetLista<EmpresaConeccion>(sqlText, EsProcedimientoAlmacenado, lstParam.ToArray());
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
            return lista;
        }


        /// <summary>
        /// Lista de Todos los EmpresaConeccion que Inician por un Criterio
        /// </summary>
        /// <param name="Criterio">Criterio de Busqueda de la Clase</param>
        /// <param name="Empresa">Empresa de Trabajo Seleccionada</param>
        /// <returns>Lista de EmpresaConeccion</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
        public List<EmpresaConeccion> GetEmpresaConeccionInicia(string Criterio, String Empresa)
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
        {
            var lstParam = new List<Parametro>();
            var sqlText = "";
            if (string.IsNullOrEmpty(Criterio))
            {
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
                sqlText = GetInstruccionSql<EmpresaConeccion>(TiposProcedimientosAlmacenados.Todos);
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
                lstParam.AddParametro("Empresa", Empresa);

            }
            else
            {
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
                sqlText = GetInstruccionSql<EmpresaConeccion>(TiposProcedimientosAlmacenados.Inicia);
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
                lstParam.AddParametro("Criterio", Criterio);
                lstParam.AddParametro("Empresa", Empresa);

            }
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
            var lista = ExecuteGetLista<EmpresaConeccion>(sqlText, EsProcedimientoAlmacenado, lstParam.ToArray());
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
            return lista;
        }


        /// <summary>
        /// Busca un objeto EmpresaConeccion
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo</param>
        /// <returns>Objeto EmpresaConeccion</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
        public EmpresaConeccion GetUnEmpresaConeccion(string Empresa)
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
        {
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
            EmpresaConeccion menu = null;
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
            List<Parametro> pars = new List<Parametro>();
            pars.Add(new Parametro("Empresa", Empresa));
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
            menu = ExecuteGetUnLista<EmpresaConeccion>(GetInstruccionSql<EmpresaConeccion>(TiposProcedimientosAlmacenados.SoloUno), EsProcedimientoAlmacenado, pars.ToArray());
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
            return menu;
        }

        #endregion

        #region Metodos Sustituidos
        /// <summary>
        /// Lista de Valores de las EmpresaConeccion por Criterio
        /// </summary>
        /// <param name="criterio">Criterio de Busqueda</param>
        /// <param name="parametros">Lista de Parametros</param>
        /// <returns></returns>
        public override DataTable GetLista(string criterio, List<LiloSoft.Web.ProveedorWeb.LOVParams> parametros)
        {
            string Empresa = "";
            var par1 = from p in parametros
                       where p.Name.ToLower() == "empresa"
                       select p;
            if (par1 != null && par1.Count() > 0)
                Empresa = par1.First().Value.ToString();
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
            return Tablas<EmpresaConeccion>.ToDataTable(GetEmpresaConeccion(criterio, Empresa));
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
        }

        /// <summary>
        /// Lista de Valores de las EmpresaConeccion por Criterio Activos
        /// </summary>
        /// <param name="criterio">Criterio de Busqueda</param>
        /// <param name="parametros">Lista de Parametros</param>
        /// <returns></returns>
        public override DataTable GetListaActiva(string criterio, List<LiloSoft.Web.ProveedorWeb.LOVParams> parametros)
        {
            string Empresa = "";
            var par1 = from p in parametros
                       where p.Name.ToLower() == "empresa"
                       select p;
            if (par1 != null && par1.Count() > 0)
                Empresa = par1.First().Value.ToString();
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
            return Tablas<EmpresaConeccion>.ToDataTable(GetEmpresaConeccionActivo(criterio, Empresa));
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
        }

        #endregion

        #region Metodos de Cargue Excel
        /// <summary>
        /// Lista de MetaData para los Campos de la Tabla a Cargar
        /// </summary>
        /// <returns>Lista de MetaDataExcel de la Tabla</returns>
        public override List<MetaDataExcel> GetMetaData()
        {
            List<MetaDataExcel> lstMeta = new List<MetaDataExcel>();
            lstMeta.Add(new MetaDataExcel() { NombreCampo = "Empresa", DescripcionCampo = "Empresa de Trabajo", TipoDato = "Cadena", Tamaño = "6" });
            lstMeta.Add(new MetaDataExcel() { NombreCampo = "EmpresaEsculapio", DescripcionCampo = "Empresa en Esculapio", TipoDato = "Cadena", Tamaño = "10" });
            lstMeta.Add(new MetaDataExcel() { NombreCampo = "Servidor", DescripcionCampo = "Servidor de Base de Datos Esculapio", TipoDato = "Cadena", Tamaño = "50" });
            lstMeta.Add(new MetaDataExcel() { NombreCampo = "Puerto", DescripcionCampo = "Puerto del Servidor", TipoDato = "Cadena", Tamaño = "10" });
            lstMeta.Add(new MetaDataExcel() { NombreCampo = "BaseDatos", DescripcionCampo = "Base de Datos Servidor", TipoDato = "Cadena", Tamaño = "10" });
            lstMeta.Add(new MetaDataExcel() { NombreCampo = "Usuario", DescripcionCampo = "Usuario de Base de Datos", TipoDato = "Cadena", Tamaño = "50" });
            lstMeta.Add(new MetaDataExcel() { NombreCampo = "Clave", DescripcionCampo = "Clave de Usuario", TipoDato = "Cadena", Tamaño = "50" });
            lstMeta.Add(new MetaDataExcel() { NombreCampo = "Operacion", DescripcionCampo = "Operacion I:Ingresar A:Actualizar E:Eliminar", TipoDato = "Cadena", Tamaño = "1" });
            return lstMeta;
        }

        /// <summary>
        /// Cargue de Archivo de Excel de la Información en la Tabla
        /// </summary>
        /// <param name="pNombreArchivoExcel">Archivo de Excel a Cargar</param>
        /// <returns>Lista de Errore de la Carga</returns>
        public override List<ErroresCarga> CargarDatos(string pNombreArchivoExcel)
        {
            List<ErroresCarga> lstErrores = new List<ErroresCarga>();
            DataTable dtExcel = LiloSoft.Utils.Utilidades.CargarUnEXCEL(pNombreArchivoExcel, NombreHojaExcel, true);
            // Verificamos si hay Datos
            if (dtExcel != null && dtExcel.Rows.Count > 0)
            {
                int filas = 0;
                foreach (DataRow dr in dtExcel.Rows)
                {
                    try
                    {
                        string Operacion = "";
                        filas++;
                        // Verificamos si Tiene o No Datos el Registro Completo
                        if (
                              string.IsNullOrEmpty(dr["Empresa"].ToString()) &&
                              string.IsNullOrEmpty(dr["EmpresaEsculapio"].ToString()) &&
                              string.IsNullOrEmpty(dr["Servidor"].ToString()) &&
                              string.IsNullOrEmpty(dr["Puerto"].ToString()) &&
                              string.IsNullOrEmpty(dr["BaseDatos"].ToString()) &&
                              string.IsNullOrEmpty(dr["Usuario"].ToString()) &&
                              string.IsNullOrEmpty(dr["Clave"].ToString()))
                        {
                            break; // Salimos del Ciclo si el Registro esta Vacio Todo
                        }
                        // Empezamos a Crear el Objeto que Necesitamos
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
                        EmpresaConeccion dato = new EmpresaConeccion();
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
                        //
                        // Procesamos Empresa de Trabajo
                        //
                        try
                        {
                            dato.Empresa = dr["Empresa"].ToString();
                        }
                        catch (Exception ex)
                        {
                            lstErrores.Add(new ErroresCarga()
                            {
                                IdError = "Empresa de Trabajo Errado",
                                TextoError = ex.Message,
                                FilaNo = filas,
                                Info = dr["Empresa"].ToString()
                            });
                            continue;
                        }
                        //
                        // Procesamos Empresa en Esculapio
                        //
                        try
                        {
                            dato.EmpresaEsculapio = dr["EmpresaEsculapio"].ToString();
                        }
                        catch (Exception ex)
                        {
                            lstErrores.Add(new ErroresCarga()
                            {
                                IdError = "Empresa en Esculapio Errado",
                                TextoError = ex.Message,
                                FilaNo = filas,
                                Info = dr["EmpresaEsculapio"].ToString()
                            });
                            continue;
                        }
                        //
                        // Procesamos Servidor de Base de Datos Esculapio
                        //
                        try
                        {
                            dato.Servidor = dr["Servidor"].ToString();
                        }
                        catch (Exception ex)
                        {
                            lstErrores.Add(new ErroresCarga()
                            {
                                IdError = "Servidor de Base de Datos Esculapio Errado",
                                TextoError = ex.Message,
                                FilaNo = filas,
                                Info = dr["Servidor"].ToString()
                            });
                            continue;
                        }
                        //
                        // Procesamos Puerto del Servidor
                        //
                        try
                        {
                            dato.Puerto = dr["Puerto"].ToString();
                        }
                        catch (Exception ex)
                        {
                            lstErrores.Add(new ErroresCarga()
                            {
                                IdError = "Puerto del Servidor Errado",
                                TextoError = ex.Message,
                                FilaNo = filas,
                                Info = dr["Puerto"].ToString()
                            });
                            continue;
                        }
                        //
                        // Procesamos Base de Datos Servidor
                        //
                        try
                        {
                            dato.BaseDatos = dr["BaseDatos"].ToString();
                        }
                        catch (Exception ex)
                        {
                            lstErrores.Add(new ErroresCarga()
                            {
                                IdError = "Base de Datos Servidor Errado",
                                TextoError = ex.Message,
                                FilaNo = filas,
                                Info = dr["BaseDatos"].ToString()
                            });
                            continue;
                        }
                        //
                        // Procesamos Usuario de Base de Datos
                        //
                        try
                        {
                            dato.Usuario = dr["Usuario"].ToString();
                        }
                        catch (Exception ex)
                        {
                            lstErrores.Add(new ErroresCarga()
                            {
                                IdError = "Usuario de Base de Datos Errado",
                                TextoError = ex.Message,
                                FilaNo = filas,
                                Info = dr["Usuario"].ToString()
                            });
                            continue;
                        }
                        //
                        // Procesamos Clave de Usuario
                        //
                        try
                        {
                            dato.Clave = dr["Clave"].ToString();
                        }
                        catch (Exception ex)
                        {
                            lstErrores.Add(new ErroresCarga()
                            {
                                IdError = "Clave de Usuario Errado",
                                TextoError = ex.Message,
                                FilaNo = filas,
                                Info = dr["Clave"].ToString()
                            });
                            continue;
                        }

                        // 
                        // Procesamos la Operacion
                        //
                        try
                        {
                            Operacion = dr["Operacion"].ToString();
                        }
                        catch (Exception ex)
                        {
                            lstErrores.Add(new ErroresCarga()
                            {
                                IdError = "Operación Errado",
                                TextoError = ex.Message,
                                FilaNo = filas,
                                Info = dr["Operacion"].ToString()
                            });
                            continue;
                        }
                        // Buscamos el Objeto por su Llave Primaria
#pragma warning disable CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
                        EmpresaConeccion datoBase = GetUnEmpresaConeccion(dato.Empresa);
#pragma warning restore CS0436 // El tipo 'EmpresaConeccion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs' está en conflicto con el tipo importado 'EmpresaConeccion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EmpresaConeccion.cs'.
                        switch (Operacion.ToUpper())
                        {
                            case "I":
                                if (datoBase != null)
                                {
                                    lstErrores.Add(new ErroresCarga()
                                    {
                                        IdError = "Valor ya Existe",
                                        TextoError = "El Registro que Trata de Ingresar ya Existe",
                                        FilaNo = filas,
                                        Info = "Empresa:" + dato.Empresa
                                    });
                                    continue;
                                }
                                else
                                {
                                    Insert(dato);
                                }
                                break;
                            case "A":
                                if (datoBase == null)
                                {
                                    lstErrores.Add(new ErroresCarga()
                                    {
                                        IdError = "Valor No Existe",
                                        TextoError = "El Registro que Trata de Actualizar No Existe",
                                        FilaNo = filas,
                                        Info = "Empresa:" + dato.Empresa
                                    });
                                    continue;
                                }
                                else
                                {
                                    Update(dato);
                                }
                                break;
                            case "E":
                                if (datoBase == null)
                                {
                                    lstErrores.Add(new ErroresCarga()
                                    {
                                        IdError = "Valor No Existe",
                                        TextoError = "El Registro que Trata de Eliminar No Existe",
                                        FilaNo = filas,
                                        Info = "Empresa:" + dato.Empresa
                                    });
                                    continue;
                                }
                                else
                                {
                                    Delete(dato);
                                }
                                break;
                            default:
                                lstErrores.Add(new ErroresCarga()
                                {
                                    IdError = "Operación Es Invalida",
                                    TextoError = "Valor para la Operación es Inválida",
                                    FilaNo = filas,
                                    Info = Operacion
                                });
                                continue;
                        }
                    }// Fin Try
                    catch (Exception ex)
                    {
                        lstErrores.Add(new ErroresCarga()
                        {
                            IdError = "Error General",
                            TextoError = ex.Message,
                            FilaNo = filas,
                            Info = ""
                        });
                        continue;
                    }
                } // Fin de Foreach dtExcel
            } // Fin de Datos excel
            else
            {
                if (dtExcel == null)
                {
                    // No Hay Datos en Excel
                    lstErrores.Add(new ErroresCarga()
                    {
                        IdError = "Error Carga",
                        TextoError = (LiloSoft.Utils.Utilidades.UltimoError != null ? LiloSoft.Utils.Utilidades.UltimoError.Message : "Error No Especificado")
                    });

                }
                else
                {
                    // No Hay Datos en Excel
                    lstErrores.Add(new ErroresCarga()
                    {
                        IdError = "Sin Datos",
                        TextoError = "El Archivo No Tiene Datos"
                    });
                }
            }
            return lstErrores;
        }


        #endregion

    } // Fin Clase
} // Fin NameSpace


