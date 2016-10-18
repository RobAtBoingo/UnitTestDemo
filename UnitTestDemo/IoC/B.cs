using System;

namespace UnitTestAndIoCDemo.Ioc
{
    public class B
    {
        private readonly ITalkingThing _talkingThing;

        public B(ITalkingThing talkingThing)
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
