using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// 适配器
    /// </summary>
    public class ClassAdapter : Adaptee,ITarget
    {

        public void DoSomeThingClientNeed()
        {
            this.DoSomeThingOld();
        }
    }
}
