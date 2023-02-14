namespace LiloSoft.Siesa.Interfaz.Circular016
{
#pragma warning disable CS0436 // El tipo 'BaseRegistroFT' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\BaseRegistroFT.cs' está en conflicto con el tipo importado 'BaseRegistroFT' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\BaseRegistroFT.cs'.
    public class RegistroFT001 : BaseRegistroFT
#pragma warning restore CS0436 // El tipo 'BaseRegistroFT' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\BaseRegistroFT.cs' está en conflicto con el tipo importado 'BaseRegistroFT' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\BaseRegistroFT.cs'.
    {
        public int codigoConcepto { get; set; }
        /// <summary>
        /// Clase de Concepto 1:Corriente, 2:No Corriente, 3:No Aplica
        /// </summary>
        public int claseConcepto { get; set; }
        public long valor { get; set; }
    }//fin  clase
}//fin namespace