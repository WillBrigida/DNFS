using DNFS.Core.Modulos.ParametrosArbitrarios;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace DNFS.Web.Modulos.ParametrosArbitrarios
{
    public partial class ParametroArbPage
    {
        [Inject] public ParametroArbPageViewModel VM { get; set; }
       
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
