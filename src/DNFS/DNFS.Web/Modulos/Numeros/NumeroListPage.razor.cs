using DNFS.Core.Modulos.Numeros;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace DNFS.Web.Modulos.Numeros
{
    public partial class NumeroListPage
    {
        [Inject]public NumeroListPageViewModel VM { get; set; }
        protected override async Task OnInitializedAsync()
        {
            VM.PropertyChanged += async (sender, e) =>
            {
                await InvokeAsync(() =>
                {
                    StateHasChanged();
                });
            };

            VM.IsBusy = true;
            await VM.ObterNumeros();
            await base.OnInitializedAsync();
        }
    }
}
