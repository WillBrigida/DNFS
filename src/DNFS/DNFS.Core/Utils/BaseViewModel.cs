using System;
using System.Collections.Generic;
using System.Text;

namespace DNFS.Core.Utils
{
    public class BaseViewModel : MvvmHelpers.BaseViewModel
    {
        #region Propriedades        
        private bool _isVisibele; public bool IsVisible
        {
            get => _isVisibele; 
            set => SetProperty(ref _isVisibele, value); 
        }

        private string _message; public string Message
        {
            get => _message;
            set => SetProperty(ref _message, value);
        }
        #endregion

        public void OnExitModal() =>IsVisible = false;
    }
}
