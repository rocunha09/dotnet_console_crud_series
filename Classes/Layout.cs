using dotnet_console_crud_series.Enums;

namespace dotnet_console_crud_series.Classes
{
    public class Layout
    {
        private static int opcao = 0;

        public static void TelaPrincipal()
        {
            //reseta menu
            opcao = 0;

            Console.Clear();

            Console.WriteLine("                                                         ");
            Console.WriteLine("                 Digite a opção desejada:                ");
            Console.WriteLine("                 =================================       ");
            Console.WriteLine("                 1 - Listar Séries                       ");
            Console.WriteLine("                 =================================       ");
            Console.WriteLine("                 2 - Cadastrar Série                     ");
            Console.WriteLine("                 =================================       ");
            Console.WriteLine("                 3 - Visualizar Série                    ");
            Console.WriteLine("                 =================================       ");
            Console.WriteLine("                 4 - Atualizar Série                     ");
            Console.WriteLine("                 =================================       ");
            Console.WriteLine("                 5 - Excluir Série                       ");
            Console.WriteLine("                 =================================       ");
            Console.WriteLine("                 6 - Sair                                ");
            Console.WriteLine("                 =================================       ");
            Console.WriteLine("                                                         ");

            while(opcao == 0)
            {
                opcao = int.Parse(Console.ReadLine());

            }    

            opEscolhida(opcao);

        }       
        private static void opEscolhida(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    //Listagem de Sérias cadastradas:
                    TelaListarSeries();
                    break;
                case 2:
                    //Tela de cadastro de séries (1 cadastrar / 2 atualizar)
                    TelaCadastrarSerie();
                    break;
                case 3:
                    //Visualizar série a partir de um ID
                    TelaVisualizarSerie();
                    break;
                case 4:
                    //Tela que permite atualizar uma série a partir de um ID
                    TelaAtualizarSerie();
                    break;
                case 5:
                    //Tela que permite excluir uma série a partir de um ID
                    TelaExcluirSerie();
                    break;
                case 6:
                    //Encerra programa
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opt invalida");
                    Thread.Sleep(1000);
                    Console.Clear();
                    TelaPrincipal();
                    break;
            }
        }
        private static void TelaListarSeries()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                 Lista de séries cadastradas             ");
            Console.WriteLine("                 =================================       ");

            //verifica a quantidade de séries cadastradas e itera sobre a lista...

            // if(seriesCadastradas == 0){
            //     Console.WriteLine();
            //     Console.WriteLine("                 Nenhuma Série cadastrada                ");
            //     Console.WriteLine("                 =================================       ");
                
            // } else {
            //     Console.WriteLine("          [Título] -\t [Descrição] -\t [Gênero]    ");
            //     Console.WriteLine("         -----------------------------------------");
                
            //     foreach (var serie in ListaSeries)
            //     {
            //         //imprime apenas as que não foram exclídas
            //         if(status == false){
            //             Console.WriteLine($"          {titulo} -\t {descricao} -\t {genero}    ");
            //             Console.WriteLine("         -----------------------------------------");
            //         }
            //     }
            // }

            Thread.Sleep(1500);
            Voltar();
        }
        private static void TelaCadastrarSerie()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                 Entre com o Título da série:  ");
            Console.WriteLine("                 =================================       ");
            string titulo = Console.ReadLine();

            Console.WriteLine("                 Entre com a Descrição da série:  ");
            Console.WriteLine("                 =================================       ");
            string descricao = Console.ReadLine();

            Console.WriteLine("                 Entre com o Ano de lançamento da série:  ");
            Console.WriteLine("                 =================================       ");
            string ano = Console.ReadLine();

            Console.WriteLine("                 Entre com o Gênero da série:  ");
            Console.WriteLine("                 =================================       ");
            Console.WriteLine();
            Console.WriteLine("                -------Lista de Gêneros------------");
            
            foreach(int i in Enum.GetValues(typeof(Genero))){
            Console.WriteLine($" \t\t {i} \t" + Enum.GetName(typeof(Genero), i)); 
            }

            Console.WriteLine("                ----------------------------------");
            int genero = int.Parse(Console.ReadLine());
            Console.WriteLine("                 =================================       ");

            //a criação da série dependerá do repositório... portando será alterado...
            //cria série e salva no repositório...
            
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"                 Série {titulo} cadastrada com sucesso! ");
            Console.WriteLine("                 =================================       ");

            //aguarda 0.5 segundos
            Thread.Sleep(1500);
            TelaPrincipal();
        }
        private static void TelaVisualizarSerie()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                 Entre com o ID da série:                ");
            Console.WriteLine("                 =================================       ");
            int id = int.Parse(Console.ReadLine());

            //busca no repositório e então imprime dados da série.
            //Console.WriteLine(s.ToString());

            Thread.Sleep(1500);
            Voltar();
        }
        private static void TelaAtualizarSerie()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                 Entre com o ID da série:                ");
            Console.WriteLine("                 =================================       ");
            int id = int.Parse(Console.ReadLine());

            //pesquisa série no repositório...

            Console.WriteLine();
            Console.WriteLine("                 Entre com o Título da série:  ");
            Console.WriteLine("                 =================================       ");
            string titulo = Console.ReadLine();

            Console.WriteLine("                 Entre com a Descrição da série:  ");
            Console.WriteLine("                 =================================       ");
            string descricao = Console.ReadLine();

            Console.WriteLine("                 Entre com o Ano de lançamento da série:  ");
            Console.WriteLine("                 =================================       ");
            string ano = Console.ReadLine();

            Console.WriteLine("                 Entre com o Gênero da série:  ");
            Console.WriteLine("                 =================================       ");
            Console.WriteLine();
            Console.WriteLine("                -------Lista de Gêneros------------");
            
            foreach(int i in Enum.GetValues(typeof(Genero))){
            Console.WriteLine($" \t\t {i} \t" + Enum.GetName(typeof(Genero), i)); 
            }

            Console.WriteLine("                ----------------------------------");
            int genero = int.Parse(Console.ReadLine());
            Console.WriteLine("                 =================================       ");

            //atualiza série no repositório...
            
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"                 Série {titulo} atualizada com sucesso! ");
            Console.WriteLine("                 =================================       ");

            //aguarda 0.5 segundos
            Thread.Sleep(1500);
            TelaPrincipal();
        }      
        private static void TelaExcluirSerie()
        {
            
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                 Entre com o ID da série:                ");
            Console.WriteLine("                 =================================       ");
            int id = int.Parse(Console.ReadLine());

            //busca no repositório e então altera o status para true.
            //

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"                 Série excluída com sucesso!            ");
            Console.WriteLine("                 =================================       ");

            //aguarda 1.5 segundos
            Thread.Sleep(1500);
            TelaPrincipal();
        }
        private static void Voltar()
        {
            opcao = 0;

            Console.WriteLine("                                                         ");
            Console.WriteLine("                 Digite a opção desejada:                ");
            Console.WriteLine("                 =================================       ");
            Console.WriteLine("                 1 - Voltar                              ");
            Console.WriteLine("                 =================================       ");
            Console.WriteLine("                 2 - Sair                                ");
            Console.WriteLine("                 =================================       ");
            Console.WriteLine("                                                         ");

            while(opcao == 0)
            {
                opcao = int.Parse(Console.ReadLine());

            }    

            opEscolhidaRetorno(opcao);
        }
        private static void opEscolhidaRetorno(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    //exibe a tela de criar conta:
                    TelaPrincipal();
                    break;
                case 2:
                    //Encerra programa
                    Environment.Exit(0);
                    break;
            }
        }

    }
}