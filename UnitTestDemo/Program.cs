using System;
using Microsoft.Practices.Unity;
using UnitTestAndIoCDemo.Ioc;

namespace UnitTestAndIoCDemo
{
    internal class Program
    {
        private static void Main()
        {
            var unityRegistrar = new UnityRegistrar();
            unityRegistrar.RegisterAll();
            RunAll(unityRegistrar);
        }

        private static void RunAll(UnityRegistrar unityRegistrar)
        {
            var a = unityRegistrar.Container.Resolve<A>();
            var b = unityRegistrar.Container.Resolve<B>();

            a.SayIt();
            b.SayIt();

            Console.ReadLine();
        }
    }
}
