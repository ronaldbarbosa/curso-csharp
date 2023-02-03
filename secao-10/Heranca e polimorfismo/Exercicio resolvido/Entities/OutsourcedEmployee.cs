namespace Exercicio_resolvido.Entities
{
    public class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double aditionalCharge) : base(name, hours, valuePerHour)
        {
            AdditionalCharge = aditionalCharge;
        }

        public override double Payment()
        {
            return (AdditionalCharge + (AdditionalCharge * 0.1)) + base.Payment();
        }
    }
}