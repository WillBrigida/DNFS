using DNFS.Core.Modulos.Toast;
using Microsoft.AspNetCore.Components;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Threading;
using DNFS.Core.Services;
using System;
using DNFS.Web.Components;

namespace DNFS.Web.Modulos.Toast
{
    public partial class ToastPage : IToastService
    {
        [Inject] public ToastPageViewModel VM { get; set; }
        private ToastComponent toastComponent;
        public static bool IsVisible { get; set; }
        public static string Mss { get; set; }

        protected override async Task OnInitializedAsync()
        {
            VM.PropertyChanged += PropertyChangedEvent();
            await base.OnInitializedAsync();

            Console.WriteLine($"OnInitializedAsync");
        }

        protected override Task OnAfterRenderAsync(bool firstRender)
        {
            if(firstRender)
                Console.WriteLine($"OnAfterRenderAsync");

            return base.OnAfterRenderAsync(firstRender);
        }

        private PropertyChangedEventHandler PropertyChangedEvent()
        {
            return async (sender, e) =>
            {
                await InvokeAsync(() =>
                {
                    Console.WriteLine($"StateHasChanged");

                    StateHasChanged();
                });
            };
        }

        public void Dispose() => VM.PropertyChanged -= PropertyChangedEvent();

        public async Task MostrarToast()
        {
            VM.Message = "Teste Mensagem";
            IsVisible = true;
            await NotIsVisibleToast();
        }

        async Task NotIsVisibleToast()
        {
            await Task.Run(() => new Timer(new TimerCallback(async _ =>
            {
                IsVisible = false;
                StateHasChanged();
            }), null, 6000, 0));
        }

        public Task Success(string message)
        {
            throw new System.NotImplementedException();
        }

        public Task Warning(string message)
        {
            throw new System.NotImplementedException();
        }

        public async Task Danger(string message)
        {
            Console.WriteLine($"Funcionou! {Mss} \n {IsVisible}");
            IsVisible = true;
            Mss = message;
            IsVisible = true;
        }
    }
}