using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegate
{
    class Cat
    {
        public CatMiaoHandle CatMiaoHandlerMethod;
        public event CatMiaoHandle CatMiaoHandlerMethodEvent;
        public void Miao()
        {
            
            Console.WriteLine("猫叫了一声。。。");
            Console.WriteLine("*********委托*********");
            if (CatMiaoHandlerMethod != null)
                CatMiaoHandlerMethod();
            Console.WriteLine("*********事件*********");
            if (CatMiaoHandlerMethod != null)
                CatMiaoHandlerMethod();
        }

        public delegate void CatMiaoHandle();
       
    }
}
