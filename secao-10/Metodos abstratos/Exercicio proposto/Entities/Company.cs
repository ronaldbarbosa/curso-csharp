namespace Exercicio_proposto.Entities
{
    public class Company : TaxPayer
    {
        public int EmployeesNumber { get; set; }
        public Company(string name, double anualIncome, int employeesNumber) : base(name, anualIncome)
        {
            EmployeesNumber = employeesNumber;
        }

        public override double TaxesPaid()
        {
            double taxesPaid = 0;
            if (EmployeesNumber > 10)
            {
                taxesPaid += AnualIncome * 0.14;
            }
            else
            {
                taxesPaid += AnualIncome * 0.16;
            }

            return taxesPaid;
        }
    }
}