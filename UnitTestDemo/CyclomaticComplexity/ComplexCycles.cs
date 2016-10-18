using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestAndIoCDemo.CyclomaticComplexity
{
    public class ComplexCycles
    {
        public void Simple(int count)
        {
            if (count > 5)
            {
                Console.WriteLine("count > 5");
            }
            else
            {
                Console.WriteLine("count >= 5");
            }
        }

        public void Complex(int count)
        {
            if (count%2 == 0)
            {
                if (count > 1)
                {
                    if (count == 22)
                    {
                        Console.WriteLine("3 levels deep");
                    }
                    else
                    {
                        Console.WriteLine("Something");
                    }
                }
                else
                {
                    Console.WriteLine("Whatever");
                }
            }
            else
            {
                Console.WriteLine("So Many levels.");
            }
        }
    }
}
