using LiloSoft.Types.Data;
using LiloSoft.Utils;
using System.Collections.Generic;
using System.Linq;

namespace LiloSoft.Siesa.Interfaz.Indicadores
{
    public class IndicadorVentaUrgencias
    {
        public IndicadorVentaUrgencias()
        {
#pragma warning disable CS0436 // El tipo 'DataIngresosUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs' está en conflicto con el tipo importado 'DataIngresosUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs'.
            IngresosUrgencias = new List<DataIngresosUrgencias>();
#pragma warning restore CS0436 // El tipo 'DataIngresosUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs' está en conflicto con el tipo importado 'DataIngresosUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs'.
#pragma warning disable CS0436 // El tipo 'DataVentaUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs' está en conflicto con el tipo importado 'DataVentaUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs'.
            VentaUrgencias = new List<DataVentaUrgencias>();
#pragma warning restore CS0436 // El tipo 'DataVentaUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs' está en conflicto con el tipo importado 'DataVentaUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs'.
        }
#pragma warning disable CS0436 // El tipo 'DataIngresosUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs' está en conflicto con el tipo importado 'DataIngresosUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs'.
        public List<DataIngresosUrgencias> IngresosUrgencias { get; set; }
#pragma warning restore CS0436 // El tipo 'DataIngresosUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs' está en conflicto con el tipo importado 'DataIngresosUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs'.
#pragma warning disable CS0436 // El tipo 'DataVentaUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs' está en conflicto con el tipo importado 'DataVentaUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs'.
        public List<DataVentaUrgencias> VentaUrgencias { get; set; }
#pragma warning restore CS0436 // El tipo 'DataVentaUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs' está en conflicto con el tipo importado 'DataVentaUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs'.

        public Entero TotalIngreso => IngresosUrgencias.CountExt();

        public decimal TotalVentas => VentaUrgencias.HasElements() ? VentaUrgencias.Sum(c => c.Venta) : 0m;
        public decimal IndicadorGeneral
        {
            get
            {
                var indicador = 0m;
                var totIngreso = 0m;
                var totVentas = 0m;
                if (IngresosUrgencias.HasElements()) totIngreso = IngresosUrgencias.CountExt();
                if (VentaUrgencias.HasElements()) totVentas = VentaUrgencias.Sum(c => c.Venta);
                if (totIngreso > 0)
                    indicador = totVentas / totIngreso;
                return indicador;
            }
        }

        public string CodPlan { get; set; }
        public string NombrePlan { get; set; }
#pragma warning disable CS0436 // El tipo 'Planes_Tarifarios' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs' está en conflicto con el tipo importado 'Planes_Tarifarios' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs'.
        public List<Planes_Tarifarios> Planes { get; set; }
#pragma warning restore CS0436 // El tipo 'Planes_Tarifarios' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs' está en conflicto con el tipo importado 'Planes_Tarifarios' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Planes_Tarifarios.cs'.

        /// <summary>
        /// Generación de Indicadores por Planes Tarifaros
        /// </summary>
#pragma warning disable CS0436 // El tipo 'IndicadorVentaUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs' está en conflicto con el tipo importado 'IndicadorVentaUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs'.
        public IEnumerable<IndicadorVentaUrgencias> IndicadorPlanes
#pragma warning restore CS0436 // El tipo 'IndicadorVentaUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs' está en conflicto con el tipo importado 'IndicadorVentaUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs'.
        {
            get
            {
#pragma warning disable CS0436 // El tipo 'IndicadorVentaUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs' está en conflicto con el tipo importado 'IndicadorVentaUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs'.
                var indicador = new List<IndicadorVentaUrgencias>();
#pragma warning restore CS0436 // El tipo 'IndicadorVentaUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs' está en conflicto con el tipo importado 'IndicadorVentaUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs'.
                Planes.ForEachExt(pla =>
                {
#pragma warning disable CS0436 // El tipo 'IndicadorVentaUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs' está en conflicto con el tipo importado 'IndicadorVentaUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs'.
                    var ind = new IndicadorVentaUrgencias();
#pragma warning restore CS0436 // El tipo 'IndicadorVentaUrgencias' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs' está en conflicto con el tipo importado 'IndicadorVentaUrgencias' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Indicadores\IndicadorVentaUrgencias.cs'.
                    ind.IngresosUrgencias.AddRange(IngresosUrgencias.Where(c => c.CodPlan == pla.CodPlan));
                    ind.VentaUrgencias.AddRange(VentaUrgencias.Where(c => c.CodPlan == pla.CodPlan));
                    ind.CodPlan = pla.CodPlan;
                    ind.NombrePlan = pla.NombrePlan;
                    indicador.Add(ind);
                });
                return indicador;
            }
        }
    }//fin clase

    public class DataIngresosUrgencias
    {
        public string Empresa { get; set; }
        public string NombreEmpresa { get; set; }
        public string NoCuenta { get; set; }
        public string NoAdmision { get; set; }
        public Fecha FechaIngreso { get; set; }
        public string CodServicio { get; set; }
        public string NombreServicio { get; set; }
        public string CodPlan { get; set; }
        public string NombrePlan { get; set; }
    }//fin clase

    public class DataVentaUrgencias
    {
        public string Empresa { get; set; }
        public string NombreEmpresa { get; set; }
        public string NoCuenta { get; set; }
        public Entero ConsInternoFactura { get; set; }
        public string CodServicio { get; set; }
        public string NombreServicio { get; set; }
        public Moneda Venta { get; set; }
        public Entero Casos { get; set; }
        public string CodPlan { get; set; }
        public string NombrePlan { get; set; }
    }
}//fin namespace
