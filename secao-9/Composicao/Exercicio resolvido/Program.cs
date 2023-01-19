using Exercicio_resolvido.Entities;
using Exercicio_resolvido.Entities.Enums;

namespace Exercicio_resolvido
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Enter departament's name: ");
            Departament workerDepartament = new Departament(Console.ReadLine());
            Console.WriteLine();
            
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string workerName = Console.ReadLine();
            Console.Write("Level (Junior, Pleno, Senior): ");
            WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            double workerBaseSalary = double.Parse(Console.ReadLine());

            Worker worker = new Worker(workerName, workerLevel, workerBaseSalary, workerDepartament);

            Console.Clear();
            Console.Write("How many contracts to this worker: ");
            int numberOfContracts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfContracts; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (MM/DD/YYYY): ");
                DateTime contractDate = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours): ");
                int duration = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(contractDate, valuePerHour, duration);
                worker.AddContract(contract);
                Console.WriteLine();
            }

            Console.Clear();
            Console.Write("Enter mouth and year to calculate income (MM/YYYY): ");
            string dateIncomeInput = Console.ReadLine();
            int dateIncomeMouth = int.Parse(dateIncomeInput.Substring(0, 2));
            int dateIncomeYear = int.Parse(dateIncomeInput.Substring(3));
            Console.WriteLine($"Name: {worker.Name}\nDepartament: {worker.Departament.Name}\nIncame for {dateIncomeMouth}/{dateIncomeYear} : {worker.Income(dateIncomeYear, dateIncomeMouth).ToString("F2")}");
        }
    }
}