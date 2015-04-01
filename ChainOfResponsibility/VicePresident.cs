using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
   public class VicePresident:Approver
    {
       public VicePresident(string name):base(name)
       {

       }
       public override void ProcessRequest(LeaveAskRequest request)
       {
           if (request.Days<7)
           {
               Console.WriteLine("{0}审批了你的假单", Name);
           }
           else if (NextApprover!=null)
           {
               NextApprover.ProcessRequest(request);
           }
       }
    }
}
