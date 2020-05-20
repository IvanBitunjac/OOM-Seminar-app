using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOM_Seminar
{
    public partial class Form1 : Form
    {
        
        ConcreteMediator mediator = new ConcreteMediator();
       
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            mediator.AddUsers(user1);
            mediator.AddUsers(user2);
            mediator.AddUsers(user3);
            mediator.AddUsers(user4);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            //ignore
        }
    }
}
