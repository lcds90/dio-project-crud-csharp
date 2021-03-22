using System;

namespace dio_project_crud_csharp
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string optionUser = GetOption();
            while(optionUser.ToUpper() != "X"){
                switch (optionUser)
                {
                    case "1":
                    ListarSeries();
                    break;
                    case "2":
                    InserirSerie();
                    break;
                    case "3":
                    AtualizarSerie();
                    break;
                    case "4":
                    ExcluirSerie();
                    break;
                    case "5":
                    VisualizarSerie();
                    break;
                    case "C":
                    Console.Clear();
                    break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine();
            optionUser = GetOption();

            }
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");
            Console.WriteLine("_________________");
            Console.WriteLine("");


            var lista = repositorio.List();
            if(lista.Count == 0){
                Console.WriteLine("Nenhuma série foi cadastrada.");
                return;
            }

            foreach(var serie in lista){
                var excluido = serie.returnExclude();
                Console.WriteLine("#ID {0}: - {1} / {2}", serie.returnId(), serie.returnTitle(), excluido ? "Sim" : "Não")  ;
            }
        }

        private static void InserirSerie()
        {
            Console.WriteLine("Inserir Nova Série");
            Console.WriteLine("_________________");
            Console.WriteLine("");

            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genre), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();
            
            Console.Write("Digite a descrição da série: ");
            string entradaDesc = Console.ReadLine();
            
            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Serie novaSerie = new Serie(
                repositorio.NextId(),
                (Genre)entradaGenero,
                entradaTitulo,
                entradaDesc,
                entradaAno
                );
                repositorio.Insert(novaSerie);
        }

        private static void AtualizarSerie()
        {
            Console.WriteLine("Atualizar Série");
            Console.WriteLine("_________________");
            Console.WriteLine("");

            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            foreach (int i in Enum.GetValues(typeof(Genre)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genre), i));
            }
            Console.Write("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            
            Console.Write("Digite o título da série: ");
            string entradaTitulo = Console.ReadLine();
            
            Console.Write("Digite a descrição da série: ");
            string entradaDesc = Console.ReadLine();
            
            Console.Write("Digite o Ano de Início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Serie atualizarSerie = new Serie(
                repositorio.NextId(),
                (Genre)entradaGenero,
                entradaTitulo,
                entradaDesc,
                entradaAno
                );
                repositorio.Update(indiceSerie, atualizarSerie);
        }

        private static void ExcluirSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            repositorio.Delete(indiceSerie);
        }

        private static void VisualizarSerie()
        {
            Console.Write("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            var serie = repositorio.ReturnById(indiceSerie);
            Console.WriteLine(serie);
        }

        private static string GetOption(){
            Console.WriteLine();
            Console.WriteLine("Bem vindo ao Repositório de Séries\n");
            Console.WriteLine();
            Console.WriteLine("________________________");
            Console.WriteLine();
            Console.WriteLine("1 - Listar Séries");
            Console.WriteLine("2 - Inserir Nova Série");
            Console.WriteLine("3 - Atualizar Série");
            Console.WriteLine("4 - Excluir Série");
            Console.WriteLine("5 - Visualizar Série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string option = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return option;

        }
    }
}
