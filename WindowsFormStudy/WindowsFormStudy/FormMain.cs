using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;

namespace WindowsFormStudy
{
    public partial class FrmMain : Form
    {
        ArrayList arrayList;
        public FrmMain()
        {
            InitializeComponent();
            arrayList = new ArrayList();
            for (int i = 0; i < 4000; i++)
            {
                PTData ptData = new PTData();
                ptData.PTID = i + 1;
                ptData.PTName ="王健wezxcvbzxvczxcvzxcvasdfadsgadfgasdfgadfgadfgadfgadfgasdfgsdfgrwewdfsdfasdgrwerwe家sdfsfwrwerwerewerwer四口人" + Convert.ToString(i + 1);
                ptData.PT_Data = i + 1;
                arrayList.Add(ptData);
            }
        }

        private void buttonFileToDB_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["LocalMsSQl"];
            SqlConnection sqlConnection = new SqlConnection( settings.ConnectionString);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from RWTest", sqlConnection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            System.Data.DataSet dataSet = new DataSet("RWTest");
            sqlDataAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;//确定现有 DataSet 架构与传入数据不匹配时需要执行的操作。                                                             //定义一个流
            Stream stream = new MemoryStream();
            //定义一个格式化器
            BinaryFormatter bf = new BinaryFormatter();
            foreach (object obj in arrayList)
            {
                bf.Serialize(stream, obj);  //序列化

            }
            byte[] array = null;
            array = new byte[stream.Length];
            //将二进制流写入数组
            stream.Position = 0;
            stream.Read(array, 0, (int)stream.Length);
            //关闭流
            stream.Close();
            try
            {
                sqlDataAdapter.Fill(dataSet, "RWTest");
                //DataRow表示DataTable中的一行数据
                System.Data.DataRow dataRow1;
                dataRow1 = dataSet.Tables["RWTest"].NewRow();
                dataRow1["ID"] = 3;
                dataRow1["Description"] = "wangjian";
                dataRow1["Data"] = array;
                dataSet.Tables["RWTest"].Rows.Add(dataRow1);
                sqlDataAdapter.Update(dataSet, "RWTest");
                sqlConnection.Close();
                MessageBox.Show("写入数据库成功！", " 信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
                MessageBox.Show("写入数据库失败" + ex.Message, " 信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDBToFile_Click(object sender, EventArgs e)
        {
                ConnectionStringSettings settings;

                settings = ConfigurationManager.ConnectionStrings["LocalMsSQl"];
                SqlConnection sqlConnection = new SqlConnection(settings.ConnectionString);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from RWTest", sqlConnection);
                SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
                DataSet dataSet = new DataSet("RWTest");
                sqlDataAdapter.Fill(dataSet, "RWTest");
                DataRow myRow;
                myRow = dataSet.Tables["RWTest"].Rows[0];
                byte[] b = null;
                b = (byte[])myRow["Data"];
                //定义一个流
                MemoryStream stream = new MemoryStream(b);
                //定义一个格式化器
                BinaryFormatter bf = new BinaryFormatter();
                while (stream.Position != stream.Length)
                {
                    arrayList.Add(bf.Deserialize(stream));  //反序列化
                }
                stream.Close();
                for (int i = 0; i < 5; i++) //信息提示，是否正确从数据库中取出了ArrayList链表
                    MessageBox.Show(((PTData)arrayList[i]).PTName, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (sqlConnection.State == ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
                MessageBox.Show(" 从数据库读出数据成功！", " 信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
         }

    }
    
}
