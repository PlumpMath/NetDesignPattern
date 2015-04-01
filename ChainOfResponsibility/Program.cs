using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            LeaveAskRequest ask = new LeaveAskRequest("Test",4);
            Approver manager = new Manager("经理");
            Approver vicePresident = new VicePresident("副总");
            Approver president = new President("总经理");


            manager.NextApprover = vicePresident;
            vicePresident.NextApprover = president;

            manager.ProcessRequest(ask);
            Console.ReadLine();
        }
    }
}
