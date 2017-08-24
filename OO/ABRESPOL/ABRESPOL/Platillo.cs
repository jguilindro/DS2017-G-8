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
        private int idCategoria;
        private int idRestaurante;
        private int idPlatillo;

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

        public int IdCategoria
        {
            get
            {
                return idCategoria;
            }

            set
            {
                idCategoria = value;
            }
        }

        public int IdRestaurante
        {
            get
            {
                return idRestaurante;
            }

            set
            {
                idRestaurante = value;
            }
        }

        public int IdPlatillo
        {
            get
            {
                return idPlatillo;
            }

            set
            {
                idPlatillo = value;
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
