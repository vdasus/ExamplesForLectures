using System;
using IoCtester.Domain;

namespace IoCtester
{
    class Program
    {
        static void Main(string[] args)
        {
            //Direct access
            var ds = CompositionRoot.GetDataService("prefix", "postfix");
            ds.Test("ds");

            Console.WriteLine("-----");

            //Forwarded by constructor
            var tmp = new Test(ds);
            tmp.Do("do");

            Console.WriteLine("-----");

            //Default values
            var des = CompositionRoot.GetDataServiceЦWithDefaults();
            des.Test("des");

            Console.WriteLine("-----");

            //Factory
            var fac = new TestWithFactory("tfprefix", "tfpostfix");
            fac.Do("dofac");

            Console.ReadKey();
        }
    }
}
