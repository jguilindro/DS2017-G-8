using System;
namespace ABRESPOL
{
    public class PlatilloBuilder
    {
        private Platillo Platillo= new Platillo();

        public Platillo getPlatillo()
        {
            return Platillo;
        }

        public void setPlatillo(Platillo platillo)
        {
            this.Platillo = platillo;
        }
        public void crearPlatillo(String nombre, String descripcion, float precio, String servido, String tipo, String categoria, String restaurante)
        {
            this.Platillo.Nombre = nombre;
            this.Platillo.Descripcion = descripcion;
            this.Platillo.Precio = precio;
            this.Platillo.Servido = servido;
            this.Platillo.Tipo = tipo;
            this.Platillo.Restaurante = restaurante;
            this.Platillo.Categoria = categoria;
        }

    }
}