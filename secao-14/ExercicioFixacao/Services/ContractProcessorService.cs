using ExercicioFixacao.Entities;

namespace ExercicioFixacao.Services
{
    class ContractProcessorService
    {
        private IPaymentService _paymentService;
        public ContractProcessorService(IPaymentService paymentService) 
        {
            _paymentService = paymentService;
        }
        public void ProcessContract(Contract contract, int numberOfInstallments)
        {
            double basicInstallment = contract.TotalValue / numberOfInstallments;

            for (int i = 1;  i <= numberOfInstallments; i++)
            {
                DateTime date = contract.Date.AddMonths(1);
                double updatedInstallment = basicInstallment + _paymentService.Interest(basicInstallment, i);
                double totalInstallment = updatedInstallment + _paymentService.PaymentFee(updatedInstallment);
                contract.AddInstallment(new Installment(date, totalInstallment));
            }
        }
    }
}
