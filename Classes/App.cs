using dotnet_console_crud_series.Classes;
using dotnet_console_crud_series.Enums;

namespace dotnet_console_crud_series.classes
{
public class App
    {
        public static void Run()
        {
            SerieRepositorio serieRepositorio = new SerieRepositorio();
            Layout.serieRepositorio = serieRepositorio;
            
            Layout.TelaPrincipal();
        }


        public static void TesteRun()
        {

            //testa criação de uma série e mudança de status...
            TestarSerie();

        }

        private static void TestarSerie()
        {
            // Serie s = new Serie(
            //     100, 
            //     "Heroes",
            //     "Série de Heróis",
            //     "2006",
            //     Genero.Ficcao_Cientifica
            // );

            // Console.WriteLine(s.ToString());
            // Console.WriteLine("Excluído: " + s.getStatus());
            // s.Excluir();
            // Console.WriteLine("Excluído: " + s.getStatus());
        }
    }
}