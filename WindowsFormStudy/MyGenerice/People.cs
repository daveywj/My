using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGenerice
{
    public class People
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void show() {
            Console.WriteLine("姓名：{0}", Name);
        }
    }

    public class Chinese : People {
        public string national { get; set; }

        public void showNational() {
            Console.WriteLine("首都：{0}", national);
        }
        
    }

}
