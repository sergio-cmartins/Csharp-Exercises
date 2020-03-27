using System.Globalization;

namespace TaxesCalculator.Entities
{
    class LegalPerson : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public LegalPerson(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double taxRate = NumberOfEmployees > 10 ? 0.14 : 0.16;
            return AnnualIncome * taxRate;
        }

        public override string ToString()
        {
            return Name + ": $ " + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
