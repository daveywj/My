using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyGenerice
{
    class Generic
    {
        
        public static T get<T>(T t) where T:class,new () //约束一个引用类型
        {
            Console.WriteLine();
            People people = new People();
           // T ttt = new T();
            return t;
        }

        public static T query<T>(T t) where T:struct //约束一个值类型
        {
            return t;
        }

        public static T sayHi<T>(T t) where T : People
        {
            Console.WriteLine(t.Name);
            return t;
        }
    }
    class GenericClass<T, S, W> {  //泛型类

    }
}
