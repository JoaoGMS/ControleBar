using ControleBar.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;

namespace ControleBar.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TelaMenuPrincipal telaMenuPrincipal = new TelaMenuPrincipal(new Notificador());

            while (true)
            {
                TelaBase telaSelecionada = telaMenuPrincipal.ObterTela();

                if (telaSelecionada is null)
                    break;

                string opcaoSelecionada = telaSelecionada.MostrarOpcoes();

                if (telaSelecionada is ITelaCadastravel)
                {
                    ITelaCadastravel telaCadastroBasico = (ITelaCadastravel)telaSelecionada;

                    if (opcaoSelecionada == "1")
                        telaCadastroBasico.Inserir();

                    if (opcaoSelecionada == "2")
                        telaCadastroBasico.Editar();

                    if (opcaoSelecionada == "3")
                        telaCadastroBasico.Excluir();

                    if (opcaoSelecionada == "4")
                        telaCadastroBasico.VisualizarRegistros("Tela");
                }
            }
        }
    }
    
    public class Conta 
    {
        
        public double valorTotal
        
    }
    public class Pedido : Produto
    {
        
        public static void Main(string[] args)
        {

        }

    }
    public class Produto
    {
        
    }
    namespace ControleBar.ConsoleApp.ModuloMesa
    {
        public class Mesa : EntidadeBase
        {
             public int numero { get; set; }
             public Mesa(int numero)
             {
                 this.numero = numero;
             }
        }
        public int ObterNumeroRegistro() 
        {
            int numeroRegistro
            bool numeroRegistroEncontrado
            do
            {
                Console.Write("Digite o Numero da mesa que deseja selecionar:");
                numeroRegistro = Convert.ToInt32(Console.ReadLine());
                numeroRegistroEncontrado = _repositorioMesa.ExisteRegistro(numeroRegistro);
                if (numeroRegistroEncontrado == false)
                    _notificador.ApresentarMensagem("Numero da mesa não foi encontrado, digite novamente", TipoMensagem.Atencao)

            

        }while (numeroRegistroEncontrado == false);   }
    }
    namespace ControleBar.ConsoleApp.ModuloMesa
    {
        
         public class TelaCadastroMesa : TelaBase, ITelaCadastravel
         {
       
             private readonly IRepositorio<Mesa>_repositorioMesa;
             private readonly Notificador _notificador;
             public TelaCadastroMesa(IRepositorio<Mesa> repositorioMesa, Notificador notificador)
                :base("Cadastro de Mesa")
             {
                _repositorioMesa = repositorioMesa;
                _notificador = notificador;
             }
            public void Inserir()
            {
            MostrarTitulo ("Cadastro de Mesa")
            Mesa novaMesa = ObterMesa();
            _repositorioMesa.Inserir(novaMesa);
            _notificador.ApresentarMensagem("Mesa Cadastrada com sucesso!"), TipoMensagem.Sucesso);
            }
            public void Editar()
            {
                MostrarTitulo("Editando Mesa")
                bool temRegistrosCadastrados = VisualizarRegistro("Pesquisando");
                if (temRegistrosCadastrados == false)
                {
                _notificador.ApresentarMensagem("Nenhuma mesa cadastrada para editar");
                    return;
                }
                int numeroGenero = ObterNumeroRegistro();
                Mesa mesaAtualizada = ObterMesa();
             bool conseguiuEditar = _repositoroMesa.Editar(numeroMesa, mesaAtualizada);
                if(!conseguiuEditar)
                _notificador.ApresentarMensagem("Não é possivel editar.", TipoMensagem.erro);
                else
                _notificador.ApresentarMensagem("Mesa editada com sucesso!", TipoMensagem.Sucesso);
            }
            public void Excluir()
            {
                MostrarTitulo("Excluir Mesa");
             bool temMesaRegistrada = VisualizarRegistros("Pesquisando");

                if(temMesaRegistrada == false)
                {
                _notificador.ApresentarMensagem("Nenhuma mesa cadastrada para excluir ", TipoMensagem.Atencao);
                return;
                }
             int numeroMesa = ObterNumeroMesa();
                bool conseguiuExcluir = _repositorioMesa.Excluir(numeroMesa);
                if(!conseguiuExcluir)
                _notificador.ApresentarMensagem("Não foi possivel excluir.", TipoMensagem.Erro);
                else
                _notificador.ApresentarMensagem("Mesa excluída com sucesso!", TipoMensagem.Sucesso);
            }
                public bool VisualizarRegistros(string TipoVisualização)
                {
                if(tipoVisualizacao == "Tela" )
                MostrarTitulo("Visualização de mesas cadastradas");
                List<Mesa>mesas = _repositorioMesa.SelecionarTodos();

                 if (mesa.Count() == 0)
                 {
                _notificador.ApresentarMensagem("Nenhum garçon disponivel.", TipoMensagem.Atencao);
                return false;
                 }
                foreach (Mesa mesa in mesas)
                Console.Writeline(mesa.ToString);

             Console.ReadLine();
             return true;

            }
                private Mesa ObterMesa()
                {
                 Console.Write("Digite o número da mesa:");
                 int numero = Convert.ToInt32(Console.ReadLine());
                }
        
         }
     }
    
    
}
