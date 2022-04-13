using ControleBar.ConsoleApp.Compartilhado;
using ControleBar.ConsoleApp.ModuloConta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        public string Numero { get; set; }
        public string Pedido { get; set; }
        public decimal Gorjeta { get; set; } = 0m;
        public decimal Conta { get; set; } = 0m;

        private readonly List<Conta> historicoPedidos = new List<Conta>();

        public Mesa(string numero, string pedido, decimal conta, decimal gorjeta)
        {
            Numero = numero;
            Pedido = pedido;
            Conta = conta;
            Gorjeta = gorjeta;
        }

        public override string ToString()
        {
            return "Id: " + id + Environment.NewLine +
                "Numero da mesa: " + Numero + Environment.NewLine +
                "Pedido: " + Pedido + Environment.NewLine +
                "Conta: R$" + Conta + Environment.NewLine +
                "Gorjeta: R$" + Gorjeta + Environment.NewLine;

        }
        public void RegistrarPedido(Conta conta)
        {
            historicoPedidos.Add(conta);
        }
        public void MesaGorjeta(decimal gorjetaCalculada)
        {
            Gorjeta += gorjetaCalculada;
        }
    }
}
