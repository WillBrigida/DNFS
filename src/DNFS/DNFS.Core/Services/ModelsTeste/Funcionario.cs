using System;

namespace DNFS.Core.Services.ModelsTeste
{
    public class Funcionario
    {
        public Guid FuncionarioId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataContrato { get; set; }
        public Decimal Salario { get; set; }

        public Funcionario(string nome, string sobrenome )
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.DataContrato = DateTime.Now;
            this.Salario = 10.000M;
            this.FuncionarioId = new Guid();
        }
    }
}
