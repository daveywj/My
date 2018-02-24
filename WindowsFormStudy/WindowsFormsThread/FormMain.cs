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
                for (int i = 0; i < 100; i++)
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
    }
}
