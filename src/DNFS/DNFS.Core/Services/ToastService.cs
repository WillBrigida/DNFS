using DNFS.Core.Utils;
using System;
using System.Threading.Tasks;

namespace DNFS.Core.Services
{
    public class ToastService : BaseViewModel
    {
        enum types { success = 1, warning = 2, danger = 3 };
        int? type = null;

        public static ToastService Current { get; set; }
        public ToastService()
        {
            Current = (Current == null) ? new ToastService() : Current;
        }

        public async Task Success(string message)
        {
            type = (int)types.success;
            Message = message;
        }

        public async Task Warning(string message)
        {
            type = (int)types.warning;
            Message = message;
        }

        public async Task Danger(string message)
        {
            type = (int)types.danger;
            Message = message;
        }
    }
}
