using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.OOP.Inheritance
{
    public class A
    {
        public virtual void Send()
        {
            Console.WriteLine("Message Sent from base");
        }
    }

    public class B : A
    {
        public override void Send()
        {
            Console.WriteLine("Message Sent from Derived Class");
            base.Send();
        }
    }
}
