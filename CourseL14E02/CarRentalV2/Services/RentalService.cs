using System;
using CarRentalV2.Entities;

namespace CarRentalV2.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        //Not the best practice for such service, used for didatic purposes.
        private ITaxService taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            this.taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan rentalTime = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = (rentalTime.TotalHours <= 12.0) ? Math.Ceiling(rentalTime.TotalHours) * PricePerHour : Math.Ceiling(rentalTime.TotalDays) * PricePerDay;
            double tax = taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
