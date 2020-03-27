using System.Globalization;

namespace TaxesCalculator.Entities
{
    class NaturalPerson : TaxPayer
    {
        public double MedicalExpenses { get; set; }

        public NaturalPerson(string name, double annualIncome, double medicalExpenses) : base(name, annualIncome)
        {
            MedicalExpenses = medicalExpenses;
        }

        public override double Tax()
        {
            double taxRate = AnnualIncome < 20000.0 ? 0.15 : 0.25;
            return (AnnualIncome * taxRate) - (MedicalExpenses * 0.5);
        }

        public override string ToString()
        {
            return Name + ": $ " + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
