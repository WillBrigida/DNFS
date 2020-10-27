using DNFS.Core.Modulos.Todo.Model;
using MvvmHelpers;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DNFS.Core.Modulos.Todo.ViewModel
{
    public class TarefaListPageViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Tarefa> Items { get; set; }

        #region Commads
        #endregion
        public TarefaListPageViewModel()
        {
            Items = new ObservableRangeCollection<Tarefa>();
            Title = "Tarefas";
        }

        public virtual async Task ObterTarefas()
        { 
            try 
	        {
                var items = await Services.ApiService.ObterTarefas<Tarefa>("", new { teste = 1 });

                foreach (var item in items)
                    System.Console.WriteLine(item.Conteudo);

                Items.AddRange(items);
            }
	        catch (global::System.Exception)
	        {
		        throw;
	        }
            finally
            {
                IsNotBusy = true;
            }
           
        }

    }
}
