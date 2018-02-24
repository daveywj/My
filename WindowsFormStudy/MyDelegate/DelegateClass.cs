using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegate
{
    public delegate void OutNoReturnNoPara();//委托可以处于class外面
    public delegate void OutNoReturnwithPara();

    public class DelegateClass
    {
        public delegate void NoReturnNoPara(); //声明一个委托

        public delegate void NoReturnwithPara(int x, int y);
        public delegate string NoPara();
        public delegate DateTime withPara(string name, int size);

        public static void Show()
        {
            Student student = new Student();
            student.Id = 11;
            student.Name = "Eleven";
            student.Study();

            NoReturnwithPara method = new NoReturnwithPara(plus);
            // NoReturnwithPara method1 = plus;
            method.Invoke(1, 2);//调用
            method(2, 3);

            method.BeginInvoke(3, 4, null, null);

            method += plus;
            method += plus;
            method += plus;
            method += plus;
            method -= plus;//多播委托

            // method.GetInvocationList();//找出委托里所有的方法

            method.Invoke(11, 21);

         

        }

        public static void plus(int x, int y) {
            Console.WriteLine("这里是Plus x={0} y={1}", x, y);
        }
        public static void No(int x, string y)
        {
            Console.WriteLine("这里是Plus x={0} y={1}", x, y);
        }
    }
}
