using System;
namespace ABRESPOL
{
    public class Pagos
    {
        private String nombresPagos;
        public Pagos()
        {
        }

        public string NombresPagos
        {
            get
            {
                return nombresPagos;
            }

            set
            {
                nombresPagos = value;
            }
        }
    }
}
