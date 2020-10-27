using DNFS.Core.Modulos.Teste;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNFS.Web.Pages.Teste
{
    public partial class TestePage
    {
        [Inject]public TesteViewModel VM { get; set; }
        protected override async Task OnInitializedAsync()
        {
            VM.IsBusy = true;
            await VM.ObterNumeros();

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
