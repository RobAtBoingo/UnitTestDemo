using Microsoft.Practices.Unity;
using UnitTestAndIoCDemo.Ioc;

namespace UnitTestAndIoCDemo
{
    public class UnityRegistrar
    {
        public UnityContainer Container { get; }

        public UnityRegistrar()
        {
            Container = new UnityContainer();
        }

        public void RegisterAll()
        {
            Container.RegisterInstance<ITalkingThing>("Y", new Y());
            Container.RegisterType<ITalkingThing, Z>("Z");

            Container.RegisterType<A>(
                new InjectionConstructor(
                    Container.Resolve<ITalkingThing>("Z")));

            Container.RegisterType<B>(
                new InjectionConstructor(
                    Container.Resolve<ITalkingThing>("Z")));
        }
    }
}
