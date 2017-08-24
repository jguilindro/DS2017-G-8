using System;
namespace ABRESPOL
{
    public class Restaurante
    {
        private String nombre;
        private String dueño;
        private String direccion;
        private Boolean aceptaReservas;

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

        public string Dueño
        {
            get
            {
                return dueño;
            }

            set
            {
                dueño = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public bool AceptaReservas
        {
            get
            {
                return aceptaReservas;
            }

            set
            {
                aceptaReservas = value;
            }
        }

        public Restaurante(String nombre, String dueño, String direccion, Boolean aceptaReservas)
        {
            this.nombre = nombre;
            this.dueño = dueño;
            this.direccion = direccion;
            this.aceptaReservas = aceptaReservas;
        }
    }
}
