using ControleBar.ConsoleApp.Compartilhado;
using ControleBar.ConsoleApp.ModuloGarcom;
using ControleBar.ConsoleApp.ModuloMesa;
using ControleBar.ConsoleApp.ModuloProduto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloConta
{
    public class Conta : EntidadeBase
    {
        public Mesa mesa;
        public Produto produto;
        public Garcom garcom;
        private bool estaDisponivel;

        public Conta(Mesa mesa)
        {
            this.mesa = mesa;

            Abrir();
        }
        public override string ToString()
        {
            return "Número Mesa: " + mesa.Numero + Environment.NewLine +
                "Pedido: " + produto.ProdutoNome + Environment.NewLine +
                "Garçom: " + garcom.Nome + Environment.NewLine;
        }
        public void Abrir()
        {
            if (!estaDisponivel)
            {
                estaDisponivel = true;

                mesa.RegistrarPedido(this);
            }
        }
        public void Fechar()
        {
            if (estaDisponivel)
            {
                estaDisponivel = false;

            }
        }
    }
}
