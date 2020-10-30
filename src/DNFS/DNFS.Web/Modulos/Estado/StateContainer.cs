using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DNFS.Web.Modulos.Estado
{
    public class StateContainer
    {
        public string Property { get; set; } = "Initial value from StateContainer";

        public event Action OnChange;

        public void SetProperty(string value)
        {
            Property = value;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
