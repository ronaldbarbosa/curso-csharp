namespace ExercicioFixacao.Services
{
    class PayPalPaymentService : IPaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MontlyInterest = 0.01;

        public double PaymentFee(double amount)
        {
            return amount * FeePercentage;
        }
        public double Interest(double amount, int months)
        {
            return amount * MontlyInterest * months;
        }
    }
}
