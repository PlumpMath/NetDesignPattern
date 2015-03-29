using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /// <summary>
    /// 客户端期望的接口
    /// </summary>
    public interface ITarget
    {
        void DoSomeThingClientNeed();
    }
}
