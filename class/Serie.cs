using System;

namespace dio_project_crud_csharp
{
    public class Serie : EntidadeBase
    {
        public Serie(int id, Genre genre, string title, string desc, int year)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Desc = desc;
            this.Year = year;
            this.Exclude = false;
        }
        private Genre Genre { get; set; }
        private string Title { get; set; }
        private string Desc { get; set; }
        private int Year { get; set; }

        private bool Exclude {get; set;}

        public override string ToString()
        {
            string message = "";
            message += "Título: " + this.Title + Environment.NewLine;
            message += "Gênero: " + this.Genre + Environment.NewLine;
            message += "Descrição: " + this.Desc + Environment.NewLine;
            message += "Ano de Início: " + this.Year + Environment.NewLine;
            message += "Está excluido: " + this.Exclude + Environment.NewLine;
            return message;
        }

        public string returnTitle(){
            return this.Title;
        }

        public int returnId(){
            return this.Id;
        }

        public bool returnExclude(){
            return this.Exclude;
        }

        public void Remove(){
            this.Exclude = true;
        }
    }
}