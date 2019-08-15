using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Teste
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorTotalEmEstoque()
        {
            return Quantidade * Preco;
        }

        public int AdicionarProdutos(int adicionar)
        {
            return Quantidade += adicionar;
        }

        public int RemoverProdutos(int subitrair)
        {
            return Quantidade -= subitrair;
        }
    }
}
