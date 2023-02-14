using LiloSoft.Types.Data;

namespace LiloSoft.Siesa.Interfaz.Indicadores
{
#pragma warning disable CS0436 // El tipo 'PacientesPorServicio' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\PacientesPorServicio.cs' está en conflicto con el tipo importado 'PacientesPorServicio' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\PacientesPorServicio.cs'.
    public class IndicadorReingresos : PacientesPorServicio
#pragma warning restore CS0436 // El tipo 'PacientesPorServicio' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\PacientesPorServicio.cs' está en conflicto con el tipo importado 'PacientesPorServicio' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\PacientesPorServicio.cs'.
    {
        /// <summary>
        /// Número de 
        /// </summary>
        public Entero NumeroReingresos { get; set; }
        public Moneda Indicador
        {
            get
            {
                var indicador = 0m;
                if (NumeroPacientes != null && NumeroPacientes != 0)
                {
                    indicador = (decimal)NumeroReingresos / (decimal)NumeroPacientes;
                }
                return indicador;
            }
        }
    }
}
