using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Chapter8._2._1_字符串的加密与解密
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 封装定义密钥容器和RSA加密对象：.NET Framework提供的实现加密算法的类位于 System.Security.Cryptography命名空间中，
        /// 其中CspParameters类的KeyContainerName属性用于设置或获取密钥容器的名称。密钥容器用于保存密钥，确保密钥存储的安全性。
        /// 为了区分不同的密钥容器，需要给每个密钥容器定义一个名称。
        /// </summary>
        /// <param name = "containerName" ></ param >
        /// < returns ></ returns >
        private static RSACryptoServiceProvider GetRSAProviderFromContainer(string containerName)
        {
            //自定义密钥容器
            CspParameters cp = new CspParameters();
            //指定密钥容器名称
            cp.KeyContainerName = containerName;
            //定义RSA加密对象
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(cp);
            return rsa;
        }

        /// <summary>
        /// 封装使用RSA算法进行加密的方法：首先调用GetRSACryptoServiceProvider()方法提取密钥提供器，然后将明文字符串转换为字符数组，
        /// 并调用RSA加密对象的Encrypt()方法进行加密，最后将密文数组转换为字符串并返回。
        /// </summary>
        /// <param name = "plaintext" ></ param >
        /// < returns ></ returns >
        private string RSAEncrypt(string plaintext)
        {
            //从密钥容器中取出密钥提供器
            RSACryptoServiceProvider rsa = GetRSAProviderFromContainer("rsaKey");
            //将要进行加密的字符串转换成字符数组
            byte[] bytes = Encoding.Unicode.GetBytes(plaintext);
            //将数据进行加密
            byte[] ciphertextBytes = rsa.Encrypt(bytes, true);
            //将加密后的字符数组转换成字符串
            string ciphertext = Convert.ToBase64String(ciphertextBytes);
            return ciphertext;
        }


        /// <summary>
        ///  封装使用RSA算法进行解密的方法：首先调用GetRSACryptoServiceProvider()方法提取密钥提供器，然后将密文字符串转换为字符数组，
        /// 并调用RSA解密对象的Decrypt()方法进行解密，最后将明文数组转换为字符串并返回。
        /// </summary>
        /// <param name="plaintext"></param>
        /// <returns></returns>
        private string RSADecrypt(string ciphertext)
        {
            // 从密钥容器中取出密钥提供器
            RSACryptoServiceProvider rsa = GetRSAProviderFromContainer("rsaKey");
            // 将要解密的字符串转换成字符数组
            byte[] bytes = Convert.FromBase64String(ciphertext);
            // 将加密数据进行解密并将结果保存到plaintextBytes中
            byte[] plaintextBytes = rsa.Decrypt(bytes, true);
            // 将解密后的字符数组转换成字符串
            string plaintext = Encoding.Unicode.GetString(plaintextBytes);
            return plaintext;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txtCiphertext.Text = RSAEncrypt(txtPlaintext.Text);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            txtDecryptedText.Text = RSADecrypt(txtCiphertext.Text);
        }
    }
}
