using DNFS.Core.Modulos.Todo.ViewModel;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace DNFS.Web.Pages.Todo
{
    public partial class TarefaListPage
    {
        [Inject]public TarefaListPageViewModel VM { get; set; }
        protected override async Task OnInitializedAsync()
        {
            VM.IsBusy = true;
            await VM.ObterTarefas();

            VM.PropertyChanged += async (sender, e) => {
                await InvokeAsync(() =>
                {
                    StateHasChanged();
                });
            };
            await base.OnInitializedAsync();
        }
    }
}
