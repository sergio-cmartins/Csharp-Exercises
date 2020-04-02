using System;
using CarRentalV1.Entities;

namespace CarRentalV1.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        //Not the best practice for such service, used for didatic purposes.
        private BrazilTaxService brazilTaxService = new BrazilTaxService();

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan rentalTime = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = (rentalTime.TotalHours <= 12.0) ? Math.Ceiling(rentalTime.TotalHours) * PricePerHour : Math.Ceiling(rentalTime.TotalDays) * PricePerDay;
            double tax = brazilTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
