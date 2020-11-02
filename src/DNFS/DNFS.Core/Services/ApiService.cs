using DNFS.Core.Modulos.Tarefas;
using DNFS.Core.Services.ModelsTeste;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DNFS.Core.Services
{
    public class ApiService
    {
        internal static async Task<List<Tarefa>> ObterTarefas<T>(string v, object p)
        {
            var lista = new List<Tarefa>
            {
                new Tarefa("Acordar", "Acordar cedo amanhã."),
                new Tarefa("Compras", "Ir ao mercado após o trabalho."),
                new Tarefa("Estudo", "Estudar Blazor"),
            };

            await Task.Delay(2000);
            return await Task.Run(() => lista);
        }

        internal static async Task<List<int>> ObterNumeros<T>(string v)
        {
            var lista = new List<int>();
            for (int i = 0; i < 10; i++)
                lista.Add(new Random().Next(0,9));

            return await Task.Run(()=> lista);
        }

        internal static async Task<List<Funcionario>> ObterFuncionarios<T>()
        {
            var lista = new List<Funcionario> 
            {
                new Funcionario("Will", "Brigida"),
                new Funcionario("Arthur", "Brigida"),
                new Funcionario("Miriam", "Brigida"),
                new Funcionario("Mafria Eduarda", "Brigida"),
                new Funcionario("Luiza", "Brigida"),
                new Funcionario("Victória", "Brigida"),
                new Funcionario("Flavia", "Brigida"),
                new Funcionario("Érica", "Brigida"),
                new Funcionario("Marcia", "Brigida"),
            };

            await Task.Delay(2000);

            return await Task.Run(() => lista);
        }
    }
}
