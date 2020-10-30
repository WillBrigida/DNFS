using MvvmHelpers;
using System;
using System.Threading.Tasks;

namespace DNFS.Core.Modulos.Estado
{
    public class EstadoViewModel : BaseViewModel
    {
        private string _valor;

        public string Valor
        {
            get => _valor; 
            set => SetProperty(ref _valor , value); 
        }

        public EstadoViewModel()
        {
            Title = "Estado";
            Valor = "Valor inicial MVVM";
        }

        public async Task DefinirValor()
        {
            Valor = $" Novo valor - {DateTime.Now}";
            Console.WriteLine($"Entrou btn -  {Valor}" );

        }
    }
}
