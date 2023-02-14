using LiloSoft.DataBase.ConectaDB;
using LiloSoft.Web.ProveedorWeb;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace LiloSoft.Siesa.Interfaz
{
    public class EventoAdversoDB : LiloSoft.Web.ProveedorWeb.BaseDB
    {

        #region Constructores
        /// <summary>
        /// Constructor por Defecto
        /// </summary>
        public EventoAdversoDB()
        {
            ComportamientoIndividualComandos = true;
            TipoComandoIndividual = LiloSoft.Web.ProveedorWeb.TipoComando.InstruccionSQL;
        }
        /// <summary>
        /// Constructor con Objeto de Base de Datos
        /// </summary>
        /// <param name="db">Manejador de Bases de Datos</param>
        public EventoAdversoDB(DB db)
          : this()
        {
            SqlDb = db;
        }
        #endregion


        #region Metodos de Acceso a Datos
        /// <summary>
        /// Insertar un Registro en Evento Adv
        /// </summary>
        /// <param name="m">Objeto CiudadesConexion a Insertar</param>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
#pragma warning disable CS0436 // El tipo 'EventoAdverso' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs' está en conflicto con el tipo importado 'EventoAdverso' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs'.
        public void Insert(EventoAdverso m)
#pragma warning restore CS0436 // El tipo 'EventoAdverso' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs' está en conflicto con el tipo importado 'EventoAdverso' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs'.
        {
            List<Parametro> lst = GetParametros(m);
#pragma warning disable CS0436 // El tipo 'EventoAdverso' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs' está en conflicto con el tipo importado 'EventoAdverso' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs'.
            var sql = GetInstruccionSql<EventoAdverso>(TiposProcedimientosAlmacenados.Insert);
#pragma warning restore CS0436 // El tipo 'EventoAdverso' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs' está en conflicto con el tipo importado 'EventoAdverso' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs'.
#pragma warning disable CS0436 // El tipo 'EventoAdverso' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs' está en conflicto con el tipo importado 'EventoAdverso' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs'.
            if (!SqlDb.EjecutarComando(GetInstruccionSql<EventoAdverso>(TiposProcedimientosAlmacenados.Insert), EsProcedimientoAlmacenado, lst.ToArray()))
#pragma warning restore CS0436 // El tipo 'EventoAdverso' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs' está en conflicto con el tipo importado 'EventoAdverso' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs'.
            {
                throw new Exception(SqlDb.UltimoError);
            }
        }

        /// <summary>
        /// Actualizar un Registro en Evento Adv
        /// </summary>
        /// <param name="m">Objeto Eventoadverso a Actualizar</param>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
#pragma warning disable CS0436 // El tipo 'EventoAdverso' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs' está en conflicto con el tipo importado 'EventoAdverso' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs'.
        public void Update(EventoAdverso m)
#pragma warning restore CS0436 // El tipo 'EventoAdverso' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs' está en conflicto con el tipo importado 'EventoAdverso' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs'.
        {
            List<Parametro> lst = GetParametros(m);
#pragma warning disable CS0436 // El tipo 'EventoAdverso' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs' está en conflicto con el tipo importado 'EventoAdverso' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs'.
            if (!SqlDb.EjecutarComando(GetInstruccionSql<EventoAdverso>(TiposProcedimientosAlmacenados.Update), EsProcedimientoAlmacenado, lst.ToArray()))
#pragma warning restore CS0436 // El tipo 'EventoAdverso' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs' está en conflicto con el tipo importado 'EventoAdverso' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs'.
            {
                throw new Exception(SqlDb.UltimoError);
            }
        }

        /// <summary>
        /// Eliminar un Registro Evento Adv
        /// </summary>
        /// <param name="m">Objeto EventoAdverso a Eliminar</param>
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
#pragma warning disable CS0436 // El tipo 'EventoAdverso' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs' está en conflicto con el tipo importado 'EventoAdverso' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs'.
        public void Delete(EventoAdverso m)
#pragma warning restore CS0436 // El tipo 'EventoAdverso' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs' está en conflicto con el tipo importado 'EventoAdverso' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs'.
        {
            List<Parametro> lst = GetParametros(m, true);
#pragma warning disable CS0436 // El tipo 'EventoAdverso' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs' está en conflicto con el tipo importado 'EventoAdverso' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs'.
            if (!SqlDb.EjecutarComando(GetInstruccionSql<EventoAdverso>(TiposProcedimientosAlmacenados.Delete), EsProcedimientoAlmacenado, lst.ToArray()))
#pragma warning restore CS0436 // El tipo 'EventoAdverso' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs' está en conflicto con el tipo importado 'EventoAdverso' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs'.
            {
                throw new Exception(SqlDb.UltimoError);
            }
        }


        #endregion



        #region Metodos de Listas
        /// <summary>
        /// Lista de Todos los Convenios
        /// </summary>
        /// <param name="Criterio">Criterio de Busqueda de la Clase</param>
        /// <param name="Empresa">Empresa de Trabajo Seleccionada</param>
        /// <returns>Lista de Convenios</returns>
        [DataObjectMethod(DataObjectMethodType.Select, true)]
#pragma warning disable CS0436 // El tipo 'EventoAdverso' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs' está en conflicto con el tipo importado 'EventoAdverso' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs'.
        public List<EventoAdverso> GetEventosAdv(string Criterio, String Empresa)
#pragma warning restore CS0436 // El tipo 'EventoAdverso' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs' está en conflicto con el tipo importado 'EventoAdverso' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs'.
        {
            var lstParam = new List<Parametro>();
            var sqlText = "";
            if (string.IsNullOrEmpty(Criterio))
            {
#pragma warning disable CS0436 // El tipo 'EventoAdverso' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs' está en conflicto con el tipo importado 'EventoAdverso' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs'.
                sqlText = GetInstruccionSql<EventoAdverso>(TiposProcedimientosAlmacenados.Todos);
#pragma warning restore CS0436 // El tipo 'EventoAdverso' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs' está en conflicto con el tipo importado 'EventoAdverso' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs'.
                lstParam.AddParametro("Empresa", Empresa);

            }
            else
            {
#pragma warning disable CS0436 // El tipo 'EventoAdverso' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs' está en conflicto con el tipo importado 'EventoAdverso' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs'.
                sqlText = GetInstruccionSql<EventoAdverso>(TiposProcedimientosAlmacenados.Criterio);
#pragma warning restore CS0436 // El tipo 'EventoAdverso' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs' está en conflicto con el tipo importado 'EventoAdverso' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs'.
                lstParam.AddParametro("Criterio", Criterio);
                lstParam.AddParametro("Empresa", Empresa);

            }
#pragma warning disable CS0436 // El tipo 'EventoAdverso' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs' está en conflicto con el tipo importado 'EventoAdverso' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs'.
            var lista = ExecuteGetLista<EventoAdverso>(sqlText, EsProcedimientoAlmacenado, lstParam.ToArray());
#pragma warning restore CS0436 // El tipo 'EventoAdverso' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs' está en conflicto con el tipo importado 'EventoAdverso' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\EventoAdverso.cs'.
            return lista;
        }
        #endregion
    }
}
