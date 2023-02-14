
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
    /// Manejo de CondicionesFinacieras
    /// </summary>
    [DataObject(true)]
    [Description("Tabla de Condiciones Financieras Circular 016 2017")]
    public class CondicionesFinacierasDB : LiloSoft.Web.ProveedorWeb.BaseDB
    {
        #region Constructores
        /// <summary>
        /// Constructor por Defecto
        /// </summary>
        public CondicionesFinacierasDB()
        {
            ComportamientoIndividualComandos = true;
            TipoComandoIndividual = LiloSoft.Web.ProveedorWeb.TipoComando.InstruccionSQL;
        }
        /// <summary>
        /// Constructor con Objeto de Base de Datos
        /// </summary>
        /// <param name="db">Manejador de Bases de Datos</param>
        public CondicionesFinacierasDB(DB db)
          : this()
        {
            SqlDb = db;
        }
        #endregion


        #region Metodos de Acceso a Datos
        /// <summary>
        /// Insertar un Registro en CondicionesFinacieras
        /// </summary>
        /// <param name="m">Objeto CondicionesFinacieras a Insertar</param>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
        public void Insert(CondicionesFinacieras m)
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
        {
            List<Parametro> lst = GetParametros(m);
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
            if (!SqlDb.EjecutarComando(GetInstruccionSql<CondicionesFinacieras>(TiposProcedimientosAlmacenados.Insert), EsProcedimientoAlmacenado, lst.ToArray()))
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
            {
                throw new Exception(SqlDb.UltimoError);
            }
        }

        /// <summary>
        /// Actualizar un Registro en CondicionesFinacieras
        /// </summary>
        /// <param name="m">Objeto CondicionesFinacieras a Actualizar</param>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
        public void Update(CondicionesFinacieras m)
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
        {
            List<Parametro> lst = GetParametros(m);
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
            if (!SqlDb.EjecutarComando(GetInstruccionSql<CondicionesFinacieras>(TiposProcedimientosAlmacenados.Update), EsProcedimientoAlmacenado, lst.ToArray()))
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
            {
                throw new Exception(SqlDb.UltimoError);
            }
        }

        /// <summary>
        /// Eliminar un Registro CondicionesFinacieras
        /// </summary>
        /// <param name="m">Objeto CondicionesFinacieras a Eliminar</param>
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
        public void Delete(CondicionesFinacieras m)
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
        {
            List<Parametro> lst = GetParametros(m, true);
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
            if (!SqlDb.EjecutarComando(GetInstruccionSql<CondicionesFinacieras>(TiposProcedimientosAlmacenados.Delete), EsProcedimientoAlmacenado, lst.ToArray()))
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
            {
                throw new Exception(SqlDb.UltimoError);
            }
        }


        #endregion

        #region Metodos de Listas
        /// <summary>
        /// Lista de Todos los CondicionesFinacieras
        /// </summary>
        /// <param name="Criterio">Criterio de Busqueda de la Clase</param>
        /// <returns>Lista de CondicionesFinacieras</returns>
        [DataObjectMethod(DataObjectMethodType.Select, true)]
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
        public List<CondicionesFinacieras> GetCondicionesFinacieras(string Criterio)
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
        {
            var lstParam = new List<Parametro>();
            var sqlText = "";
            if (string.IsNullOrEmpty(Criterio))
            {
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
                sqlText = GetInstruccionSql<CondicionesFinacieras>(TiposProcedimientosAlmacenados.Todos);
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.

            }
            else
            {
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
                sqlText = GetInstruccionSql<CondicionesFinacieras>(TiposProcedimientosAlmacenados.Criterio);
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
                lstParam.AddParametro("Criterio", Criterio);

            }
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
            var lista = ExecuteGetLista<CondicionesFinacieras>(sqlText, EsProcedimientoAlmacenado, lstParam.ToArray());
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
            return lista;
        }

        /// <summary>
        /// Lista de Todos los CondicionesFinacieras con Criterio de Busqueda Entre Fechas
        /// </summary>
        /// <param name="FechaInicial">Fecha Inicial de Busqueda</param>
        /// <param name="FechaFinal">Fecha Final de Busqueda</param>
        /// <param name="Criterio">Criterio de Busqueda de la Clase</param>
        /// <returns>Lista de CondicionesFinacieras</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
        public List<CondicionesFinacieras> GetCondicionesFinacieras(string Criterio, Fecha FechaInicial, Fecha FechaFinal)
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
        {
            var lstParam = new List<Parametro>();
            var sqlText = "";
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
            sqlText = GetInstruccionSql<CondicionesFinacieras>(TiposProcedimientosAlmacenados.Fechas);
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
            lstParam.AddParametro("Criterio", Criterio);

            lstParam.AddParametro("FechaInicial", FechaInicial);
            lstParam.AddParametro("FechaFinal", FechaFinal);
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
            var lista = ExecuteGetLista<CondicionesFinacieras>(sqlText, EsProcedimientoAlmacenado, lstParam.ToArray());
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
            return lista;
        }


        /// <summary>
        /// Lista de Todos los CondicionesFinacieras
        /// </summary>      
        /// <returns>Lista de CondicionesFinacieras</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
        public List<CondicionesFinacieras> GetCondicionesFinacieras()
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
        {
            return GetCondicionesFinacieras("");
        }

        /// <summary>
        /// Lista de Todos los CondicionesFinacieras
        /// </summary>
        /// <returns>Lista de CondicionesFinacieras</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
        public List<CondicionesFinacieras> GetCondicionesFinacierasActivo()
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
        {
            return GetCondicionesFinacierasActivo("");
        }

        /// <summary>
        /// Lista de Todos los CondicionesFinacieras Activos
        /// </summary>
        /// <param name="Criterio">Criterio de Busqueda de la Clase</param>
        /// <returns>Lista de CondicionesFinacieras</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
        public List<CondicionesFinacieras> GetCondicionesFinacierasActivo(string Criterio)
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
        {
            var lstParam = new List<Parametro>();
            var sqlText = "";
            if (string.IsNullOrEmpty(Criterio))
            {
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
                sqlText = GetInstruccionSql<CondicionesFinacieras>(TiposProcedimientosAlmacenados.Activo);
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.

            }
            else
            {
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
                sqlText = GetInstruccionSql<CondicionesFinacieras>(TiposProcedimientosAlmacenados.CriterioActivos);
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
                lstParam.AddParametro("Criterio", Criterio);

            }
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
            var lista = ExecuteGetLista<CondicionesFinacieras>(sqlText, EsProcedimientoAlmacenado, lstParam.ToArray());
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
            return lista;
        }


        /// <summary>
        /// Lista de Todos los CondicionesFinacieras que Inician por un Criterio
        /// </summary>
        /// <param name="Criterio">Criterio de Busqueda de la Clase</param>
        /// <returns>Lista de CondicionesFinacieras</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
        public List<CondicionesFinacieras> GetCondicionesFinacierasInicia(string Criterio)
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
        {
            var lstParam = new List<Parametro>();
            var sqlText = "";
            if (string.IsNullOrEmpty(Criterio))
            {
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
                sqlText = GetInstruccionSql<CondicionesFinacieras>(TiposProcedimientosAlmacenados.Todos);
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.

            }
            else
            {
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
                sqlText = GetInstruccionSql<CondicionesFinacieras>(TiposProcedimientosAlmacenados.Inicia);
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
                lstParam.AddParametro("Criterio", Criterio);

            }
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
            var lista = ExecuteGetLista<CondicionesFinacieras>(sqlText, EsProcedimientoAlmacenado, lstParam.ToArray());
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
            return lista;
        }


        /// <summary>
        /// Busca un objeto CondicionesFinacieras
        /// </summary>
        /// <param name="CodConcepto">Código Concepto</param>
        /// <returns>Objeto CondicionesFinacieras</returns>
        [DataObjectMethod(DataObjectMethodType.Select, false)]
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
        public CondicionesFinacieras GetUnCondicionesFinacieras(Entero CodConcepto)
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
        {
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
            CondicionesFinacieras menu = null;
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
            List<Parametro> pars = new List<Parametro>();
            pars.Add(new Parametro("CodConcepto", CodConcepto));
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
            menu = ExecuteGetUnLista<CondicionesFinacieras>(GetInstruccionSql<CondicionesFinacieras>(TiposProcedimientosAlmacenados.SoloUno), EsProcedimientoAlmacenado, pars.ToArray());
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
            return menu;
        }

        #endregion

        #region Metodos Sustituidos
        /// <summary>
        /// Lista de Valores de las CondicionesFinacieras por Criterio
        /// </summary>
        /// <param name="criterio">Criterio de Busqueda</param>
        /// <param name="parametros">Lista de Parametros</param>
        /// <returns></returns>
        public override DataTable GetLista(string criterio, List<LiloSoft.Web.ProveedorWeb.LOVParams> parametros)
        {
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
            return Tablas<CondicionesFinacieras>.ToDataTable(GetCondicionesFinacieras(criterio));
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
        }

        /// <summary>
        /// Lista de Valores de las CondicionesFinacieras por Criterio Activos
        /// </summary>
        /// <param name="criterio">Criterio de Busqueda</param>
        /// <param name="parametros">Lista de Parametros</param>
        /// <returns></returns>
        public override DataTable GetListaActiva(string criterio, List<LiloSoft.Web.ProveedorWeb.LOVParams> parametros)
        {
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
            return Tablas<CondicionesFinacieras>.ToDataTable(GetCondicionesFinacierasActivo(criterio));
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
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
            lstMeta.Add(new MetaDataExcel() { NombreCampo = "CodConcepto", DescripcionCampo = "Código Concepto", TipoDato = "Entero", Tamaño = "" });
            lstMeta.Add(new MetaDataExcel() { NombreCampo = "NombreConcepto", DescripcionCampo = "Descripción del Concepto", TipoDato = "Cadena", Tamaño = "500" });
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
                              string.IsNullOrEmpty(dr["CodConcepto"].ToString()) &&
                              string.IsNullOrEmpty(dr["NombreConcepto"].ToString()) &&
                              string.IsNullOrEmpty(dr["Estado"].ToString()))
                        {
                            break; // Salimos del Ciclo si el Registro esta Vacio Todo
                        }
                        // Empezamos a Crear el Objeto que Necesitamos
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
                        CondicionesFinacieras dato = new CondicionesFinacieras();
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
                        //
                        // Procesamos Código Concepto
                        //
                        try
                        {
                            dato.CodConcepto = Entero.Parse(dr["CodConcepto"].ToString());
                        }
                        catch (Exception ex)
                        {
                            lstErrores.Add(new ErroresCarga()
                            {
                                IdError = "Código Concepto Errado",
                                TextoError = ex.Message,
                                FilaNo = filas,
                                Info = dr["CodConcepto"].ToString()
                            });
                            continue;
                        }
                        //
                        // Procesamos Descripción del Concepto
                        //
                        try
                        {
                            dato.NombreConcepto = dr["NombreConcepto"].ToString();
                        }
                        catch (Exception ex)
                        {
                            lstErrores.Add(new ErroresCarga()
                            {
                                IdError = "Descripción del Concepto Errado",
                                TextoError = ex.Message,
                                FilaNo = filas,
                                Info = dr["NombreConcepto"].ToString()
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
#pragma warning disable CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
                        CondicionesFinacieras datoBase = GetUnCondicionesFinacieras(dato.CodConcepto);
#pragma warning restore CS0436 // El tipo 'CondicionesFinacieras' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs' está en conflicto con el tipo importado 'CondicionesFinacieras' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\CondicionesFinacieras.cs'.
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
                                        Info = "CodConcepto:" + dato.CodConcepto
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
                                        Info = "CodConcepto:" + dato.CodConcepto
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
                                        Info = "CodConcepto:" + dato.CodConcepto
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


