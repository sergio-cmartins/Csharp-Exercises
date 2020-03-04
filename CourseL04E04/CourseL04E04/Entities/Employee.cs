using System.Globalization;

namespace CourseL04E04.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public double GrossPay { get; set; }
        public double Tax { get; set; }

        public double NetPay()
        {
            return GrossPay - Tax;
        }

        public void RaiseSalary(double percentage)
        {
            GrossPay *= (1 + (percentage / 100.0));
        }

        public override string ToString()
        {
            return Name
                + ", $ "
                + NetPay().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
