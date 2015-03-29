using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new ClassAdapter();
            target.DoSomeThingNew();
            ObjectAdapter adapter = new ObjectAdapter();
            adapter.DoSomeThingNew();
            Console.ReadLine();

        }
    }
}
