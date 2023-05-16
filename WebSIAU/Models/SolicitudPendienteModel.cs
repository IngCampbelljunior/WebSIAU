using LiloSoft.DataBase.ConectaDB;
using LiloSoft.Types.Data;
using LiloSoft.Utils;
using LiloSoft.Web.Mvc.Controllers;
using LiloSoft.Web.Mvc.Models;
using LiloSoft.Web.ProveedorWeb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LiloSoft.Siesa.Interfaz.Controllers;
using LiloSoft.Siesa.Interfaz;
using Newtonsoft.Json;
using LiloSoft.Web.Mvc;
using SIS.EsculapioWeb.HistoriaClinica.Models;
using SIS.EsculapioWeb.HistoriaClinica.Models.PruebaEsculapio;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Net;
using System.Net.Sockets;
using System.Web.Security;

namespace SolicitudPendiente.Models
{
    public class SolicitudPendienteModel : BaseInterfazController
    {
        
        public string TipoDocumento { get; set; }
        public string NoDocumento { get; set; }
        public string NombrePaciente { get; set; }
        public string ApellidoPaciente { get; set; }
        public Fecha fecha_solicitud { get; set; }
    }

}

