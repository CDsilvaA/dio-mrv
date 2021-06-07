using System;
using bestiario.mythos.Enum;

namespace bestiario.mythos
{
    class Program
    {
        static BestiarioRepositorio repositorio = new BestiarioRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario){
                    case "1":
                        ListarBestiario();
                        break;
                    case "2":
                        InserirBestiario();
                        break;
                    case "3":
                        AtualizarBestiario();
                        break;
                    case "4":
                        ExcluirBestiario();
                        break;
                    case "5":
                        VisualizarBestiario();
                        break;
                    case "6":
                        Console.Clear();
                        break;

                    default:
                    throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }

            Console.WriteLine("Obrigado por cadastrar mais uma criatura terrível no Bestiário Mythos de Cthulhu.");
            Console.WriteLine();
        }

        private static void ListarBestiario()
        {
            Console.WriteLine("Listar besta");

            var lista = repositorio.Lista();

            if(lista.Count == 0)
            {
                Console.WriteLine("Nenhuma criatura terrível cadastrada.");
                return;
            }

            foreach(var besta in lista)
            {
                Console.WriteLine("#ID {0}: {1} ({2})", besta.retornaId(), besta.retornaNome(), besta.retornaDescricao());
            }

        }

        private static void InserirBestiario()
        {
            Console.WriteLine("Inserir informações da criatura terrível");
            Console.Write("\n");

            Console.Write("Lista de possíveis pistas sobre a criatura terrível:");
            Console.Write("\n");
            foreach(int i in Pistas.GetValues(typeof(Pistas)))
            {
                Console.WriteLine("{0}-{1}", i, Pistas.GetName(typeof(Pistas), i));
            }
            Console.Write('\n');
            Console.WriteLine("Digite a pista que possui sobre a criatura terrível entre as opções acima: ");
            int entradaPista = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da criatura terrível: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite uma habilidade que a criatura terrível possui: ");
            string entradaHabilidade = Console.ReadLine();

            Console.Write("Digite a descrição da criatura terrível: ");
            string entradaDescricao = Console.ReadLine();

            Bestiario novaBesta = new Bestiario(id: repositorio.ProximoID(),
                                                pista: (Pistas)entradaPista,
                                                nome: entradaNome,
                                                habilidade: entradaHabilidade,
                                                descricao: entradaDescricao);
            
            repositorio.Insere(novaBesta);
        }
        private static void AtualizarBestiario()
        {
            Console.Write("Digite o id da criatura terrível: ");
            int indiceBesta = int.Parse(Console.ReadLine());
            Console.Write("\n");

            Console.Write("Lista de possíveis pistas sobre a criatura terrível:");
             Console.Write("\n");
            foreach(int i in Pistas.GetValues(typeof(Pistas)))
            {
                Console.WriteLine("{0}-{1}", i, Pistas.GetName(typeof(Pistas), i));
            }
            Console.Write('\n');
            Console.WriteLine("Digite a pista que possui sobre a criatura terrível entre as opções acima: ");
            int entradaPista = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome da criatura terrível: ");
            string entradaNome = Console.ReadLine();

            Console.Write("Digite uma habilidade que a criatura terrível possui: ");
            string entradaHabilidade = Console.ReadLine();

            Console.Write("Digite a descrição da criatura terrível: ");
            string entradaDescricao = Console.ReadLine();

            Bestiario atualizaBesta = new Bestiario(id: repositorio.ProximoID(),
                                                pista: (Pistas)entradaPista,
                                                nome: entradaNome,
                                                habilidade: entradaHabilidade,
                                                descricao: entradaDescricao);
           repositorio.Atualiza(indiceBesta, atualizaBesta);
        }
        private static void ExcluirBestiario()
        {
            Console.Write("Digite o id da criatura terrível: ");
            int indiceBesta = int.Parse(Console.ReadLine());

            repositorio.Exclui(indiceBesta);
        }
        private static void VisualizarBestiario()
        {
            Console.Write("Digite o id da criatura terrível: ");
            int indiceBesta = int.Parse(Console.ReadLine());

            var besta = repositorio.RetornaPorId(indiceBesta);

            Console.WriteLine(besta);
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Bestiário Mythos de Cthulhu");
            Console.WriteLine("Informe a opção desejada:");

            Console.WriteLine("1 - Listar bestário");
            Console.WriteLine("2 - Inserir informações da criatura terrível");
            Console.WriteLine("3 - Atualizar bestiário");
            Console.WriteLine("4 - Excluir criatura terrível");
            Console.WriteLine("5 - Visualizar criatura terrível");
            Console.WriteLine("6 - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
