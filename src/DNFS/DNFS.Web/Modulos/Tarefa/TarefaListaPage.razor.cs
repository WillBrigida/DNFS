using DNFS.Core.Modulos.Tarefas;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;


namespace DNFS.Web.Modulos.Tarefa
{
    public partial class TarefaListaPage
    {
        [Inject]  TarefaListPageViewModel VM { get; set; }

        protected override async Task OnInitializedAsync()
        {
            VM.PropertyChanged += async (sender, e) =>
            {
                await InvokeAsync(() =>
                {
                    StateHasChanged();
                });
            };

            VM.IsBusy = VM.IsVisible = true;
            await VM.ObterTarefas();
            await base.OnInitializedAsync();
        }
    }
}
