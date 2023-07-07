namespace ExercicioFixacao.Services
{
    interface IPaymentService
    {
        double Interest(double amount, int months);
        double PaymentFee(double amount);
    }
}
