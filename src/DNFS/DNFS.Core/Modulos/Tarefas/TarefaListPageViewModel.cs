using MvvmHelpers;
using System.Threading.Tasks;

namespace DNFS.Core.Modulos.Tarefas
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
                var tarefas = await Services.ApiService.ObterTarefas<Tarefa>("", new { teste = 1 });
                Items.ReplaceRange(tarefas);
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
