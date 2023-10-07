using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xiketang.com.WinformBase
{
    public partial class FrmEventApp : Form
    {
        //用来封装课程对象的容器
        private List<Course> courseList = new List<Course>();

        public FrmEventApp()
        {
            InitializeComponent();

            //多个按钮响应同一个事件，在此做事件关联
            //this.btn01.Click += new System.EventHandler(this.btn_Click);
            //this.btn02.Click += new System.EventHandler(this.btn_Click);
            //this.btn03.Click += new System.EventHandler(this.btn_Click);
            //this.btn04.Click += new System.EventHandler(this.btn_Click);
            //this.btn05.Click += new System.EventHandler(this.btn_Click);
            //this.btn06.Click += new System.EventHandler(this.btn_Click);
            //this.btn07.Click += new System.EventHandler(this.btn_Click);
            //this.btn08.Click += new System.EventHandler(this.btn_Click);
            //this.btn09.Click += new System.EventHandler(this.btn_Click);
            //this.btn10.Click += new System.EventHandler(this.btn_Click);
            //this.btn11.Click += new System.EventHandler(this.btn_Click);
            //this.btn12.Click += new System.EventHandler(this.btn_Click);
            //以上方法，如果你这么写程序，会被别人认为你什么都不懂！

            foreach (Control item in this.Controls)
            {
                //if (item is Button)//通过控件类型过滤我们不需要的控件
                //{
                //    Button btn = item as Button;
                //    if (btn.Tag.ToString() != "Save")//过滤我们不需要的按钮，请大家特别注意Tag的使用
                //    {
                //        btn.Click += new System.EventHandler(this.btn_Click);
                //    }
                //}

                if (item is Button && item.Tag.ToString() != "Save")
                {
                    item.Click += new System.EventHandler(this.btn_Click);
                }
            }
        }

        //事件集中处理方法
        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            //将当前按钮Tag属性中封装的课程信息，通过字符串分割得到
            string[] info = btn.Tag.ToString().Split(',');
            //将当前课程信息封装到课程对象，并将课程对象封装到集合中
            this.courseList.Add(new Course
            {
                CourseName = btn.Text,
                CourseId = Convert.ToInt32(info[0]),
                ClassHour = Convert.ToInt32(info[1])
            });
            //改变当前按钮的背景色
            btn.BackColor = Color.Green;

            //请大家思考：如果避免用户多次添加同一个课程按钮，而导致多次添加的问题...
            
        }
        //保存所选课
        private void btnSave_Click(object sender, EventArgs e)
        {
            //实际开发中，保存可以到数据库、文件...

            //测试看看所选择的课程
            foreach (var item in this.courseList)
            {
                Console.WriteLine(item.CourseId+"\t"+item.ClassHour+"\t"+item.CourseName);
            }
        }
    }
}
