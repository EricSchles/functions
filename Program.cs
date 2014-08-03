using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions
{
    class Program
    {

        static void DoStuff()
        {
            Console.WriteLine("I'm doing stuff");
        }

        static int AddNumbers(int number1, int number2)
        {
            return number1 + number2;
        }

        static void AddFive(ref int num){
            num += 5;
        }
        static int GreetPersons(ArrayList ordering, params string[] names)
        {
            foreach (string name in names)
            {
                Console.WriteLine("Hello " + name);
            }
            int summation = 0;
            foreach (int num in ordering)
            {
                summation += num;
            }
            return summation;
        }

        static void Main(string[] args)
        {
            DoStuff();
            ArrayList thing = new ArrayList();
            thing.Add(1);
            thing.Add(2);
            thing.Add(3);
            thing.Add(4);
            thing.Add(5);
            thing.Add(6);
            thing.Add(7);

            Console.WriteLine("5 + 7 is " + AddNumbers(5, 7));
            Console.WriteLine("The sum is " + GreetPersons(thing, "Eric", "Mark", "Noam", "Phil"));
            int num = 4;
            int original_num = num;
            AddFive(ref num);
            Console.WriteLine(original_num + " + 5 is " + num);
            Console.ReadKey();
            
            

        }
    }
}
