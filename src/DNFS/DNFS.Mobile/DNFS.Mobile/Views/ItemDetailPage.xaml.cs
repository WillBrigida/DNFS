using DNFS.Mobile.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace DNFS.Mobile.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}