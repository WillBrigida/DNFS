using DNFS.Core.Utils;
using System.Threading.Tasks;
using System.Threading;
using DNFS.Core.Services;

namespace DNFS.Core.Modulos.Toast
{
    public class ToastPageViewModel : BaseViewModel
    {
        readonly IToastService _toast;
        public ToastPageViewModel(IToastService toast)
        {
            Title = "Toast";
            _toast = toast;
        }

        public async Task MostrarToast()
        {
            //Message = "Teste Mensagem";
            //IsVisible = true;
            //await NotIsVisibleToast();
             await _toast.Danger("Teste danger");
        }

        async Task NotIsVisibleToast()
        {
            await Task.Run(() => new Timer(new TimerCallback(async _ =>
            {
                IsVisible = false;
                //Display = "none";
                //StateHasChanged();
            }), null, 6000, 0));
        }
    }
}
