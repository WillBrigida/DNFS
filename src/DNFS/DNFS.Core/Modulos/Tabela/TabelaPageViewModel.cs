using DNFS.Core.Services;
using DNFS.Core.Services.ModelsTeste;
using DNFS.Core.Utils;
using System.Threading.Tasks;

namespace DNFS.Core.Modulos.Tabela
{
    public class TabelaPageViewModel : BaseViewModel
    {
        public MvvmHelpers.ObservableRangeCollection<Funcionario> Funcionarios { get; set; }

        public TabelaPageViewModel()
        {
            Funcionarios = new MvvmHelpers.ObservableRangeCollection<Funcionario>();
        }

        public async Task ObterFuncionarios()
        {
            Title = "Tabela";

            try
            {
                Funcionarios.ReplaceRange(await ApiService.ObterFuncionarios<Funcionario>());
            }
            finally
            {
                IsVisible = IsBusy = false;
            }
        } 
    }
}
