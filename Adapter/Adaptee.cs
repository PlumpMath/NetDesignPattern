using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// 需要被适配的类
    /// </summary>
    public class Adaptee
    {
        public void DoSomeThingOld()
        {
            Console.WriteLine("我是需要适配的类");
        }
    }
}
