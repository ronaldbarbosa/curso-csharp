using Exercicio_resolvido.Entities.Enums;

namespace Exercicio_resolvido.Entities
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; } // Composição de objetos
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); // Composição de objetos (lista já iniciada para garantir que não seja nula)

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int mouth)
        {
            double sum = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == mouth)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}