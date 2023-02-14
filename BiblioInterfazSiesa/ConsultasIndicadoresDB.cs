using LiloSoft.DataBase.ConectaDB;
using LiloSoft.Siesa.Interfaz.Indicadores;
using LiloSoft.Types.Data;
using LiloSoft.Utils;
using LiloSoft.Web.ProveedorWeb;
using System.Collections.Generic;
using System.Text;

namespace LiloSoft.Siesa.Interfaz
{
    public class ConsultasIndicadoresDB : BaseDB
    {
        #region Constructores
        public ConsultasIndicadoresDB() : base() { }
        public ConsultasIndicadoresDB(DB SqlDb) : this()
        {
            this.SqlDb = SqlDb;
        }
        #endregion

        #region Consultas de Lista
        /// <summary>
        /// Datos para Indicador de Reingreso de Urgencias
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo</param>
        /// <param name="FechaInicial">Fecha Inicial</param>
        /// <param name="FechaFinal">Fecha Final</param>
        /// <param name="MarcadoReingreso">Marcado para Reingreso S:Los Marcados en Admisiones N:Los Potenciasles Reingresos de Acuerdo a la Norma</param>
        /// <returns></returns>
#pragma warning disable CS0436 // El tipo 'DataReingresoUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataReingresoUrgencias.cs' está en conflicto con el tipo importado 'DataReingresoUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataReingresoUrgencias.cs'.
        public List<DataReingresoUrgencias> GetIndicadorUrgencias(string Empresa, Fecha FechaInicial, Fecha FechaFinal, string MarcadoReingreso)
#pragma warning restore CS0436 // El tipo 'DataReingresoUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataReingresoUrgencias.cs' está en conflicto con el tipo importado 'DataReingresoUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataReingresoUrgencias.cs'.
        {
            var sql = "GetIndicadorUrgencias";
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", Empresa);
            lstPars.AddParametro("FechaInicial", FechaInicial);
            lstPars.AddParametro("FechaFinal", FechaFinal);
            lstPars.AddParametro("MarcadoReingreso", MarcadoReingreso);
#pragma warning disable CS0436 // El tipo 'DataReingresoUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataReingresoUrgencias.cs' está en conflicto con el tipo importado 'DataReingresoUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataReingresoUrgencias.cs'.
            return ExecuteGetLista<DataReingresoUrgencias>(sql, true, lstPars.ToArray());
#pragma warning restore CS0436 // El tipo 'DataReingresoUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataReingresoUrgencias.cs' está en conflicto con el tipo importado 'DataReingresoUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataReingresoUrgencias.cs'.
        }

#pragma warning disable CS0436 // El tipo 'PacientesPorServicio' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\PacientesPorServicio.cs' está en conflicto con el tipo importado 'PacientesPorServicio' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\PacientesPorServicio.cs'.
        public List<PacientesPorServicio> GetPacientesPorServicio(string Empresa, Fecha FechaInicial, Fecha FechaFinal, bool Urgencias = false, bool Camas = false, bool Cirugia = false, bool UnServicio = false, string CodServicio = "")
#pragma warning restore CS0436 // El tipo 'PacientesPorServicio' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\PacientesPorServicio.cs' está en conflicto con el tipo importado 'PacientesPorServicio' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\PacientesPorServicio.cs'.
        {
            var sql = "GetTotalPacientesServicio";
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", Empresa);
            lstPars.AddParametro("FechaInicial", FechaInicial);
            lstPars.AddParametro("FechaFinal", FechaFinal);
            lstPars.AddParametro("Urgencias", (Urgencias ? "S" : "N"));
            lstPars.AddParametro("Camas", Camas ? "S" : "N");
            lstPars.AddParametro("Cirugia", Cirugia ? "S" : "N");
            lstPars.AddParametro("UnServicio", UnServicio ? "S" : "N");
            lstPars.AddParametro("CodServicio", CodServicio);

#pragma warning disable CS0436 // El tipo 'PacientesPorServicio' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\PacientesPorServicio.cs' está en conflicto con el tipo importado 'PacientesPorServicio' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\PacientesPorServicio.cs'.
            return ExecuteGetLista<PacientesPorServicio>(sql, true, lstPars.ToArray());
#pragma warning restore CS0436 // El tipo 'PacientesPorServicio' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\PacientesPorServicio.cs' está en conflicto con el tipo importado 'PacientesPorServicio' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\PacientesPorServicio.cs'.
        }

        /// <summary>
        /// Datos para Indicador de Reingreso de Hospitalizacion
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo</param>
        /// <param name="FechaInicial">Fecha Inicial</param>
        /// <param name="FechaFinal">Fecha Final</param>
        /// <param name="MarcadoReingreso">Marcado para Reingreso S:Los Marcados en Admisiones N:Los Potenciasles Reingresos de Acuerdo a la Norma</param>
        /// <param name="CodServicio">Código del Servicio Particular</param>
        /// <param name="ServiciosCamas">Servicios que Manejan Camas T:Todos los Servicios U:Servicio Particular </param>
        /// <returns></returns>
#pragma warning disable CS0436 // El tipo 'DataReingresoHospitalizacion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataReingresoHospitalizacion.cs' está en conflicto con el tipo importado 'DataReingresoHospitalizacion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataReingresoHospitalizacion.cs'.
        public List<DataReingresoHospitalizacion> GetIndicadorHospitalizacion(string Empresa, Fecha FechaInicial, Fecha FechaFinal, string MarcadoReingreso, string ServiciosCamas, string CodServicio)
#pragma warning restore CS0436 // El tipo 'DataReingresoHospitalizacion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataReingresoHospitalizacion.cs' está en conflicto con el tipo importado 'DataReingresoHospitalizacion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataReingresoHospitalizacion.cs'.
        {
            var sql = "GetIndicadorHospitalizacion";
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", Empresa);
            lstPars.AddParametro("FechaInicial", FechaInicial);
            lstPars.AddParametro("FechaFinal", FechaFinal);
            lstPars.AddParametro("MarcadoReingreso", MarcadoReingreso);
            lstPars.AddParametro("ServiciosCamas", ServiciosCamas);
            lstPars.AddParametro("CodServicio", CodServicio);
#pragma warning disable CS0436 // El tipo 'DataReingresoHospitalizacion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataReingresoHospitalizacion.cs' está en conflicto con el tipo importado 'DataReingresoHospitalizacion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataReingresoHospitalizacion.cs'.
            return ExecuteGetLista<DataReingresoHospitalizacion>(sql, true, lstPars.ToArray());
#pragma warning restore CS0436 // El tipo 'DataReingresoHospitalizacion' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataReingresoHospitalizacion.cs' está en conflicto con el tipo importado 'DataReingresoHospitalizacion' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataReingresoHospitalizacion.cs'.
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Empresa">Empresa de Trabajo</param>
        /// <param name="FechaInicial">Fecha Inicial</param>
        /// <param name="FechaFinal">Fecha Final</param>
        /// <returns></returns>
#pragma warning disable CS0436 // El tipo 'DataIndicadorGeneral' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataIndicadorGeneral.cs' está en conflicto con el tipo importado 'DataIndicadorGeneral' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataIndicadorGeneral.cs'.
        public List<DataIndicadorGeneral> GetIndicadorGeneralPrimeraVez(string Empresa, Fecha FechaInicial, Fecha FechaFinal, bool SeleccionarPlanes, IEnumerable<string> Planes, bool SeleccionarOrigen, IEnumerable<string> Origenes)
#pragma warning restore CS0436 // El tipo 'DataIndicadorGeneral' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataIndicadorGeneral.cs' está en conflicto con el tipo importado 'DataIndicadorGeneral' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataIndicadorGeneral.cs'.
        {
#pragma warning disable CS0436 // El tipo 'DataIndicadorGeneral' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataIndicadorGeneral.cs' está en conflicto con el tipo importado 'DataIndicadorGeneral' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataIndicadorGeneral.cs'.
            List<DataIndicadorGeneral> lista = null;
#pragma warning restore CS0436 // El tipo 'DataIndicadorGeneral' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataIndicadorGeneral.cs' está en conflicto con el tipo importado 'DataIndicadorGeneral' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataIndicadorGeneral.cs'.
            try
            {
                var lstParamTable = new List<Parametro>();
                //var indexParam = 1;
                var sqlTable = new StringBuilder(@"
CREATE TEMPORARY TABLE IF NOT EXISTS SelectPlanTmp ( Valor varchar(6)) Engine=Memory;
CREATE TEMPORARY TABLE IF NOT EXISTS SelectOrigenTmp ( Valor varchar(6)) Engine=Memory;
");
                if (!SqlDb.EjecutarComando(sqlTable.ToString(), false))
                    throw SqlDb.UltimaExcepcion;
                /*if (!SqlDb.EjecutarComando(sqlTable.ToString(), false, lstParamTable.ToArray()))
                  throw SqlDb.UltimaExcepcion;*/
                if (SeleccionarPlanes)
                {
                    Planes.ForEachExt(c =>
                    {
                        /*sqlTable.AppendLine($"Insert Into SelectPlanTmp Values (:Plan{indexParam});");
                        lstParamTable.AddParametro($"Plan{indexParam}", c);
                        indexParam++;*/
                        if (!SqlDb.EjecutarComando("Insert Into SelectPlanTmp Values (:Plan)", false, new Parametro("Plan", c)))
                            throw SqlDb.UltimaExcepcion;
                    });
                }
                if (SeleccionarOrigen)
                {
                    Origenes.ForEachExt(c =>
                    {
                        /*sqlTable.AppendLine($"Insert Into SelectOrigenTmp Values (:Origen{indexParam});");
                        lstParamTable.AddParametro($"Origen{indexParam}", c);
                        indexParam++;*/
                        if (!SqlDb.EjecutarComando("Insert Into SelectOrigenTmp Values (:Origen)", false, new Parametro("Origen", c)))
                            throw SqlDb.UltimaExcepcion;
                    });
                }
                /*if (!SqlDb.EjecutarComando(sqlTable.ToString(), false,lstParamTable.ToArray()))
                  throw SqlDb.UltimaExcepcion;*/
                var sql = "GetIndicadorGeneralPrimeraVez";
                var lstPars = new List<Parametro>();
                lstPars.AddParametro("Empresa", Empresa);
                lstPars.AddParametro("FechaInicial", FechaInicial);
                lstPars.AddParametro("FechaFinal", FechaFinal);
                lstPars.AddParametro("SeleccionarPlan", (SeleccionarPlanes ? "S" : "N"));
                lstPars.AddParametro("SeleccionarOrigen", (SeleccionarOrigen ? "S" : "N"));
#pragma warning disable CS0436 // El tipo 'DataIndicadorGeneral' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataIndicadorGeneral.cs' está en conflicto con el tipo importado 'DataIndicadorGeneral' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataIndicadorGeneral.cs'.
                lista = ExecuteGetLista<DataIndicadorGeneral>(sql, true, lstPars.ToArray());
#pragma warning restore CS0436 // El tipo 'DataIndicadorGeneral' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataIndicadorGeneral.cs' está en conflicto con el tipo importado 'DataIndicadorGeneral' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataIndicadorGeneral.cs'.
            }
            finally
            {
                var sqlTable = @"
            DROP TEMPORARY TABLE IF EXISTS SelectPlanTmp;
            DROP TEMPORARY TABLE IF EXISTS SelectOrigenTmp;";
                if (!SqlDb.EjecutarComando(sqlTable, false))
                    throw SqlDb.UltimaExcepcion;
            }
            return lista;
        }

        /// <summary>
        /// Indicador de Productividad de Mercadeo
        /// </summary>
        /// <param name="FechaInicial">Fecha Inicial</param>
        /// <param name="FechaFinal">Fecha Final</param>
        /// <returns></returns>
#pragma warning disable CS0436 // El tipo 'DataProductividadMercadeo' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataProductividadMercadeo.cs' está en conflicto con el tipo importado 'DataProductividadMercadeo' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataProductividadMercadeo.cs'.
        public List<DataProductividadMercadeo> GetIndicadorProductivoMercadeo(Fecha FechaInicial, Fecha FechaFinal)
#pragma warning restore CS0436 // El tipo 'DataProductividadMercadeo' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataProductividadMercadeo.cs' está en conflicto con el tipo importado 'DataProductividadMercadeo' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataProductividadMercadeo.cs'.
        {
            var sql = "IndicadorProductivoMercadeo";
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("FechaInicial", FechaInicial);
            lstPars.AddParametro("FechaFinal", FechaFinal);
#pragma warning disable CS0436 // El tipo 'DataProductividadMercadeo' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataProductividadMercadeo.cs' está en conflicto con el tipo importado 'DataProductividadMercadeo' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataProductividadMercadeo.cs'.
            return ExecuteGetLista<DataProductividadMercadeo>(sql, true, lstPars.ToArray());
#pragma warning restore CS0436 // El tipo 'DataProductividadMercadeo' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataProductividadMercadeo.cs' está en conflicto con el tipo importado 'DataProductividadMercadeo' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataProductividadMercadeo.cs'.
        }

        /// <summary>
        /// Indicador de Productividad de Mercadeo
        /// </summary>
        /// <param name="FechaInicial">Fecha Inicial</param>
        /// <param name="FechaFinal">Fecha Final</param>
        /// <returns></returns>
#pragma warning disable CS0436 // El tipo 'DataVentaPromedioPaciente' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataVentaPromedioPaciente.cs' está en conflicto con el tipo importado 'DataVentaPromedioPaciente' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataVentaPromedioPaciente.cs'.
        public List<DataVentaPromedioPaciente> GetIndicadorVentaPromedioPaciente(string Empresa, Fecha FechaInicial, Fecha FechaFinal)
#pragma warning restore CS0436 // El tipo 'DataVentaPromedioPaciente' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataVentaPromedioPaciente.cs' está en conflicto con el tipo importado 'DataVentaPromedioPaciente' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataVentaPromedioPaciente.cs'.
        {
            var sql = "IndicadorVentaPromedioPaciente";
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", Empresa);
            lstPars.AddParametro("FechaInicial", FechaInicial);
            lstPars.AddParametro("FechaFinal", FechaFinal);
#pragma warning disable CS0436 // El tipo 'DataVentaPromedioPaciente' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataVentaPromedioPaciente.cs' está en conflicto con el tipo importado 'DataVentaPromedioPaciente' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataVentaPromedioPaciente.cs'.
            return ExecuteGetLista<DataVentaPromedioPaciente>(sql, true, lstPars.ToArray());
#pragma warning restore CS0436 // El tipo 'DataVentaPromedioPaciente' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataVentaPromedioPaciente.cs' está en conflicto con el tipo importado 'DataVentaPromedioPaciente' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataVentaPromedioPaciente.cs'.
        }

        /// <summary>
        /// Indicador de Estudios Ordenados por Médicos
        /// </summary>
        /// <param name="FechaInicial">Fecha Inicial</param>
        /// <param name="FechaFinal">Fecha Final</param>
        /// <returns></returns>
#pragma warning disable CS0436 // El tipo 'DataEstudiosOrdMedicos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataEstudiosOrdMedicos.cs' está en conflicto con el tipo importado 'DataEstudiosOrdMedicos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataEstudiosOrdMedicos.cs'.
        public List<DataEstudiosOrdMedicos> GetIndicadorEstudosPorMedico(Fecha FechaInicial, Fecha FechaFinal)
#pragma warning restore CS0436 // El tipo 'DataEstudiosOrdMedicos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataEstudiosOrdMedicos.cs' está en conflicto con el tipo importado 'DataEstudiosOrdMedicos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataEstudiosOrdMedicos.cs'.
        {
            var sql = "IndicadorEstudosPorMedico";
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("FechaInicial", FechaInicial);
            lstPars.AddParametro("FechaFinal", FechaFinal);
#pragma warning disable CS0436 // El tipo 'DataEstudiosOrdMedicos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataEstudiosOrdMedicos.cs' está en conflicto con el tipo importado 'DataEstudiosOrdMedicos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataEstudiosOrdMedicos.cs'.
            return ExecuteGetLista<DataEstudiosOrdMedicos>(sql, true, lstPars.ToArray());
#pragma warning restore CS0436 // El tipo 'DataEstudiosOrdMedicos' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataEstudiosOrdMedicos.cs' está en conflicto con el tipo importado 'DataEstudiosOrdMedicos' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\DataEstudiosOrdMedicos.cs'.
        }

        /// <summary>
        /// Indicador de Venta de Urgencias
        /// </summary>
        /// <param name="Empresa">Empresa</param>
        /// <param name="CodPlan">Plan Tarifario</param>
        /// <param name="FechaInicial">Fecha Inicial</param>
        /// <param name="FechaFinal">Fecha Final</param>
        /// <returns>Indicador Venta Urgencias</returns>
#pragma warning disable CS0436 // El tipo 'IndicadorVentaUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs' está en conflicto con el tipo importado 'IndicadorVentaUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs'.
        public IndicadorVentaUrgencias GetIndicadorVentasUrgencias(string Empresa, string CodPlan, Fecha FechaInicial, Fecha FechaFinal)
#pragma warning restore CS0436 // El tipo 'IndicadorVentaUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs' está en conflicto con el tipo importado 'IndicadorVentaUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs'.
        {
#pragma warning disable CS0436 // El tipo 'IndicadorVentaUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs' está en conflicto con el tipo importado 'IndicadorVentaUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs'.
            var indica = new IndicadorVentaUrgencias();
#pragma warning restore CS0436 // El tipo 'IndicadorVentaUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs' está en conflicto con el tipo importado 'IndicadorVentaUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs'.
            var sql = "IndicadorVentasUrgencias";
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", Empresa);
            lstPars.AddParametro("CodPlan", CodPlan);
            lstPars.AddParametro("FechaInicial", FechaInicial);
            lstPars.AddParametro("FechaFinal", FechaFinal);
            var dsFact = SqlDb.EjecutarConsultaSet(sql, true, lstPars.ToArray());
            if (dsFact == null) throw SqlDb.UltimaExcepcion;
            var dtIngre = dsFact.Tables[0];
            var dtVenta = dsFact.Tables[1];
            var dtPlanes = dsFact.Tables[2];
#pragma warning disable CS0436 // El tipo 'DataIngresosUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs' está en conflicto con el tipo importado 'DataIngresosUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs'.
            var lstIngre = dtIngre.ToListObject<DataIngresosUrgencias>();
#pragma warning restore CS0436 // El tipo 'DataIngresosUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs' está en conflicto con el tipo importado 'DataIngresosUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs'.
#pragma warning disable CS0436 // El tipo 'DataVentaUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs' está en conflicto con el tipo importado 'DataVentaUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs'.
            var lstVentas = dtVenta.ToListObject<DataVentaUrgencias>();
#pragma warning restore CS0436 // El tipo 'DataVentaUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs' está en conflicto con el tipo importado 'DataVentaUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs'.
#pragma warning disable CS0436 // El tipo 'Planes_Tarifarios' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs' está en conflicto con el tipo importado 'Planes_Tarifarios' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs'.
            var lstPlanes = dtPlanes.ToListObject<Planes_Tarifarios>();
#pragma warning restore CS0436 // El tipo 'Planes_Tarifarios' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs' está en conflicto con el tipo importado 'Planes_Tarifarios' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs'.
            indica.IngresosUrgencias = lstIngre;
            indica.VentaUrgencias = lstVentas;
            indica.Planes = lstPlanes;
            return indica;
        }

        #endregion
    }//fin clase
}//fin namespace
