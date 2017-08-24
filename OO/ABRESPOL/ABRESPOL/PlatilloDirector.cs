using System;
namespace ABRESPOL
{
    public class PlatilloDirector
    {
        private PlatilloBuilder builder;


        public void construirPlato(String nombre, String descripcion, float precio, String servido, String tipo, int idCategoria, int idPlatillo, int idRestaurante)
        {
            this.builder.añadirInformacion(nombre, descripcion, precio, servido, tipo);
            this.builder.añadirIds(idCategoria, idPlatillo, idRestaurante);
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
