using DNFS.Core.Modulos.Estado;
using Microsoft.AspNetCore.Components;
using System.ComponentModel;
using System.Threading.Tasks;

namespace DNFS.Web.Modulos.Estado
{
    public partial class EstadoPage
    {
        [Inject]public EstadoViewModel VM { get; set; }

        protected override async Task OnInitializedAsync()
        {
            VM.PropertyChanged += Event();
            await base.OnInitializedAsync();
        }

        private PropertyChangedEventHandler Event()
        {
            return async (sender, e) =>
            {
                await InvokeAsync(() =>
                {
                    StateHasChanged();
                });
            };
        }

        public void Dispose()
        {
            VM.PropertyChanged -= Event();
        }
    }
}
