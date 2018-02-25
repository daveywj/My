using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsThread
{
    public partial class FormMain : Form
    {
        public static FormOther formOther;
        public FormMain()
        {
            InitializeComponent();
            show();
        }

        private void BtnQuire_Click(object sender, EventArgs e)
        {
        }

        private void btn_Chancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static Thread objThread1 = null;
        private void show() {
            int a = 0;
            string str = "";
            objThread1 = new Thread(() => {
                for (int i = 0; i < 10; i++)
                {
                    a += 1;
                    if (this.lblResult1.InvokeRequired)
                    {
                        str = a.ToString() + "  ThreadID:" + Thread.CurrentThread.ManagedThreadId.ToString();
                        this.lblResult1.BeginInvoke(new Action<string>(s => { this.lblResult1.Text = s; }), str);
                    }
                    Thread.Sleep(100);
                }
                formOther.Invoke(new s(formOther.Dispose));
            });
            objThread1.IsBackground = true;
            objThread1.Start();
        }
        public delegate void s();
        
        private void FormMain_Load(object sender, EventArgs e)
        {
            formOther = new FormOther();
            formOther.ShowDialog();
        }

        private void btn_Task_Click(object sender, EventArgs e)
        {
            Console.WriteLine("_____________多线程开始！___________________！线程ID:{0}", Thread.CurrentThread.ManagedThreadId);
            List<Task> list = new List<Task>();
            TaskFactory taskFactory = new TaskFactory();
            Action action1=new Action(() => { coding("王健1", "windows1"); });
            Action action2 = new Action(() => { coding("王健2", "windows2"); });
            Action action3 = new Action(() => { coding("王健3", "windows3"); });
            Action action4=new Action(() => { coding("王健4", "windows4"); });
            Action action5=new Action(() => { coding("王健5", "windows5"); });
            Action action6=new Action(() => { coding("王健6", "windows6"); });
            list.Add(taskFactory.StartNew(action1));
            list.Add(taskFactory.StartNew(action2));
            list.Add(taskFactory.StartNew(action3));
            list.Add(taskFactory.StartNew(action4));


           
            Console.WriteLine("*******************！线程ID:{0}", Thread.CurrentThread.ManagedThreadId);
            Action<Task[]> action = new Action<Task[]>(t => Console.WriteLine("以上线程完成，可以进行后续操作了！线程ID:{0}",Thread.CurrentThread.ManagedThreadId));
            list.Add(taskFactory.ContinueWhenAll(list.ToArray(),action));
            Task.WaitAny(list.ToArray());

            list.Add(taskFactory.StartNew(action1));
            list.Add(taskFactory.StartNew(action2));
            list.Add(taskFactory.StartNew(action3));
            list.Add(taskFactory.StartNew(action4));
            list.Add(taskFactory.StartNew(action5));
            list.Add(taskFactory.StartNew(action6));
            Task.WaitAll(list.ToArray());
            Console.WriteLine("*******************！线程ID:{0}", Thread.CurrentThread.ManagedThreadId);

            Console.WriteLine("完成所有线程！线程ID:{0}", Thread.CurrentThread.ManagedThreadId);
            
        }

        void coding(string name, string ob)
        {
            DateTime startTime = DateTime.Now;
            Console.WriteLine(name + " 开始启动一个" + ob + "多线程,线程ID:" + Thread.CurrentThread.ManagedThreadId.ToString());
            int a = 0;
            for (int i = 0; i < 1000000; i++)
            {
                a = i + a;
            }
            DateTime endTime = DateTime.Now;
            Console.WriteLine("合计:{0} 开始时间:{1},结束时间:{2},用时:{3},当时线程ID:{4}",a.ToString(),startTime.ToShortTimeString(),endTime.ToShortTimeString(),(endTime-startTime).ToString(),Thread.CurrentThread.ManagedThreadId.ToString());
            Thread.Sleep(1000);
        }
    }
}
