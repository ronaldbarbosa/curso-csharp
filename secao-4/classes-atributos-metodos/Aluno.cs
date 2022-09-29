namespace classes_atributos_metodos
{
    public class Aluno
    {
        private string Nome;
        private double Nota1, Nota2, Nota3, NotaFinal;

        public Aluno(string nome, double nota1, double nota2, double nota3) {
            this.Nome = nome;
            this.Nota1 = nota1;
            this.Nota2 = nota2;
            this.Nota3 = nota3;
            this.NotaFinal = nota1 + nota2 + nota3;
        }

        public override string ToString()
        {
            if(this.NotaFinal < 60) return $"NOTA FINAL = {this.NotaFinal.ToString("F2")}\nREPROVADO\nFALTARAM {(60 - this.NotaFinal).ToString("F2")} PONTOS";
            else return $"NOTA FINAL = {this.NotaFinal.ToString("F2")}\nAPROVADO";
        }
    }
}