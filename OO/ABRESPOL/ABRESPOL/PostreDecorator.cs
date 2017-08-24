using System;
namespace ABRESPOL
{
    public class PostreDecorator
    {
        private Platillo Platillo;
        private String Postre;
        public PostreDecorator(Platillo platillo, String nombrePostre, float precio)
        {
            this.Platillo = platillo;
            this.Postre = nombrePostre;
            this.Platillo.Precio = this.Platillo.Precio + precio;
        }
    }
}
