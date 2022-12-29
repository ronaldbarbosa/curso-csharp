using System.Globalization;
namespace construtores_palavra_this_sobrecarga_encapsulamento
{
    class Produto
    {
        private string _nome;
        // Auto propertie
        public double Preco { get; private set; } 
        private int _quantidade;

        // No C#, diferente do Java, os parâmetros do construtor são nomeados com a primeira letra minúscula.
        // Atributos privados tem nome começando com underline e letra minúscula.
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            _quantidade = quantidade;
        }

        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
        }

        public Produto()
        {
        }

        // Properties
        // Value: é o parâmetro enviado no método set
        public string Nome {
            get { return _nome; }
            set {
                if(value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}