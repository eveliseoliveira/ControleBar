using ControleBar.ConsoleApp.Compartilhado;
using ControleBar.ConsoleApp.ModuloGarcom;
using ControleBar.ConsoleApp.ModuloMesa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBar.ConsoleApp.ModuloConta
{
    public class TelaCadastroConta : TelaBase
    {
        private readonly Notificador notificador;
        private readonly IRepositorio<Conta> repositorioConta;
        private readonly IRepositorio<Mesa> repositorioMesa;
        private readonly IRepositorio<Garcom> repositorioGarcom;

        public TelaCadastroConta(
            Notificador notificador,
            IRepositorio<Conta> repositorioConta,
            IRepositorio<Mesa> repositorioMesa,
            IRepositorio<Garcom> repositorioGarcom,
            TelaCadastroMesa telaCadastroMesa) : base("Cadastro de Pedidido")
        {
            this.notificador = notificador;
            this.repositorioConta = repositorioConta;
            this.repositorioMesa = repositorioMesa;
            this.repositorioGarcom = repositorioGarcom;
        }
        public override string MostrarOpcoes()
        {
            MostrarTitulo(Titulo);

            Console.WriteLine("Digite 1 para Registrar Pedido");

            Console.WriteLine("Digite s para sair");

            string opcao = Console.ReadLine();

            return opcao;
        }
        public void RegistrarEmprestimo()
        {
            MostrarTitulo("Inserindo novo Pedidido");

            Mesa mesaSelecionada= ObterMesa();

            if (mesaSelecionada == null)
            {
                notificador.ApresentarMensagem("Nenhuma mesa selecionado", TipoMensagem.Erro);
                return;
            }
            }
        }
}
