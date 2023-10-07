using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

//引入命名空间
using System.IO;

namespace TextFile
{
    public partial class FrmFile : Form
    {
        public FrmFile()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //封装对象信息
            Student objStu = new Student()
            {
                Name = this.txtName.Text.Trim(),
                Age = Convert.ToInt16(this.txtAge.Text.Trim()),
                Gender = this.txtGender.Text.Trim(),
                Birthday = Convert.ToDateTime(this.txtBirthday.Text.Trim())
            };
            //保存到文本文件
            FileStream fs = new FileStream("C:\\objStu.obj", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            //一行一行写入文本
            sw.WriteLine(objStu.Name);
            sw.WriteLine(objStu.Age);
            sw.WriteLine(objStu.Gender);
            sw.WriteLine(objStu.Birthday.ToShortDateString());
            //关闭文件流和写入器
            sw.Close();
            fs.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("C:\\objStu.obj", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            //一行一行读取
            Student objStu = new Student()
            {
                Name = sr.ReadLine(),
                Age = Convert.ToInt16(sr.ReadLine()),
                Gender = sr.ReadLine(),
                Birthday = Convert.ToDateTime(sr.ReadLine())
            };
            sr.Close();
            fs.Close();
            this.txtName.Text = objStu.Name;
            this.txtAge.Text = objStu.Age.ToString();
            this.txtGender.Text = objStu.Gender;
            this.txtBirthday.Text = objStu.Birthday.ToShortDateString();
        }
    }
}
