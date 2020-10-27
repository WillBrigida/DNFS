using System;

namespace DNFS.Core.Modulos.Todo.Model
{
    public class Tarefa
    {
        public string Titulo { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Conteudo { get; set; }
        public bool RegistriAtivo { get; set; }

        public Tarefa(string titulo, string conteudo)
        {
            this.Conteudo = conteudo;
            this.Titulo = titulo;
            this.DataCriacao = DateTime.Now;
            RegistriAtivo = true;
        }
    }
}
