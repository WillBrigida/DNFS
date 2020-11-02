using DNFS.Core.Modulos.Tabela;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace DNFS.Web.Modulos.Tabela
{
    public partial class TabelaPage 
    {
        [Inject] public TabelaPageViewModel VM { get; set; }

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
            await VM.ObterFuncionarios();
            await base.OnInitializedAsync();
        }
    }
}
