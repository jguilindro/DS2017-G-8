using System;
namespace ABRESPOL
{
    public class Platillo
    {
        private String nombre { get; set; }
        private float precio { get; set; }
        private String descripcion { get; set; }
        private String servido { get; set; }
        private String tipo { get; set; }
        private int idCategoria { get; set; }
        private int idRestaurante { get; set; }
        private int idPlatillo { get; set; }


        public void modificarPlatillo(){

        }

        public String getInfoPlatillo()
        {
            String ret= "";
            ret += "Nombre: " + this.nombre+ "\n";
            ret += "Descripcion: " + this.descripcion + "\n";
            ret += "Precio: " + this.precio + "\n";
            ret += "Servido: " + this.servido + "\n";
            ret += "Tipo: " + this.tipo + "\n";
            return ret;
        }
           


    }
}
