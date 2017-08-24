using System;
namespace ABRESPOL
{
    public class PlatoDirector
    {
        private PlatoBuilder builder;


        public void construirPlato(String nombre, String descripcion, float precio, String servido, String tipo, int idCategoria, int idPlatillo, int idRestaurante)
        {
            this.builder.añadirInformacion(nombre, descripcion, precio, servido, tipo);
            this.builder.añadirIds(idCategoria, idPlatillo, idRestaurante);
        }

        public PlatoDirector getPlato()
        {
            return null;
        }

        public void setPlatoBuilder(PlatoBuilder builder)
        {
            this.builder = builder;
        }

        public Platillo getPlatillo()
        {
            return this.builder.getPlatillo();
        }
    }
}
