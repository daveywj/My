using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGenerice
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People() {ID=1, Name="23" };
            People p= Generic.get<People>(people);
            
            Generic.sayHi<Chinese>(new Chinese() { ID = 1, Name = "23", national = "北京" });
            Console.WriteLine("完成！");
            Console.Read();
        }
    }
}
