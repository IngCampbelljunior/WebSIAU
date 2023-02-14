namespace LiloSoft.Siesa.Interfaz.Circular016
{
#pragma warning disable CS0436 // El tipo 'BaseRegistroFT' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\BaseRegistroFT.cs' está en conflicto con el tipo importado 'BaseRegistroFT' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\BaseRegistroFT.cs'.
    public class RegistroFT002 : BaseRegistroFT
#pragma warning restore CS0436 // El tipo 'BaseRegistroFT' de 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\BaseRegistroFT.cs' está en conflicto con el tipo importado 'BaseRegistroFT' de 'LiloSoft.SiesaInterfazLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'. Se usará el tipo definido en 'C:\Users\Usuario de red\Documents\Repos\WebSIAU\BiblioInterfazSiesa\Circular016\BaseRegistroFT.cs'.
    {
        /// <summary>
        ///Escriba el medio en el que se publica los estados financieros
        //1:= Página web oficial entidad
        //2:=Diario Oficial
        //3:=Prensa de amplia circulación
        //4:= Página web oficial alcaldía ( únicamente ESE)
        ///Numérico
        /// </summary>
        public int medioPublicacion { get; set; }

        /// <summary>
        ///Fecha en la cual se realizó la publicación de los estados financieros
        ///Numérico Fecha con formato AAAAMMDD
        /// </summary>
        public string fechaPublicacion { get; set; }

        /// <summary>
        ///Escribir URL donde publica los estados financieros o número del diario o nombre del periódico 
        ///Alfanumérico
        /// </summary>
        public string lugarPublicacion { get; set; }
    }
}
