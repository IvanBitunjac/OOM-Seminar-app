using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOM_Seminar
{
    public partial class User : UserControl
    {
        private string receivedMessage;
        private string message;
        ConcreteMediator mediator;

        public User()
        {
            InitializeComponent();
            this.checkbox_Active.Checked = true;
        }

        public ConcreteMediator MediatorRef
        {
            get { return mediator; }
            set { this.mediator = value; }
        }


        public string Message
        {
            get { return message; }
            set { this.message = value; }
        }

        public string ReceivedMessage
        {
            get { return receivedMessage; }
            set
            {
                this.receivedMessage = value;
                this.listbox_previousMessages.Items.Insert(0, this.receivedMessage);
            }
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            this.Message = this.txtbox_Message.Text;
            mediator.Sender = this;
            mediator.SendMessage(this.message);
            this.txtbox_Message.Text = "";
        }

        //Returns true if user is active else false
        public bool IsActive()
        {
            if (checkbox_Active.Checked)
                return true;
            return false;
        }
    }
}
