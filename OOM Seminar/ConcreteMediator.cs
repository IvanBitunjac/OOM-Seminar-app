using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOM_Seminar
{
    public class ConcreteMediator : IMediator
    {
        List<User> users = new List<User>();
        User sender;

        public List<User> Users
        {
            get { return this.users; }
        }

        public User Sender
        {
            get { return this.sender; }
            set { this.sender = value; }
        }

        //Sends message to all active users
        public void SendMessage(string message)
        {
            if (message == "")
                return;

            foreach(User user in users)
            {
                if(user.Equals(sender) || !user.IsActive())
                {
                    continue;
                }
                else { user.ReceivedMessage = sender.Message; }
            }
        }

        //Automatically adds reference to mediator to added users
        public void AddUsers(User user)
        {
            user.MediatorRef = this;
            users.Add(user);

        }
    }
}
