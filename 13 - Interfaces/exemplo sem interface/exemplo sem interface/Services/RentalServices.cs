using exemplo_sem_interface.Entities;
using exemplo_sem_interface.Services;

namespace exemplo_sem_interface.Services
{
    internal class RentalServices
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        // construtor
        public RentalServices(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        // metodo responsavel por pegar o carental e gerar o invoice

        public void PorcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;

            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours); //math.ceiling arredonda pra cima
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays); //math.ceiling arredonda pra cima
            }

            double tax = _brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);

        }

    }
}
