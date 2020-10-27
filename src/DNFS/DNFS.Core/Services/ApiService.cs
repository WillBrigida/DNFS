using DNFS.Core.Modulos.Todo.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DNFS.Core.Modulos.Todo.Services
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
    }
}
