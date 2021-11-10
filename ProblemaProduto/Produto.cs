using System.Globalization;

namespace ProblemaProduto
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double valorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Nome + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + Quantidade + " unidades, Total: $ " 
                + valorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
