using ControleBar.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloProduto
{
    public class Produto : EntidadeBase
    {
        public string ProdutoNome { get; set; }
        public string Disponibilidade { get; set; }
        public decimal Preco { get; set; } = 0m;

        public Produto(string produtonome, decimal preco, string disponibilidade)
        {
            ProdutoNome = produtonome;
            Disponibilidade = disponibilidade;
            Preco = preco;
        }

        public override string ToString()
        {
            return "Id: " + id + Environment.NewLine +
                "Nome do Produto: " + ProdutoNome + Environment.NewLine +
                "Preço: R$: " + Preco + Environment.NewLine +
                "Disponibilidade: " + Disponibilidade + Environment.NewLine;
        }
    
    }
}
