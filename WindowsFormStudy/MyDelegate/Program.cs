using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("我的第一个委托测试项目！");
            DelegateClass.Show();

            Console.WriteLine("**********Delegate************");
            GreetingHandler handlerChinese = new GreetingHandler(GreetingClass.GreetingChinese);
            GreetingClass.Greeting("Mike", handlerChinese);



            Console.WriteLine("**********事件测试开始*********");
            Cat cat = new Cat();
            //cat.Miao();


            cat.CatMiaoHandlerMethod = new Cat.CatMiaoHandle(Dog.wang);
            cat.CatMiaoHandlerMethod += Mouse.run;
            cat.CatMiaoHandlerMethod += People.Awake;
            cat.CatMiaoHandlerMethod += Stealer.Hide;
           // cat.CatMiaoHandlerMethod();

            //cat.CatMiaoHandlerMethodEvent = new Cat.CatMiaoHandle(Dog.wang); // 事件不能外面在类外面初始化。
            cat.CatMiaoHandlerMethodEvent += Dog.wang;
            cat.CatMiaoHandlerMethodEvent += Mouse.run;
            cat.CatMiaoHandlerMethodEvent += People.Awake;
            cat.CatMiaoHandlerMethodEvent += Stealer.Hide;
            //cat.CatMiaoHandlerMethodEvent(); //事件不能在类外面启用

            cat.Miao();


            Console.Read();
        }
    }
}
