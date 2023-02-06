namespace Exercicio_proposto.Entities
{
    public class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxesPaid()
        {
            double taxesPaid = 0;
            if (AnualIncome < 20000)
            {
                taxesPaid += AnualIncome * 0.15;
            }
            else
            {
                taxesPaid += AnualIncome * 0.25;
            }

            if (HealthExpenditures > 0)
            {
                taxesPaid -= HealthExpenditures * 0.5;
            }

            return taxesPaid;
        }
    }
}