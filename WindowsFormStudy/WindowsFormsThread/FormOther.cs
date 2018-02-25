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
    public partial class FormOther : Form
    {
        public FormOther()
        {
            InitializeComponent();
            this.ControlBox = false;
        }
        public delegate void Fun();
        public void close()
        {
            try
            {
                FormMain.formOther.Invoke(new Fun(FormMain.formOther.Dispose));
            }
            catch (Exception) { }
        }
        private void btnExecute1_Click(object sender, EventArgs e)
            {
                int a = 0;
            string str = "";
                Thread objThread1 = new Thread(() => {
                    for (int i = 0; i < 10; i++)
                    {
                        a += 1;
                        if (this.lblResult1.InvokeRequired)
                        {
                            str = a.ToString() + "  ThreadID:" + Thread.CurrentThread.ManagedThreadId.ToString();
                            this.lblResult1.Invoke(new Action<string>(s=> { this.lblResult1.Text = s; }),str);
                        }
                       // this.lblResult1.Text = a.ToString();
                        Thread.Sleep(200);
           
                    }
                

                });
                objThread1.IsBackground = true;
                objThread1.Start();


            }

        
        private void btnExecute2_Click(object sender, EventArgs e)
        {
            int a = 0;
            string str = "";
            Thread objThread2 = new Thread(() => {
                for (int i = 0; i < 100; i++)
                {
                    try
                    {
                        a += 1;
                        if (this.lblResult2.InvokeRequired)
                        {
                            str ="计数:"+ a.ToString() + "  ThreadID:" + Thread.CurrentThread.ManagedThreadId.ToString();
                            this.lblResult2.Invoke(new Action<string>(s => { this.lblResult2.Text = s; Console.WriteLine(s); }), str);
                        }
                        // this.lblResult2.Text = a.ToString();
                        Thread.Sleep(200);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());

                    }
                }


            });
            objThread2.IsBackground = true;
            objThread2.Start();

            
        }

        private void FormOther_Load(object sender, EventArgs e)
        {

        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            lblRemark.Text = i.ToString();
        }
    }
}
