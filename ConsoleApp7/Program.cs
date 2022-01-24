using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ducks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck Mallard = new MallardDuck();
            RedheadDuck Redhead = new RedheadDuck();
            Duck[] duck = new Duck[] { new MallardDuck(), new RedheadDuck() };

            foreach (Duck kry in duck)
            {
                Console.WriteLine(kry.Quack());
                Console.WriteLine(kry.Swim());
                Console.WriteLine(kry.Display());
            }
            Console.ReadKey();
        }
    }
}
