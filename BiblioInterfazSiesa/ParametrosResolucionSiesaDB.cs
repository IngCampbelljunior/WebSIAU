
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
    /// Manejo de ParametrosResolucionSiesa
    /// </summary>
    [DataObject(true)]
    [Description("Parametrización de Documentos Por Resolución de Facturación")]
    public class ParametrosResolucionSiesaDB : LiloSoft.Web.ProveedorWeb.BaseDB
    {
        #region Constructores
        /// <summary>
        /// Constructor por Defecto
        /// </summary>
        public ParametrosResolucionSiesaDB()
        {
            ComportamientoIndividualComandos = true;
            TipoComandoIndividual = LiloSoft.Web.ProveedorWeb.TipoComando.InstruccionSQL;
        }
        /// <summary>
        /// Constructor con Objeto de Base de Datos
        /// </summary>
        /// <param name="db">Manejador de Bases de Datos</param>
        public ParametrosResolucionSiesaDB(DB db)
          : this()
        {
            SqlDb = db;
        }
        #endregion


        #region Metodos de Acceso a Datos
        /// <summary>
        /// Insertar un Registro en ParametrosResolucionSiesa
        /// </summary>
        /// <param name="m">Objeto ParametrosResolucionSiesa a Insertar</param>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
        public void Insert(ParametrosResolucionSiesa m)
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
        {
            List<Parametro> lst = GetParametros(m);
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
            if (!SqlDb.EjecutarComando(GetInstruccionSql<ParametrosResolucionSiesa>(TiposProcedimientosAlmacenados.Insert), EsProcedimientoAlmacenado, lst.ToArray()))
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
            {
                throw new Exception(SqlDb.UltimoError);
            }
        }

        /// <summary>
        /// Actualizar un Registro en ParametrosResolucionSiesa
        /// </summary>
        /// <param name="m">Objeto ParametrosResolucionSiesa a Actualizar</param>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
        public void Update(ParametrosResolucionSiesa m)
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
        {
            List<Parametro> lst = GetParametros(m);
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
            if (!SqlDb.EjecutarComando(GetInstruccionSql<ParametrosResolucionSiesa>(TiposProcedimientosAlmacenados.Update), EsProcedimientoAlmacenado, lst.ToArray()))
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
            {
                throw new Exception(SqlDb.UltimoError);
            }
        }

        /// <summary>
        /// Eliminar un Registro ParametrosResolucionSiesa
        /// </summary>
        /// <param name="m">Objeto ParametrosResolucionSiesa a Eliminar</param>
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
        public void Delete(ParametrosResolucionSiesa m)
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
        {
            List<Parametro> lst = GetParametros(m, true);
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
            if (!SqlDb.EjecutarComando(GetInstruccionSql<ParametrosResolucionSiesa>(TiposProcedimientosAlmacenados.Delete), EsProcedimientoAlmacenado, lst.ToArray()))
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
            {
                throw new Exception(SqlDb.UltimoError);
            }
        }


        #endregion

        #region Metodos de Listas
        /// <summary>
        /// Lista de Todos los ParametrosResolucionSiesa
        /// </summary>
        /// <param name="Criterio">Criterio de Busqueda de la Clase</param>
        /// <param name="Empresa">Empresa de Trabajo Seleccionada</param>
        /// <returns>Lista de ParametrosResolucionSiesa</returns>
        [DataObjectMethod(DataObjectMethodType.Select, true)]
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
        public List<ParametrosResolucionSiesa> GetParametrosResolucionSiesa(string Criterio, String Empresa)
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
        {
            var lstParam = new List<Parametro>();
            var sqlText = "";
            if (string.IsNullOrEmpty(Criterio))
            {
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
                sqlText = GetInstruccionSql<ParametrosResolucionSiesa>(TiposProcedimientosAlmacenados.Todos);
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
                lstParam.AddParametro("Empresa", Empresa);

            }
            else
            {
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
                sqlText = GetInstruccionSql<ParametrosResolucionSiesa>(TiposProcedimientosAlmacenados.Criterio);
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
                lstParam.AddParametro("Criterio", Criterio);
                lstParam.AddParametro("Empresa", Empresa);

            }
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
            var lista = ExecuteGetLista<ParametrosResolucionSiesa>(sqlText, EsProcedimientoAlmacenado, lstParam.ToArray());
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
            return lista;
        }

        /// <summary>
        /// Lista de Todos los ParametrosResolucionSiesa
        /// </summary>      
        /// <param name="Empresa">Empresa de Trabajo Seleccionada</param>
        /// <returns>Lista de ParametrosResolucionSiesa</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
        public List<ParametrosResolucionSiesa> GetParametrosResolucionSiesa(String Empresa)
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
        {
            return GetParametrosResolucionSiesa("", Empresa);
        }

        /// <summary>
        /// Lista de Todos los ParametrosResolucionSiesa
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo Seleccionada</param>
        /// <returns>Lista de ParametrosResolucionSiesa</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
        public List<ParametrosResolucionSiesa> GetParametrosResolucionSiesaActivo(String Empresa)
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
        {
            return GetParametrosResolucionSiesaActivo("", Empresa);
        }

        /// <summary>
        /// Lista de Todos los ParametrosResolucionSiesa Activos
        /// </summary>
        /// <param name="Criterio">Criterio de Busqueda de la Clase</param>
        /// <param name="Empresa">Empresa de Trabajo Seleccionada</param>
        /// <returns>Lista de ParametrosResolucionSiesa</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
        public List<ParametrosResolucionSiesa> GetParametrosResolucionSiesaActivo(string Criterio, String Empresa)
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
        {
            var lstParam = new List<Parametro>();
            var sqlText = "";
            if (string.IsNullOrEmpty(Criterio))
            {
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
                sqlText = GetInstruccionSql<ParametrosResolucionSiesa>(TiposProcedimientosAlmacenados.Activo);
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
                lstParam.AddParametro("Empresa", Empresa);

            }
            else
            {
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
                sqlText = GetInstruccionSql<ParametrosResolucionSiesa>(TiposProcedimientosAlmacenados.CriterioActivos);
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
                lstParam.AddParametro("Criterio", Criterio);
                lstParam.AddParametro("Empresa", Empresa);

            }
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
            var lista = ExecuteGetLista<ParametrosResolucionSiesa>(sqlText, EsProcedimientoAlmacenado, lstParam.ToArray());
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
            return lista;
        }


        /// <summary>
        /// Lista de Todos los ParametrosResolucionSiesa que Inician por un Criterio
        /// </summary>
        /// <param name="Criterio">Criterio de Busqueda de la Clase</param>
        /// <param name="Empresa">Empresa de Trabajo Seleccionada</param>
        /// <returns>Lista de ParametrosResolucionSiesa</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
        public List<ParametrosResolucionSiesa> GetParametrosResolucionSiesaInicia(string Criterio, String Empresa)
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
        {
            var lstParam = new List<Parametro>();
            var sqlText = "";
            if (string.IsNullOrEmpty(Criterio))
            {
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
                sqlText = GetInstruccionSql<ParametrosResolucionSiesa>(TiposProcedimientosAlmacenados.Todos);
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
                lstParam.AddParametro("Empresa", Empresa);

            }
            else
            {
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
                sqlText = GetInstruccionSql<ParametrosResolucionSiesa>(TiposProcedimientosAlmacenados.Inicia);
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
                lstParam.AddParametro("Criterio", Criterio);
                lstParam.AddParametro("Empresa", Empresa);

            }
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
            var lista = ExecuteGetLista<ParametrosResolucionSiesa>(sqlText, EsProcedimientoAlmacenado, lstParam.ToArray());
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
            return lista;
        }


        /// <summary>
        /// Busca un objeto ParametrosResolucionSiesa
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo</param>
        /// <param name="NoResolucion">No. de Resolución</param>
        /// <returns>Objeto ParametrosResolucionSiesa</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
        public ParametrosResolucionSiesa GetUnParametrosResolucionSiesa(string Empresa, string NoResolucion)
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
        {
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
            ParametrosResolucionSiesa menu = null;
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
            List<Parametro> pars = new List<Parametro>();
            pars.Add(new Parametro("Empresa", Empresa));
            pars.Add(new Parametro("NoResolucion", NoResolucion));
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
            menu = ExecuteGetUnLista<ParametrosResolucionSiesa>(GetInstruccionSql<ParametrosResolucionSiesa>(TiposProcedimientosAlmacenados.SoloUno), EsProcedimientoAlmacenado, pars.ToArray());
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
            return menu;
        }

        #endregion

        #region Metodos Sustituidos
        /// <summary>
        /// Lista de Valores de las ParametrosResolucionSiesa por Criterio
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
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
            return Tablas<ParametrosResolucionSiesa>.ToDataTable(GetParametrosResolucionSiesa(criterio, Empresa));
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
        }

        /// <summary>
        /// Lista de Valores de las ParametrosResolucionSiesa por Criterio Activos
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
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
            return Tablas<ParametrosResolucionSiesa>.ToDataTable(GetParametrosResolucionSiesaActivo(criterio, Empresa));
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
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
            lstMeta.Add(new MetaDataExcel() { NombreCampo = "NoResolucion", DescripcionCampo = "No. de Resolución", TipoDato = "Cadena", Tamaño = "20" });
            lstMeta.Add(new MetaDataExcel() { NombreCampo = "CodTipoDocumentoFactura", DescripcionCampo = "Tipo de Documento Factura", TipoDato = "Cadena", Tamaño = "20" });
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
                              string.IsNullOrEmpty(dr["NoResolucion"].ToString()) &&
                              string.IsNullOrEmpty(dr["CodTipoDocumentoFactura"].ToString()))
                        {
                            break; // Salimos del Ciclo si el Registro esta Vacio Todo
                        }
                        // Empezamos a Crear el Objeto que Necesitamos
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
                        ParametrosResolucionSiesa dato = new ParametrosResolucionSiesa();
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
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
                        // Procesamos No. de Resolución
                        //
                        try
                        {
                            dato.NoResolucion = dr["NoResolucion"].ToString();
                        }
                        catch (Exception ex)
                        {
                            lstErrores.Add(new ErroresCarga()
                            {
                                IdError = "No. de Resolución Errado",
                                TextoError = ex.Message,
                                FilaNo = filas,
                                Info = dr["NoResolucion"].ToString()
                            });
                            continue;
                        }
                        //
                        // Procesamos Tipo de Documento Factura
                        //
                        try
                        {
                            dato.CodTipoDocumentoFactura = dr["CodTipoDocumentoFactura"].ToString();
                        }
                        catch (Exception ex)
                        {
                            lstErrores.Add(new ErroresCarga()
                            {
                                IdError = "Tipo de Documento Factura Errado",
                                TextoError = ex.Message,
                                FilaNo = filas,
                                Info = dr["CodTipoDocumentoFactura"].ToString()
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
#pragma warning disable CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
                        ParametrosResolucionSiesa datoBase = GetUnParametrosResolucionSiesa(dato.Empresa, dato.NoResolucion);
#pragma warning restore CS0436 // El tipo 'ParametrosResolucionSiesa' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs' está en conflicto con el tipo importado 'ParametrosResolucionSiesa' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\ParametrosResolucionSiesa.cs'.
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
                                        Info = "Empresa:" + dato.Empresa + "," + "NoResolucion:" + dato.NoResolucion
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
                                        Info = "Empresa:" + dato.Empresa + "," + "NoResolucion:" + dato.NoResolucion
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
                                        Info = "Empresa:" + dato.Empresa + "," + "NoResolucion:" + dato.NoResolucion
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


