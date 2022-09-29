using System;
namespace classes_atributos_metodos {
    class Program {
        public static void Main() {
            /* Exercício 1 */
            Console.WriteLine("Entre a largura e altura do retângulo:");
            double largura = Convert.ToDouble(Console.ReadLine());
            double altura = Convert.ToDouble(Console.ReadLine());
            Retangulo r = new Retangulo(largura, altura);
            Console.WriteLine($"AREA = {r.Area().ToString("F2")}");
            Console.WriteLine($"Perímetro = {r.Perimetro().ToString("F2")}");
            Console.WriteLine($"Diagonal = {r.Diagonal().ToString("F2")}");

            /* Exercício 2 */
            Console.Write("Nome: ");
            string nomeFuncionario = Console.ReadLine()!;
            Console.Write("Salário bruto: ");
            double salarioBruto = Convert.ToDouble(Console.ReadLine());
            Console.Write("Imposto: ");
            double imposto = Convert.ToDouble(Console.ReadLine());
            Funcionario funcionario = new Funcionario(nomeFuncionario, salarioBruto, imposto);
            Console.WriteLine($"Funcionário: {funcionario.ToString()}");
            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = Convert.ToDouble(Console.ReadLine());
            funcionario.AumentarSalario(porcentagem);
            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {funcionario.ToString()}");

            /* Exercício 3 */
            Console.Write("Nome do aluno: ");
            string nomeAluno = Console.ReadLine()!;
            Console.WriteLine("Digite as três notas do aluno:");
            double nota1 = Convert.ToDouble(Console.ReadLine());
            double nota2 = Convert.ToDouble(Console.ReadLine());
            double nota3 = Convert.ToDouble(Console.ReadLine());
            Aluno aluno = new Aluno(nomeAluno, nota1, nota2, nota3);
            Console.WriteLine(aluno.ToString());
        }
    }
}