using DNFS.Core.Modulos.Tarefas;
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
    }
}
