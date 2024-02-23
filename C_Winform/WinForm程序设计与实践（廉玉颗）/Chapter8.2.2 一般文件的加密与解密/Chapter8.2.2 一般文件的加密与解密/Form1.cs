using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace Chapter8._2._2_一般文件的加密与解密
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 使用DES加密算法对用户输入的文件进行加密。
        /// 其中，通过DESptoServiceProvider对象的CreateEncryptor()方法创建对称加密对象，
        /// 参数myIV是对称算法的初始化向量；参数myKey是对称算法的密钥。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            //获取源文件路径
            string strFile = txtFile.Text;
            // 获取加密密钥
            string strKey = txtKey.Text;
            // 获取加密后的文件路径
            string strEnFile = txtEncryptFile.Text;
            //设置向量
            byte[] myIV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
            // 设置密钥
            byte[] myKey = System.Text.Encoding.UTF8.GetBytes(strKey);
            // 源文件的文件流
            FileStream myInStream = new FileStream(strFile, FileMode.Open, FileAccess.Read);
            // 加密后的文件流
            FileStream myOutStream = new FileStream(strEnFile, FileMode.OpenOrCreate, FileAccess.Write);
            //初始文件流的长度
            myOutStream.SetLength(0);
            //定义缓冲区
            byte[] myBytes = new byte[100];
            // 定义不断变化的流的长度
            long myInLength = 0;
            // 获取源文件的文件流的长度
            long myLength = myInStream.Length;
            //定义标准的加密算法对象
            DES myProvider = new DESCryptoServiceProvider();
            // 实现将数据流链接到加密转换的流
            CryptoStream myCryptoStream = new CryptoStream(myOutStream, myProvider.CreateEncryptor(myKey, myIV), CryptoStreamMode.Write);
            //从源文件流中每次读取100个字节，然后
            while (myInLength < myLength)
            {
                //读取源文件流
                int mylen = myInStream.Read(myBytes, 0, 100);
                // 写入加密转换的流
                myCryptoStream.Write(myBytes, 0, mylen);
                //计算写入的流长度
                myInLength += mylen;
            }
            // 关闭资源
            myCryptoStream.Close();
            myInStream.Close();
            myOutStream.Close();
            MessageBox.Show("文件加密成功！");
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            //获取源文件路径
            string strFile = txtFile.Text;
            // 获取解密密钥
            string strKey = txtKey.Text;
            // 获取解密后的文件路径
            string strEnFile = txtEncryptFile.Text;
            // 设置向量
            byte[] myIV = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };
            // 设置密钥
            byte[] myKey = System.Text.Encoding.UTF8.GetBytes(strKey);
            // 源文件的文件流
            FileStream myInStream = new FileStream(strFile, FileMode.Open, FileAccess.Read);
            // 加密后的文件流
            FileStream myOutStream = new FileStream(strEnFile, FileMode.OpenOrCreate, FileAccess.Write);
            //初始文件流的长度
            myOutStream.SetLength(0);
            //定义缓冲区
            byte[] myBytes = new byte[100];
            // 定义不断变化的流的长度
            long myInLength = 0;
            // 获取源文件的文件流的长度
            long myLength = myInStream.Length;
            //定义标准的加密算法对象
            DES myProvider = new DESCryptoServiceProvider();
            // 实现将数据流链接到解密转换的流
            CryptoStream myDetoStream = new CryptoStream(myOutStream, myProvider.CreateDecryptor(myKey, myIV), CryptoStreamMode.Write);
            // 从源文件流中每次读取100字节，然后写入解密转换的流
            while (myInLength < myLength)
            {
                // 读取源文件流
                int mylen = myInStream.Read(myBytes, 0, 100);
                // 写入解密转换的流
                myDetoStream.Write(myBytes, 0, mylen);
                // 计算写入的流长度
                myInLength += mylen;
            }
            // 关闭资源
            myDetoStream.Close();
            myInStream.Close();
            myOutStream.Close();
            MessageBox.Show("文件解密成功！");

        }
    }
}
