using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    #region 最简单的单例模式
    public sealed class Singleton
    {
        // 定义一个静态的私有变量来保存类的实例
        // 静态的原因是保证在多线程环境下只有一个实例
        private static Singleton uniqueInstance;
        private Singleton()
        {

        }
        public static Singleton GetInstance()
        {
            if (uniqueInstance == null)
            {
                uniqueInstance = new Singleton();
            }
            return uniqueInstance;
        }
        //public static  Singleton Instance
        //{
        //    get
        //    {
        //        if (uniqueInstance==null)
        //        {
        //            uniqueInstance = new Singleton();
        //        }
        //        return uniqueInstance;
        //    }
        //}
    }
    #endregion

    public sealed class SingletonWithLock
    {
        private static SingletonWithLock uniqueInstance;
        private static readonly object locker = new object();

        private SingletonWithLock()
        { }

        public static SingletonWithLock GetInstance()
        {
            lock (locker)
            {
                if (uniqueInstance == null)
                {
                    uniqueInstance = new SingletonWithLock();
                }
            }
            return uniqueInstance;
        }

    }


    public sealed class SingletonWithDoubleCheck
    {
        private static SingletonWithDoubleCheck uniqueInstance;
        private static readonly object locker = new object();
        private SingletonWithDoubleCheck()
        { }

        public static SingletonWithDoubleCheck GetInstance()
        {
            if (uniqueInstance == null)
            {
                lock (locker)
                {
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new SingletonWithDoubleCheck();
                    }
                }
            }
            return uniqueInstance;
        }
    }

    public sealed class SingletonStaticLoad
    {
        private static readonly SingletonStaticLoad instance = new SingletonStaticLoad();

        static SingletonStaticLoad()
        { }
        private SingletonStaticLoad()
        { }
        public static SingletonStaticLoad Instance
        {
            get
            {
                return instance;
            }
        }
    }

    public sealed class SingletonLazyLoad
    {
        private SingletonLazyLoad()
        { }
        public static SingletonLazyLoad Instance
        {
            get
            {
                return Nested.instance;
            }
        }
        private class Nested
        {
            static Nested()
            { }
            internal static readonly SingletonLazyLoad instance = new SingletonLazyLoad();
        }
    }

    public sealed class SingeltonNet4
    {
        private static readonly Lazy<SingeltonNet4> lazy = new Lazy<SingeltonNet4>(() => new SingeltonNet4());
        private static SingeltonNet4 Instance
        {
            get
            {
                return lazy.Value;
            }

        }

        private SingeltonNet4() { }
    }

}
