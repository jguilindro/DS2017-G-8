using System;
namespace ABRESPOL
{
    public class JugoDecorator
    {
        private Platillo Platillo;
        private String Jugo;
        public JugoDecorator(Platillo platillo, String nombreJugo, float precio)
        {
            this.Platillo = platillo;
            this.Jugo = nombreJugo;
            this.Platillo.Precio = this.Platillo.Precio + precio;
                }
    }
}
