using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
   public class President:Approver
    {
       public President(string name):base(name)
       {

       }
       public override void ProcessRequest(LeaveAskRequest request)
       {
           if (request.Days<10)
           {
               Console.WriteLine("{0}审批了你的假单", this.Name);
           }
           else
           {
               Console.WriteLine("不能超过10天的假期");
           }
       }
    }
}
