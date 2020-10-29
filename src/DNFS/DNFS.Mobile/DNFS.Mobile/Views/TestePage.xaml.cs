using DNFS.Core.Modulos.Teste;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DNFS.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestePage : ContentPage
    {
        public TesteViewModel VM { get; set; }
        public TestePage()
        {
            InitializeComponent();
            BindingContext = VM = new TesteViewModel();
        }

        protected override async void OnAppearing()
        {
            await VM.ObterNumeros();
            base.OnAppearing();
        }
    }
}