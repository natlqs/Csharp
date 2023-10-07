using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformBasic
{
    internal class Selector
    {
        // Normal Numbers
        public List<string> NormalNumberList { get; set; }
        // Special Numbers
        public List<string> SpecialNumberList { get; set; }
        // Store Selected Numbers
        public List<LuckyNumbers> luckyNumbers { get; set; } = new List<LuckyNumbers>();
        public Random random = new Random();    // 随机数生成器，只在本类中使用

        /// <summary>
        /// 构造方法：Initialize the numbers of the lucky number pool
        /// </summary>
        public Selector()
        {
            NormalNumberList = new List<string>
            {
                "00","01","02","03","04","05","06","07","08","09",
                "10","11","12","13","14","15","16","17","18","19",
                "20","21","22","23","24","25","26","27","28","29",
                "30","31","32","33","34","35","36","37","38","39",
                "40","41","42","43","44","45","46","47","48","49",
                "50","51","52","53","54","55","56","57","58","59",
                "60","61","62","63","64","65","66","67","68","69",
                "70","71","72","73","74","75","76","77","78","79",
                "80","81","82","83","84","85","86","87","88","89",
                "90","91","92","93","94","95","96","97","98","99",
            };
            SpecialNumberList = new List<string>
            {
                "00","01","02","03","04","05","06","07","08","09",
                "10","11","12","13","14","15","16","17","18","19",
                "20","21","22","23","24","25","26","27","28","29",
                "30","31","32","33","34","35","36","37","38","39",
                "40","41","42","43","44","45","46","47","48","49",
                "50","51","52","53","54","55","56","57","58","59",
                "60","61","62","63","64","65","66","67","68","69",
                "70","71","72","73","74","75","76","77","78","79",
                "80","81","82","83","84","85","86","87","88","89",
                "90","91","92","93","94","95","96","97","98","99",

            };
        }


        /// <summary>
        /// Generate 14 random different number
        /// </summary>
        /// <returns></returns>
        public List<string> CreateRandomNum()
        {
            List<string> numlist = new List<string>();
            while (true)
            {
                if (numlist.Count == 14) break;     // 如果随机选取了14个数字了，则推出循环
                string num = NormalNumberList[random.Next(100)];
                if (numlist.Contains(num)) continue;    // 如果是重复数字，则重新随机选取
                else
                {
                    numlist.Add(num);
                }
            }
            while (true)
            {
                if (numlist.Count == 16) break;     // 如果随机选取了14个数字了，则推出循环
                string num = SpecialNumberList[random.Next(100)];
                if (numlist.Contains(num)) continue;    // 如果是重复数字，则重新随机选取
                else
                {
                    numlist.Add(num);
                }
            }
            //generate a special number
            return numlist;
            }
        }
}
