using LiloSoft.DataBase.ConectaDB;
using LiloSoft.Types.Data;
using LiloSoft.Web.ProveedorWeb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using LiloSoft.Utils;
using System.Reflection;
using System.Xml.Linq;


namespace LiloSoft.Siesa.Interfaz
{
    public class ConsultasEsculapioDB : BaseDB
    {

        #region Contructores
        /// <summary>
        /// Constructor por Defecto
        /// </summary>
        public ConsultasEsculapioDB()
        {
            ComportamientoIndividualComandos = true;
            TipoComandoIndividual = TipoComando.InstruccionSQL;
        }

        /// <summary>
        /// Constructo con Objeto de Acceso a Datos
        /// </summary>
        /// <param name="pSqlDb"></param>
        public ConsultasEsculapioDB(DB pSqlDb) : this()
        {
            SqlDb = pSqlDb;
        }

        public ConsultasEsculapioDB(bool StringConfigManual) : base(StringConfigManual)
        {
        }
        #endregion

        #region Metodos GET Consultas


        public List<ConsultaIPEmpresas> GetIpEmpresas(string Empresa)
        {
            var sql = @"SELECT Empresa, IpConexion, Descripcion, NombreComercial as Ubicacion
 FROM Ipconexion_Empresas WHERE Empresa = :Empresa Order by IpConexion";
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", Empresa);
            return ExecuteGetLista<ConsultaIPEmpresas>(sql, false, lstPars.ToArray());
        }

        public List<ConsultaIPEmpresas> GetCodigoEmpresa(string IpConexion) //

        {
            var sql = @"SELECT Empresa FROM Ipconexion_Empresas WHERE IpConexion Like CONCAT('%',:IpConexion,'%') Order by IpConexion";
            var lstPars = new List<Parametro>();
            lstPars.AddParametro("IpConexion", IpConexion);
            return ExecuteGetLista<ConsultaIPEmpresas>(sql, false, lstPars.ToArray());
        }


        public List<ConsultaUsuariosAdv> GetUsuarioReporInvestigacion(string empresa, string usuario)
        {
            var sql = @"SELECT a.Empresa,a.usuario FROM usuarios_repor_invest a Inner Join Usuarios b On a.usuario=b.usuario WHERE a.usuario=:usuario And a.empresa=:empresa AND a.estado='A'";

            var lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", empresa);
            lstPars.AddParametro("usuario", usuario);

            //sql = sqlBld.ToString();
            return ExecuteGetLista<ConsultaUsuariosAdv>(sql, false, lstPars.ToArray());
        }


        ////---Mi metodos

        public List<Entidades> GetAseguradoras(string Empresa)

        {
            string sql = "SELECT DISTINCT a.nitentidad, a.nombre_entidad "+
                "FROM entidades a "+
                "INNER JOIN convenios b ON a.empresa=b.empresa AND a.nitentidad=b.nitentidad AND "+
                "b.fec_fin_vigencia>=CURRENT_DATE() AND b.estado='A' AND b.Soat='S' "+
                "WHERE a.empresa=:Empresa AND a.estado='A' "+
                "ORDER BY a.nombre_entidad";
            List<Parametro> lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", Empresa);

            return base.ExecuteGetLista<Entidades>(sql, false, lstPars.ToArray());
        }

        //Para SIAU
        public List<ConsultaSolicitudPendiente> GetSolicitudPendiente(string Empresa)
        {
            string sql = @"SELECT p.TipoDocumento, p.NoDocumento, p.nombre1, p.nombre2, p.Apellido1, p.Apellido2, c.fecha_solicitud
                        FROM solicitud_doc_siau AS c
                        INNER JOIN pacientes AS p ON c.noidentificacion=p.nodocumento
                        WHERE c.estado_solicitud='A'
                        ORDER BY c.fecha_solicitud;";


            List<Parametro> lstPars = new List<Parametro>();
            lstPars.AddParametro("empresa", Empresa);
            //lstPars.AddParametro("NoCaso", NoCaso);
            //lstPars.AddParametro("Usuario", Usuario);

            return base.ExecuteGetLista<ConsultaSolicitudPendiente>(sql, false, lstPars.ToArray());

        }

        public List<ConsultaCasosPaciente> GetCasosPaciente(string Empresa, string criterio)
        {
            string sql = @"SELECT c.empresa, c.Nocuenta, a.NoAdmision,
            a.fechaIngreso, a.horaingreso, s.nombre Servicio,
            c.estado, a.fechaegreso, a.horaEgreso, a.estado estadoIng,
            a.Estado EstAdm, st.nombre servTras, a.no_Autorizacion, a.autorizado_Por
            FROM cuenta AS c INNER JOIN Admisiones AS a ON
            c.empresa = a.empresa AND c.nocuenta = a.nocuenta
            INNER JOIN Servicios_Clinica AS s ON
            c.empresa = s.empresa AND a.codservicio = s.Cod_Servicio
            LEFT OUTER JOIN Admisiones AT ON a.empresa = at.empresa AND at.noadmision = a.noadmisionTras
            LEFT OUTER JOIN Servicios_Clinica st ON at.empresa = st.empresa AND at.codservicio = st.Cod_Servicio
            WHERE c.nohistoria =:criterio AND a.estado <> 'X' AND c.empresa =:Empresa;";
            

            List<Parametro> lstPars = new List<Parametro>();
            lstPars.AddParametro("Empresa", Empresa);
            lstPars.AddParametro("criterio", criterio);

            return base.ExecuteGetLista<ConsultaCasosPaciente>(sql, false, lstPars.ToArray());
        }
        #endregion

        #region Metodos CRUD


        #endregion

    }//fin clase

    //***********************************
    //-- Modelos
    //***********************************

    #region Clases Modelos BD

    public class DatosCasoBasico
    {
        [DisplayName("No.Caso")]
        public Entero NoCuenta { get; set; }
        [DisplayName("No.Historia")]
        public string NoHistoria { get; set; }
        [DisplayName("Nombre del Paciente")]
        public string NombrePaciente { get; set; }
        [DisplayName("Fec.Ingreso")]
        public Fecha FechaIngreso { get; set; }
        [DisplayName("Hor.Ingreso")]
        public string HoraIngreso { get; set; }
        [DisplayName("Estado Cuenta ")]
        public string Estado { get; set; }

        public Entero ConsInternoFact { get; set; }
        public string sexo { get; set; }
        [NoDataBase]
        [DisplayName("Sexo")]
        public string NombreSexo
        {
            get
            {
                var nom = "";
                switch (sexo)
                {
                    case "M":
                        nom = "Masculino";
                        break;
                    case "F":
                        nom = "Femenino";
                        break;
                }
                return nom;
            }
        }
        public Entero Edad { get; set; }
        [NoDataBase]
        [DisplayName("Edad ")]
        public string NombreEdad
        {
            get
            {
                var data = "";
                if (Edad != null)
                {
                    var medida =
                      "";
                    var edad = Edad.ValorInterno;
                    var plural = true;
                    if (edad == 1)
                        plural = false;
                    switch (Medida_Edad)
                    {
                        case "A":
                            medida = "Año" + (plural ? "s" : "");
                            break;
                        case "M":
                            medida = "Mes" + (plural ? "es" : "");
                            break;
                        case "D":
                            medida = "Día" + (plural ? "s" : "");
                            break;
                    }
                    data = $"{edad} {medida}";
                }
                return data;
            }
        }
        public string Medida_Edad { get; set; }
    }

    public class ResponsablesCaso
    {
        public Entero ConsInterno { get; set; }
        public string NitEntidad { get; set; }
        public string NombreEntidad { get; set; }
        public string CodConvenio { get; set; }
        public string Nombre_Convenio { get; set; }

    }

    public interface IEstadosTrazabilidad
    {
        string CodEstadoTrazabilidad { get; set; }
        string NombreEstadoTrazabilidad { get; set; }
    }

    public class TrazabilidadHistorico : IEstadosTrazabilidad

    {
        [DataObjectField(true)]
        public EnteroLargo IdTrazabilidad { get; set; }
        public Hora FechaTrazabilidad { get; set; }
        public string UsuarioHistTrazabilidad { get; set; }
        public string CodEstadoTrazabilidad { get; set; }
        [NoDataBase]
        public string NombreEstadoTrazabilidad { get; set; }
        public Hora FechaEstado { get; set; }
        public string UsuarioEstado { get; set; }
        public string Estado { get; set; }
        public Moneda ValorFactura { get; set; }
    }

    public class DetalleCuenta
    {
        public Fecha fecha_cargo { get; set; }
        public string horacargo { get; set; }
        public string cod_servicio_origen { get; set; }
        public string NombreServicioOrigen { get; set; }
        public string CodDependencia { get; set; }
        public string NoOrdenServicio { get; set; }
        public string CodServicio { get; set; }
        public string NombreServicio { get; set; }
        public Moneda Cantidad { get; set; }
        public Moneda ValorServicio { get; set; }
        [NoDataBase]
        public Moneda TotalServicio => Cantidad * ValorServicio;
        public Moneda Porcentaje { get; set; }
        public string CodClase { get; set; }
        public string Usuario_Grabacion { get; set; }
        public Fecha fecha_real_cargo { get; set; }
        public string Hora_real_cargo { get; set; }
        public Moneda ValorIva { get; set; }
        public Moneda CostoServicio { get; set; }
        public string CedulaMedico { get; set; }
        public string NombreMedico { get; set; }
        public string CodEspecialidad { get; set; }
        public string NombreEspecialidad { get; set; }


    }

    public class HistoriasClinicasEmpresas
    {
        public string CiudadServer { get; set; }
        public string Empresa { get; set; }
        public string NombreEmpresa { get; set; }
        public string Acompanante { get; set; }
        public string NoHistoria { get; set; }
        public string NoFolio { get; set; }
        public string NoCuenta { get; set; }
        public string NoAdmision { get; set; }
        public string Cod_Servicio { get; set; }
        public string NombreServicio { get; set; }
        public string CodDependencia { get; set; }
        public string CedulaMedico { get; set; }
        public Fecha FechaIngreso { get; set; }
        public string HoraIngreso { get; set; }
        public string usuario { get; set; }
        public string estado { get; set; }
        public string Urgencias { get; set; }
        public string consultaExterna { get; set; }
        public string RequiereMotivoIngreso { get; set; }
        public string cod_parent { get; set; }
        public Fecha FechaEgreso { get; set; }
        public string HoraEgreso { get; set; }

    }

    public class ConsultaUsuariosAdv
    {

        [DisplayName("Usuario")]
        public string Usuario { get; set; }
        [DisplayName("PassWord")]
        public string PassWordUsu { get; set; }
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Role { get; set; }
        public string Empresa { get; set; }
    }//fin clase

    public class ConsultaIPEmpresas
    {
        [DisplayName("Empresa")]
        public string Empresa { get; set; }
        [DisplayName("IpConexion")]
        public string IpConexion { get; set; }
        [DisplayName("Descripcion")]
        public string Descripcion { get; set; }
        [DisplayName("Ubicacion")]
        public string Ubicacion { get; set; }
    }//fin clase

    //---------- Mis modelos

    //public class DatosPacientes
    //{

    //    public string nombre1 { get; set; }
    //    public string nombre2 { get; set; }
    //    public string Apellido1 { get; set; }
    //    public string Apellido2 { get; set; }
    //    public string TipoDocumento { get; set; }
    //    public string NoDocumento { get; set; }
    //    public string Espedicion { get; set; }
    //    public string FechaIngreso { get; set; }
    //    public string HoraIngreso { get; set; }
    //    public string Fecha_Accidente { get; set; }
    //    public string Hora_Accidente { get; set; }
    //    public string Desc_Diag_Ing { get; set; }
    //    public string Informe_Accid { get; set; }
    //    public string Tipo_Diag { get; set; }

    //}

    public class investigador_reporte
    {
        public string Usuario { get; set; }
        public Fecha Fecha_elaboracion { get; set; }
        public string Aseguradora { get; set; }
        public string Empresa { get; set; }
        public string Caso { get; set; }
        public string NoDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public string CiudadExp { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public Fecha FechaIngreso { get; set; }
        public string HoraIngreso { get; set; }
        public Fecha Fecha_acc { get; set; }
        public string Hora_acc { get; set; }
        public string Diagnostico { get; set; }
        public string Relato { get; set; }
        public string Doc_Investigador { get; set; }
        public byte[] FirmaUsuario { get; set; }
        public byte[] FirmaFun { get; set; }
        public string AgenciaInvest { get; set; }
        public string nombre_entidad { get; set; }
        public string paciente { get; set; }
        public string investigadores { get; set; }

    }
    public class DatosInvestigadores
    {

        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string TipoDocumento { get; set; }
        public string NoDocumento { get; set; }
        public string CiudadExp { get; set; }
        public string CorreoInvest { get; set; }
        public string AgenciaInvest { get; set; }
        public string Aseguradora { get; set; }
        public string empresa { get; set; }
        public string investigador { get; set; }

    }

    public class DatosAseguradoras
    {

        public string nitentidad { get; set; }
        public string nombre_entidad { get; set; }

    }
    public class SampleViewModel
    {

        public string Question { get; set; }

        //See here for list of answers
        public string Answer { get; set; }
    }
    
    public class solicitud_doc_siau
    {
        public string empresa { get; set; }
        public Fecha fecha_solicitud { get; set; }
        public string nombre1_solicita { get; set; }
        public string nombre2_solicita { get; set; }
        public string apellido1_solicita { get; set; }
        public string apellido2_solicita { get; set; }
        public string tipo_doc_solicita { get; set; }
        public string num_doc_solicta { get; set; }
        public string exp_doc_solicita { get; set; }
        public string parentesco_solicita { get; set; }
        public string NoIdentificacion { get; set; }
        public string tel_paciente { get; set; }
        public string motivo_solicitud { get; set; }
        public string email_paciente { get; set; }
        public string envioalcorreo { get; set; }
        public string NoCaso { get; set; }
        public Fecha fechaIngreso { get; set; }
        public Fecha fechaEgreso { get; set; }
        public string hist_clinica { get; set; }
        public string imagen_diag { get; set; }
        public string lectura_rx { get; set; }
        public string laboratorio { get; set; }
        public string certificado { get; set; }
        public string furips { get; set; }
        public string num_folio { get; set; }
        public Fecha fecha_hora_entrega { get; set; }
        public string estado_solicitud { get; set; }

    }

    public class ConsultaSolicitudPendiente
    {
        public string TipoDocumento { get; set; }
        public string NoDocumento { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public Fecha fecha_solicitud { get; set; }
        
    }

    public class ConsultaCasosPaciente  
    {
        public Entero Nocuenta { get; set; }
        public Entero NoAdmision { get; set; }
        public Fecha fechaIngreso { get; set; }
        public string horaingreso { get; set; }
        public string Servicio { get; set; }
        public string estado { get; set; }
        public Fecha fechaegreso { get; set; }
        public string horaEgreso { get; set; }
        public string empresa { get; set; }
        public string estadoIng { get; set; }
    }
    #endregion

}