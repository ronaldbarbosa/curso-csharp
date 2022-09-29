namespace classes_atributos_metodos
{
    public class Funcionario
    {
        private string Nome;
        private double SalarioBruto;
        private double Imposto;

        public Funcionario(string nome, double salarioBruto, double imposto) {
            this.Nome = nome;
            this.SalarioBruto = salarioBruto;
            this.Imposto = imposto;
        }

        public double SalarioLiquido() {
            return this.SalarioBruto - this.Imposto;
        }

        public void AumentarSalario(double porcentagem) {
            this.SalarioBruto = this.SalarioBruto + (this.SalarioBruto * (porcentagem / 100));
        }

        public override string ToString()
        {
            return $"{this.Nome}, $ {this.SalarioLiquido().ToString("F2")}";
        }
    }
}