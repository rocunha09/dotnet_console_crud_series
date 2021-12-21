using dotnet_console_crud_series.Enums;

namespace dotnet_console_crud_series.Classes
{
    public class Serie : Midia
    {
        private string titulo { get; set; }
        private string descricao { get; set; }
        private string ano { get; set; }
        private Genero genero { get; set; }
        private bool status { get; set; }

        public Serie(int id, string titulo, string descricao, string ano, Genero genero)
        {
            this.id = id;
            this.titulo = titulo;
            this.descricao = descricao;
            this.ano = ano;
            this.genero = genero;
            this.status = false;
        }

        public string ToString()
        {
            string informacoes = "";
            informacoes += "\t----------------------------------------" + Environment.NewLine;
            informacoes += "\tTítulo: \t" + this.titulo + Environment.NewLine; 
            informacoes += "\tDescrição: \t" + this.descricao + Environment.NewLine; 
            informacoes += "\tAno: \t\t" + this.ano + Environment.NewLine; 
            informacoes += "\tGênero: \t" + this.genero + Environment.NewLine; 
            informacoes += "\t----------------------------------------" + Environment.NewLine;

            return informacoes;
        }

        public string getTitulo()
        {
            return this.titulo;
        }

        public int getId(string id)
        {
            return this.id;
        }

        public void Excluir()
        {
            this.status = true;
        }

        public bool getStatus()
        {
            return this.status;
        }


    }
}