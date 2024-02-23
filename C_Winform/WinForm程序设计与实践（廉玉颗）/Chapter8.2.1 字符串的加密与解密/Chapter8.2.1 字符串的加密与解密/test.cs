// c# 字符串加密解密算法，到处密钥到文件
using System;
using System.Security.Cryptography;
using System.Text;

namespace RSA_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string plainText = "Hello, World!";
            string keyFilePath = "privatekey.rsa";

            // 生成RSA密钥对
            RSAKeyValuePair keyPair = new RSAKeyValuePair(2048);
            // 将公钥和私钥保存到文件
            keyPair.SaveKeyPair(keyFilePath);

            // 使用公钥加密明文
            string encryptedText = Encrypt(plainText, keyFilePath);
            Console.WriteLine("Encrypted text: " + encryptedText);

            // 使用私钥解密密文
            string decryptedText = Decrypt(encryptedText, keyFilePath);
            Console.WriteLine("Decrypted text: " + decryptedText);
        }

        static string Encrypt(string plainText, string keyFilePath)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            RSAKeyValuePair keyPair = RSAKeyValuePair.LoadKeyPair(keyFilePath);
            byte[] encryptedBytes = keyPair.Encrypt(plainBytes);
            return Convert.ToBase64String(encryptedBytes);
        }

        static string Decrypt(string encryptedText, string keyFilePath)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
            RSAKeyValuePair keyPair = RSAKeyValuePair.LoadKeyPair(keyFilePath);
            byte[] decryptedBytes = keyPair.Decrypt(encryptedBytes);
            return Encoding.UTF8.GetString(decryptedBytes);
        }
    }

    public class RSAKeyValuePair
    {
        public readonly byte[] PrivateKey;
        public readonly byte[] PublicKey;

        public RSAKeyValuePair(int keySize)
        {
            var rsa = new RSACryptoServiceProvider(keySize);
            rsa.KeyGenerationAlgorithm = RSACryptoAlgorithm.RSAES_PKCS1_V1_5;
            PrivateKey = rsa.Key.ExportKey(KeyType.Private);
            PublicKey = rsa.Key.ExportKey(KeyType.Public);
        }

        public void SaveKeyPair(string filePath)
        {
            using (var fs = File.Create(filePath))
            {
                fs.Write(PrivateKey);
                fs.Write(PublicKey);
            }
        }

        public static RSAKeyValuePair LoadKeyPair(string filePath)
        {
            var privateKey = File.ReadAllBytes(filePath);
            var publicKey = File.ReadAllBytes(filePath + ".pub");
            return new RSAKeyValuePair(privateKey, publicKey);
        }

        public byte[] Encrypt(byte[] plainBytes)
        {
            var rsa = new RSACryptoServiceProvider();
            rsa.FromXmlPrivateKey(Encoding.UTF8.GetString(PrivateKey));
            return rsa.Encrypt(plainBytes, RSACryptoAlgorithm.RSAES_PKCS1_V1_5);
        }

        public byte[] Decrypt(byte[] encryptedBytes)
        {
            var rsa = new RSACryptoServiceProvider();
            rsa.FromXmlPrivateKey(Encoding.UTF8.GetString(PrivateKey));
            return rsa.Decrypt(encryptedBytes, RSACryptoAlgorithm.RSAES_PKCS1_V1_5);
        }
    }
}
