using DNFS.Core.Modulos.Modal;
using DNFS.Web.Components;
using Microsoft.AspNetCore.Components;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace DNFS.Web.Modulos.Modal
{
    public partial class ModalPage
    {
        [Inject] public ModalPageViewModel VM { get; set; }
       
        protected ModalComponent modalComponent;

        protected override async Task OnInitializedAsync()
        {
            VM.PropertyChanged += PropertyChangedEvent();
            await base.OnInitializedAsync();
            VM.IsVisible = false;
        }

        private PropertyChangedEventHandler PropertyChangedEvent()
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
            VM.PropertyChanged -= PropertyChangedEvent();
        }
    }
}
