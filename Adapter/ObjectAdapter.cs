using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ObjectAdapter:ITarget
    {
        Adaptee adaptee = new Adaptee();
        public void DoSomeThingNew()
        {
            adaptee.DoSomeThingOld();
        }
    }
}
