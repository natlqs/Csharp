using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xiketang.com.LotteryPro
{
    /// <summary>
    /// 选号器类
    /// </summary>
    public class Selector
    {
        //红色球池
        public List<string> RedNumberList { get; set; }

        //蓝色球池
        public List<string> BlueNumberList { get; set; }

        //存储选择的号码
        public List<DoubleChromosphere> SelectedNums { get; set; } = new List<DoubleChromosphere>();

        private Random random = new Random();//随机数生成器（只在本类内部使用）

        /// <summary>
        /// 构造方法：初始化球池的数字
        /// </summary>
        public Selector()
        {
            RedNumberList = new List<string>
            {
                "01","02","03","04","05","06","07","08","09","10",
                "11","12","13","14","15","16","17","18","19","20",
                "21","22","23","24","25","26","27","28","29","30",
                "31","32","33"
            };
            BlueNumberList = new List<string>
            {
                "01","02","03","04","05","06","07","08","09","10",
                "11","12","13","14","15","16"
            };
        }
        /// <summary>
        /// 生成7个随机不同的号码
        /// </summary>
        /// <returns></returns>
        public List<string> CreateRandomNum()
        {
            List<string> numList = new List<string>();
            //生成6个红色球
            while (true)
            {
                if (numList.Count == 6) break;//如果随机选取了6个数字了，则退出循环
                string num = RedNumberList[random.Next(33)];
                if (numList.Contains(num)) continue;//如果是重复的数字，则重新随机抽取
                else
                {
                    numList.Add(num);
                }                  
            }
            //生成一个蓝色球
            numList.Add(BlueNumberList[random.Next(16)]);
            return numList;
        }

        //打印、远程保存等（我们在深入的VIP系统学习中再讲解...)
        //这些方法，都会用到我们所保存的《已选择号码》
    }
}
