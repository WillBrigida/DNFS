using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DNFS.Core.Services
{
    public interface IToastService
    {
         Task Success(string message);
         Task Warning(string message);
         Task Danger(string message);
    }
}
