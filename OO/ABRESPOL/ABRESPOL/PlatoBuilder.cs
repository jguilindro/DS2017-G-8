using System;
namespace ABRESPOL
{
    public abstract class PlatoBuilder
    {
        private Platillo Platillo;

        public Platillo getPlatillo()
        {
            return Platillo;
        }
        public abstract void añadirInformacion(String nombre, String descripcion, float precio, String servido, String tipo);
        public abstract void añadirIds(int idCategoria, int idPlatillo, int idRestaurante);
    }
}
