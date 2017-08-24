using System;
namespace ABRESPOL
{
    public class Persona
    {
        private String username;
        private String password;
        private String rol;
        private String idRestaurante;

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Rol
        {
            get
            {
                return rol;
            }

            set
            {
                rol = value;
            }
        }

        public string IdRestaurante
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

        public Persona(String username, String password, String rol, String idRestaurante)
        {
            this.username = username;
            this.password = password;
            this.rol = rol;
            this.idRestaurante = idRestaurante;
        }

        public Persona(String username, String password, String rol)
        {
            this.username = username;
            this.password = password;
            this.rol = rol;
            this.idRestaurante = null;
        }
    }
}
