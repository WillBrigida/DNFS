
using DNFS.Core.Utils;
using System;
using System.Runtime.CompilerServices;

namespace DNFS.Core.Modulos.Modal
{
    public class ModalPageViewModel : BaseViewModel
    {
        public ModalPageViewModel()
        {
            Title = "Modal";
        }

        public void ChamarModal()
        {
            Console.WriteLine($"ChamarModal VM {IsVisible}");
            IsVisible = true;
        }
    }
}
