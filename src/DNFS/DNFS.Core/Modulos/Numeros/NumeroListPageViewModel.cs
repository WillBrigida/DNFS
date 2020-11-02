using DNFS.Core.Services;
using DNFS.Core.Utils;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DNFS.Core.Modulos.Numeros
{
    public class NumeroListPageViewModel : BaseViewModel
    {

        public MvvmHelpers.ObservableRangeCollection<int> Numeros { get; set; }
        private DateTime? _data; public DateTime? Data
        {
            get => _data;
            set => SetProperty(ref _data, value);
        }

        public NumeroListPageViewModel()
        {
            Title = "Numeros";
            Numeros = new MvvmHelpers.ObservableRangeCollection<int>();
        }

        public async Task ObterNumeros()
        {
            var numeros = await ApiService.ObterNumeros<int>("");
            Numeros.ReplaceRange(numeros);

            await AtualizarNumeros();
        }

        private async Task AtualizarNumeros()
        {
            Console.WriteLine("=====> AtualizarNumeros");
            Data = DateTime.Now;
            await Task.Run(() => new Timer(new TimerCallback(async _ => { await ObterNumeros(); }), null, 3000, Timeout.Infinite));
        }
    }
}
