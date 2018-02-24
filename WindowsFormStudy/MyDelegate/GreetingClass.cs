using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegate
{
    class GreetingClass
    {
        public static void Greeting(string name)
        {
            Console.WriteLine("{0},早上好",name);
        }

        public static void GreetingChinese(string name)
        {
            Console.WriteLine("{0},中国人,早上好", name);
        }
        public static void Greeting(string name, GreetingHandler handler)
        {
            handler.Invoke(name);
        }



    }

    public delegate void GreetingHandler(string name);
    public enum PeopleType
    {
        Chinese,
        English
    }
}
