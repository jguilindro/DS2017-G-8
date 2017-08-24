using System;
namespace ABRESPOL
{
    public class CarnetDecorator: Pagos
    {
        private Pagos pagos;
        public CarnetDecorator(Pagos pagos, String numeroCarnet)
        {
            this.pagos = pagos;
            this.pagos.NombresPagos += "Pago por Carnet numero: " + numeroCarnet + "\n";
        }
    }
}
