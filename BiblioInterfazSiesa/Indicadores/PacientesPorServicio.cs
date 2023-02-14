using LiloSoft.Types.Data;

namespace LiloSoft.Siesa.Interfaz.Indicadores
{
    /// <summary>
    /// Total de Pacientes Atendidos por Servicio
    /// </summary>
    public class PacientesPorServicio
    {
        /// <summary>
        /// Código del Servicio
        /// </summary>
        public string CodServicio { get; set; }
        /// <summary>
        /// Nombre del Servicio
        /// </summary>
        public string NombreServicio { get; set; }
        /// <summary>
        /// Número de Pacientes Atendidos para el Servicio
        /// </summary>
        public Entero NumeroPacientes { get; set; }
    }//fin clase
}//fin namespace
