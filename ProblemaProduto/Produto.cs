using System.Globalization;

namespace ProblemaProduto
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double valorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + Quantidade + " unidades, Total: $ " 
                + valorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
    }
}
