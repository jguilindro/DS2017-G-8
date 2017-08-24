using System;
namespace ABRESPOL
{
    public class CreditCardDecorator: Pagos
    {
        private Pagos pagos;

        public CreditCardDecorator(Pagos pagos)
        {
            this.pagos = pagos;
            this.pagos.NombresPagos += "Pago por tarjeta de credito\n";
        }

    }
}
