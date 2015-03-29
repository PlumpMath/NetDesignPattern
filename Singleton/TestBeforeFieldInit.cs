using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //precise方式和beforefieldinit
    class TestBeforeFieldInit
    {
        public static string staticStr = GetString("Initialize the static field");
        // 如果有static则precise方式执行，否则beforefieldinit，beforefieldinit比precise高效
        //static TestBeforeFieldInit()
        //{ }
        public static string GetString(string p)
        {
            Console.WriteLine(p);
            return p;
        }
    }

    sealed class TestPrecise
    {
        private static readonly TestPrecise instance = new TestPrecise();
        public static string staticStr = GetString(string.Format("The Instance Is NOt NUll? {0}", instance==null));
        static TestPrecise()
        { }
        private TestPrecise()
        { }
        public static TestPrecise Instance
        {
            get
            {
                Console.WriteLine("get Instance");
                return instance;
            }
        }
        public static string GetString(string p)
        {
            Console.WriteLine(p);
            return p;
        }
    }


}
