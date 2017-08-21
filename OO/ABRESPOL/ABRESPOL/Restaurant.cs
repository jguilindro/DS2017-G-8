using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABRESPOL
{
    class Restaurant
    {
        private String nombre;
        private System.Drawing.Bitmap imagen;

        public Restaurant(String nombre, System.Drawing.Bitmap imagen) {
            this.nombre = nombre;
            this.imagen = imagen;
        }
        public String getNombre() {
            return this.nombre;
        }
        public void setNombre(String nombre) {
            this.nombre = nombre;
        }

        public System.Drawing.Bitmap getImagen() {
            return this.imagen;
        }

        public void setImagen(System.Drawing.Bitmap imagen) {
            this.imagen = imagen;
        }
    }
}
