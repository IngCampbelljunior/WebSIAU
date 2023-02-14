
using LiloSoft.DataBase.ConectaDB;
using LiloSoft.Types.Data;
using LiloSoft.Utils;
using LiloSoft.Web.ProveedorWeb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace LiloSoft.Siesa.Interfaz.Circular016
{
    /// <summary>
    /// Manejo de TiposArchivos
    /// </summary>
    [DataObject(true)]
    [Description("Tipos de Archivos Circular 016 2016")]
    public class TiposArchivosDB : LiloSoft.Web.ProveedorWeb.BaseDB
    {
        #region Constructores
        /// <summary>
        /// Constructor por Defecto
        /// </summary>
        public TiposArchivosDB()
        {
            ComportamientoIndividualComandos = true;
            TipoComandoIndividual = LiloSoft.Web.ProveedorWeb.TipoComando.InstruccionSQL;
        }
        /// <summary>
        /// Constructor con Objeto de Base de Datos
        /// </summary>
        /// <param name="db">Manejador de Bases de Datos</param>
        public TiposArchivosDB(DB db)
          : this()
        {
            SqlDb = db;
        }
        #endregion


        #region Metodos de Acceso a Datos
        /// <summary>
        /// Insertar un Registro en TiposArchivos
        /// </summary>
        /// <param name="m">Objeto TiposArchivos a Insertar</param>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
        public void Insert(TiposArchivos m)
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
        {
            List<Parametro> lst = GetParametros(m);
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
            if (!SqlDb.EjecutarComando(GetInstruccionSql<TiposArchivos>(TiposProcedimientosAlmacenados.Insert), EsProcedimientoAlmacenado, lst.ToArray()))
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
            {
                throw new Exception(SqlDb.UltimoError);
            }
        }

        /// <summary>
        /// Actualizar un Registro en TiposArchivos
        /// </summary>
        /// <param name="m">Objeto TiposArchivos a Actualizar</param>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
        public void Update(TiposArchivos m)
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
        {
            List<Parametro> lst = GetParametros(m);
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
            if (!SqlDb.EjecutarComando(GetInstruccionSql<TiposArchivos>(TiposProcedimientosAlmacenados.Update), EsProcedimientoAlmacenado, lst.ToArray()))
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
            {
                throw new Exception(SqlDb.UltimoError);
            }
        }

        /// <summary>
        /// Eliminar un Registro TiposArchivos
        /// </summary>
        /// <param name="m">Objeto TiposArchivos a Eliminar</param>
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
        public void Delete(TiposArchivos m)
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
        {
            List<Parametro> lst = GetParametros(m, true);
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
            if (!SqlDb.EjecutarComando(GetInstruccionSql<TiposArchivos>(TiposProcedimientosAlmacenados.Delete), EsProcedimientoAlmacenado, lst.ToArray()))
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
            {
                throw new Exception(SqlDb.UltimoError);
            }
        }


        #endregion

        #region Metodos de Listas
        /// <summary>
        /// Lista de Todos los TiposArchivos
        /// </summary>
        /// <param name="Criterio">Criterio de Busqueda de la Clase</param>
        /// <returns>Lista de TiposArchivos</returns>
        [DataObjectMethod(DataObjectMethodType.Select, true)]
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
        public List<TiposArchivos> GetTiposArchivos(string Criterio)
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
        {
            var lstParam = new List<Parametro>();
            var sqlText = "";
            if (string.IsNullOrEmpty(Criterio))
            {
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
                sqlText = GetInstruccionSql<TiposArchivos>(TiposProcedimientosAlmacenados.Todos);
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.

            }
            else
            {
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
                sqlText = GetInstruccionSql<TiposArchivos>(TiposProcedimientosAlmacenados.Criterio);
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
                lstParam.AddParametro("Criterio", Criterio);

            }
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
            var lista = ExecuteGetLista<TiposArchivos>(sqlText, EsProcedimientoAlmacenado, lstParam.ToArray());
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
            return lista;
        }

        /// <summary>
        /// Lista de Todos los TiposArchivos con Criterio de Busqueda Entre Fechas
        /// </summary>
        /// <param name="FechaInicial">Fecha Inicial de Busqueda</param>
        /// <param name="FechaFinal">Fecha Final de Busqueda</param>
        /// <param name="Criterio">Criterio de Busqueda de la Clase</param>
        /// <returns>Lista de TiposArchivos</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
        public List<TiposArchivos> GetTiposArchivos(string Criterio, Fecha FechaInicial, Fecha FechaFinal)
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
        {
            var lstParam = new List<Parametro>();
            var sqlText = "";
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
            sqlText = GetInstruccionSql<TiposArchivos>(TiposProcedimientosAlmacenados.Fechas);
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
            lstParam.AddParametro("Criterio", Criterio);

            lstParam.AddParametro("FechaInicial", FechaInicial);
            lstParam.AddParametro("FechaFinal", FechaFinal);
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
            var lista = ExecuteGetLista<TiposArchivos>(sqlText, EsProcedimientoAlmacenado, lstParam.ToArray());
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
            return lista;
        }


        /// <summary>
        /// Lista de Todos los TiposArchivos
        /// </summary>      
        /// <returns>Lista de TiposArchivos</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
        public List<TiposArchivos> GetTiposArchivos()
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
        {
            return GetTiposArchivos("");
        }

        /// <summary>
        /// Lista de Todos los TiposArchivos
        /// </summary>
        /// <returns>Lista de TiposArchivos</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
        public List<TiposArchivos> GetTiposArchivosActivo()
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
        {
            return GetTiposArchivosActivo("");
        }

        /// <summary>
        /// Lista de Todos los TiposArchivos Activos
        /// </summary>
        /// <param name="Criterio">Criterio de Busqueda de la Clase</param>
        /// <returns>Lista de TiposArchivos</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
        public List<TiposArchivos> GetTiposArchivosActivo(string Criterio)
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
        {
            var lstParam = new List<Parametro>();
            var sqlText = "";
            if (string.IsNullOrEmpty(Criterio))
            {
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
                sqlText = GetInstruccionSql<TiposArchivos>(TiposProcedimientosAlmacenados.Activo);
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.

            }
            else
            {
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
                sqlText = GetInstruccionSql<TiposArchivos>(TiposProcedimientosAlmacenados.CriterioActivos);
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
                lstParam.AddParametro("Criterio", Criterio);

            }
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
            var lista = ExecuteGetLista<TiposArchivos>(sqlText, EsProcedimientoAlmacenado, lstParam.ToArray());
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
            return lista;
        }


        /// <summary>
        /// Lista de Todos los TiposArchivos que Inician por un Criterio
        /// </summary>
        /// <param name="Criterio">Criterio de Busqueda de la Clase</param>
        /// <returns>Lista de TiposArchivos</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
        public List<TiposArchivos> GetTiposArchivosInicia(string Criterio)
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
        {
            var lstParam = new List<Parametro>();
            var sqlText = "";
            if (string.IsNullOrEmpty(Criterio))
            {
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
                sqlText = GetInstruccionSql<TiposArchivos>(TiposProcedimientosAlmacenados.Todos);
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.

            }
            else
            {
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
                sqlText = GetInstruccionSql<TiposArchivos>(TiposProcedimientosAlmacenados.Inicia);
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
                lstParam.AddParametro("Criterio", Criterio);

            }
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
            var lista = ExecuteGetLista<TiposArchivos>(sqlText, EsProcedimientoAlmacenado, lstParam.ToArray());
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
            return lista;
        }


        /// <summary>
        /// Busca un objeto TiposArchivos
        /// </summary>
        /// <param name="CodTipoArchivo">Tipo Archivo</param>
        /// <returns>Objeto TiposArchivos</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
        public TiposArchivos GetUnTiposArchivos(string CodTipoArchivo)
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
        {
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
            TiposArchivos menu = null;
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
            List<Parametro> pars = new List<Parametro>();
            pars.Add(new Parametro("CodTipoArchivo", CodTipoArchivo));
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
            menu = ExecuteGetUnLista<TiposArchivos>(GetInstruccionSql<TiposArchivos>(TiposProcedimientosAlmacenados.SoloUno), EsProcedimientoAlmacenado, pars.ToArray());
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
            return menu;
        }

        #endregion

        #region Metodos Sustituidos
        /// <summary>
        /// Lista de Valores de las TiposArchivos por Criterio
        /// </summary>
        /// <param name="criterio">Criterio de Busqueda</param>
        /// <param name="parametros">Lista de Parametros</param>
        /// <returns></returns>
        public override DataTable GetLista(string criterio, List<LiloSoft.Web.ProveedorWeb.LOVParams> parametros)
        {
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
            return Tablas<TiposArchivos>.ToDataTable(GetTiposArchivos(criterio));
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
        }

        /// <summary>
        /// Lista de Valores de las TiposArchivos por Criterio Activos
        /// </summary>
        /// <param name="criterio">Criterio de Busqueda</param>
        /// <param name="parametros">Lista de Parametros</param>
        /// <returns></returns>
        public override DataTable GetListaActiva(string criterio, List<LiloSoft.Web.ProveedorWeb.LOVParams> parametros)
        {
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
            return Tablas<TiposArchivos>.ToDataTable(GetTiposArchivosActivo(criterio));
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
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
            lstMeta.Add(new MetaDataExcel() { NombreCampo = "CodTipoArchivo", DescripcionCampo = "Tipo Archivo", TipoDato = "Cadena", Tamaño = "10" });
            lstMeta.Add(new MetaDataExcel() { NombreCampo = "NombreTipoArchivo", DescripcionCampo = "Descripción del Tipo de Archivo", TipoDato = "Cadena", Tamaño = "200" });
            lstMeta.Add(new MetaDataExcel() { NombreCampo = "Estado", DescripcionCampo = "Estado Activo Inactivo", TipoDato = "Cadena", Tamaño = "1" });
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
                              string.IsNullOrEmpty(dr["CodTipoArchivo"].ToString()) &&
                              string.IsNullOrEmpty(dr["NombreTipoArchivo"].ToString()) &&
                              string.IsNullOrEmpty(dr["Estado"].ToString()))
                        {
                            break; // Salimos del Ciclo si el Registro esta Vacio Todo
                        }
                        // Empezamos a Crear el Objeto que Necesitamos
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
                        TiposArchivos dato = new TiposArchivos();
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
                        //
                        // Procesamos Tipo Archivo
                        //
                        try
                        {
                            dato.CodTipoArchivo = dr["CodTipoArchivo"].ToString();
                        }
                        catch (Exception ex)
                        {
                            lstErrores.Add(new ErroresCarga()
                            {
                                IdError = "Tipo Archivo Errado",
                                TextoError = ex.Message,
                                FilaNo = filas,
                                Info = dr["CodTipoArchivo"].ToString()
                            });
                            continue;
                        }
                        //
                        // Procesamos Descripción del Tipo de Archivo
                        //
                        try
                        {
                            dato.NombreTipoArchivo = dr["NombreTipoArchivo"].ToString();
                        }
                        catch (Exception ex)
                        {
                            lstErrores.Add(new ErroresCarga()
                            {
                                IdError = "Descripción del Tipo de Archivo Errado",
                                TextoError = ex.Message,
                                FilaNo = filas,
                                Info = dr["NombreTipoArchivo"].ToString()
                            });
                            continue;
                        }
                        //
                        // Procesamos Estado Activo Inactivo
                        //
                        try
                        {
                            dato.Estado = dr["Estado"].ToString();
                        }
                        catch (Exception ex)
                        {
                            lstErrores.Add(new ErroresCarga()
                            {
                                IdError = "Estado Activo Inactivo Errado",
                                TextoError = ex.Message,
                                FilaNo = filas,
                                Info = dr["Estado"].ToString()
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
#pragma warning disable CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
                        TiposArchivos datoBase = GetUnTiposArchivos(dato.CodTipoArchivo);
#pragma warning restore CS0436 // El tipo 'TiposArchivos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs' está en conflicto con el tipo importado 'TiposArchivos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\TiposArchivos.cs'.
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
                                        Info = "CodTipoArchivo:" + dato.CodTipoArchivo
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
                                        Info = "CodTipoArchivo:" + dato.CodTipoArchivo
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
                                        Info = "CodTipoArchivo:" + dato.CodTipoArchivo
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


