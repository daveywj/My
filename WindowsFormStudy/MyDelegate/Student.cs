using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegate
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Study() {
            Console.WriteLine("我爱学习");
        }
    }
}
