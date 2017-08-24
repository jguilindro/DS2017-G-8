using System;
namespace ABRESPOL
{
    public class Platillo
    {
        private String nombre;
        private float precio;
        private String descripcion;
        private String servido;
        private String tipo;
        private String categoria;
        private String restaurante;

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public float Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string Servido
        {
            get
            {
                return servido;
            }

            set
            {
                servido = value;
            }
        }

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public String Categoria
        {
            get
            {
                return categoria;
            }

            set
            {
                categoria = value;
            }
        }

        public String Restaurante
        {
            get
            {
                return restaurante;
            }

            set
            {
               restaurante = value;
            }
        }


        public void modificarPlatillo(){

        }

        public String getInfoPlatillo()
        {
            String ret= "";
            ret += "Nombre: " + this.Nombre+ "\n";
            ret += "Descripcion: " + this.Descripcion + "\n";
            ret += "Precio: " + this.Precio + "\n";
            ret += "Servido: " + this.Servido + "\n";
            ret += "Tipo: " + this.Tipo + "\n";
            return ret;
        }
           


    }
}
