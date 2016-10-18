using System;

namespace UnitTestAndIoCDemo.Ioc
{
    public class A
    {
        private readonly ITalkingThing _talkingThing;

        public A(ITalkingThing talkingThing)
        {
            _talkingThing = talkingThing;
        }

        public string SayIt()
        {
            Console.WriteLine(GetType().Name + " says: " + _talkingThing.Says());
            return _talkingThing.Says();
        }
    }
}
