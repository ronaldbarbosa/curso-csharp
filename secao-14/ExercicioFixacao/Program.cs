using System.Globalization;

using ExercicioFixacao.Entities;
using ExercicioFixacao.Services;

Console.WriteLine("Enter contract data");

Console.Write("Number: ");
int contractNumber = int.Parse(Console.ReadLine());
Console.Write("Date (dd/MM/yyyy): ");
DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.Write("Contract value: ");
double contractValue = double.Parse(Console.ReadLine());
Console.Write("Enter number of installments: ");
int contractInstallments = int.Parse(Console.ReadLine());


Contract contract = new Contract(contractNumber, contractDate, contractValue);

ContractProcessorService contractProcessorService = new ContractProcessorService(new PayPalPaymentService());
contractProcessorService.ProcessContract(contract, contractInstallments);

Console.WriteLine("Installments");
foreach (Installment installment in contract.Installments)
{
    Console.WriteLine(installment);
}