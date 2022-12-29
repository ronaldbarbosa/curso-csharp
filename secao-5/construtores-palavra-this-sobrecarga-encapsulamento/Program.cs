using System;
using System.Globalization;
namespace construtores_palavra_this_sobrecarga_encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p1 = new Produto(nome, preco, quantidade);

            // Sintaxe alternativa para instanciar objeto (Necessita do construtor sem argumentos). 
            // Funciona apenas em classe com atributos públicos
            // Produto p2 = new Produto { Nome = "PC", Preco = 3000.00, Quantidade = 5 };
            
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p1);
            Console.WriteLine();
            
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p1.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p1);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p1.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p1);

        }
    }
}