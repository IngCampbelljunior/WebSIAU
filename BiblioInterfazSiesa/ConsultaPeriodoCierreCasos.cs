using LiloSoft.Types.Data;

namespace LiloSoft.Siesa.Interfaz
{
    public class ConsultaPeriodoCierreCasos
    {
        public string NoCuenta { get; set; }
        public string NoHistoria { get; set; }
        public string NombrePaciente { get; set; }
        public Fecha FechaIngreso { get; set; }
        /// <summary>
        /// Nit de la Entidad
        /// </summary>
        public string NitEntidad { get; set; }
        /// <summary>
        /// Nombre de la Entidad
        /// </summary>
        public string NombreEntidad { get; set; }
        public string SucursalContable { get; set; }
        public string CodConvenio { get; set; }
        public string NombreConvenio { get; set; }
        /// <summary>
        /// Código del Plan
        /// </summary>
        public string CodPlan { get; set; }
        /// <summary>
        /// Nombre del Plan
        /// </summary>
        public string NombrePlan { get; set; }
        /// <summary>
        /// Código del Servicio
        /// </summary>
        public string CodServicio { get; set; }
        /// <summary>
        /// Nombre del servicio
        /// </summary>
        public string NombreServicio { get; set; }
        /// <summary>
        /// Código de la Dependencia
        /// </summary>
        public string CodDependencia { get; set; }
        /// <summary>
        /// Nombre de la Dependencia
        /// </summary>
        public string NombreDependencia { get; set; }
        /// <summary>
        /// Valor de la Venta
        /// </summary>
        public Moneda ValorVenta { get; set; }
    }
}
