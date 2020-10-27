using DNFS.Core.Modulos.Todo.Services;
using MvvmHelpers;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DNFS.Core.Modulos.Teste
{
    public class TesteViewModel : BaseViewModel
    {
        public ObservableRangeCollection<int> Numeros { get; set; }
        private DateTime? _data;

        public DateTime? Data
        {
            get { return _data; }
            set {SetProperty(ref _data , value); }
        }


        public TesteViewModel()
        {
            Numeros = new ObservableRangeCollection<int>();
        }

        public async Task ObterNumeros()
        {
            Numeros.Clear();
            var numeros = await ApiService.ObterNumeros<int>("");
            Numeros.ReplaceRange(numeros);

            await AtualizarNumeros();
        }

        private async Task AtualizarNumeros()
        {
            Data = DateTime.Now;
            await Task.Run(()=> new Timer(new TimerCallback(async _=> { await ObterNumeros(); }), null, 3000, Timeout.Infinite));
        }
    }
}
