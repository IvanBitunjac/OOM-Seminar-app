using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOM_Seminar
{
    interface IMediator
    {
        void SendMessage(string message);
        void AddUsers(User user);
    }
}
