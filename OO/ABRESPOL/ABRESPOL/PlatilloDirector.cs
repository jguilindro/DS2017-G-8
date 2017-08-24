using System;
namespace ABRESPOL
{
    public class PlatilloDirector
    {
        private PlatilloBuilder builder;


        public void construirPlato(String nombre, String descripcion, float precio, String servido, String tipo, String categoria, String restaurante)
        {
            this.builder.crearPlatillo(nombre, descripcion, precio, servido, tipo, categoria, restaurante);
        }

        public void setPlatoBuilder(PlatilloBuilder builder)
        {
            this.builder = builder;
        }

        public Platillo getPlatillo()
        {
            return this.builder.getPlatillo();
        }
    }
}
