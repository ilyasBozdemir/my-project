
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace RSATest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter text that needs to be encrypted..");
            //string data = Console.ReadLine();
            //EncryptAesManaged(data);
            
            string encryptedData = "?¶?y]⌂Q?0∟?5)↑L";
            string decryptedData = "ilyas70";
            SifreyiBulTest(encryptedData, decryptedData);

            Console.Read();
        }
        private static void SifreyiBulTest(string encryptedData, string decryptedData)
        {
            byte[] Key = {
                31, 224, 184,  81, 139, 137, 162, 95, 214,176, 131, 178, 232, 243, 142, 216,
                114, 139,  146, 61, 78, 56, 253, 138,193, 4, 154,101, 175, 8, 158, 176
            };
            byte[] IV = { 170, 235, 237, 129, 236, 88, 47, 11, 117, 44, 133, 30, 146, 50, 2, 110 };

           

        }

        static void EncryptAesManaged(string raw)
        {
            try
            {
                // Create Aes that generates a new key and initialization vector (IV).    
                // Same key must be used in encryption and decryption    
                using (AesManaged aes = new AesManaged())
                {
                    // Encrypt string    
                    byte[] encrypted = Encrypt(raw, aes.Key, aes.IV);
                    Console.WriteLine($"Encrypted data: {System.Text.Encoding.UTF8.GetString(encrypted)}");
                    string decrypted = Decrypt(encrypted, aes.Key, aes.IV);    
                    Console.WriteLine($"Decrypted data: {decrypted}");
                  
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
            Console.ReadKey();
        }

        static string Decrypt(byte[] cipherText, byte[] Key, byte[] IV)
        {
            string plaintext = null; 
            using (AesManaged aes = new AesManaged())
            {
                ICryptoTransform decryptor = aes.CreateDecryptor(Key, IV);
                using (MemoryStream ms = new MemoryStream(cipherText))
                {    
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {   
                        using (StreamReader reader = new StreamReader(cs))
                            plaintext = reader.ReadToEnd();
                    }
                }
            }
            return plaintext;
        }

        static byte[] Encrypt(string plainText, byte[] Key, byte[] IV)
        {
            byte[] encrypted;  
            using (AesManaged aes = new AesManaged())
            { 
                ICryptoTransform encryptor = aes.CreateEncryptor(Key, IV);
                using (MemoryStream ms = new MemoryStream())
                {   
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {   
                        using (StreamWriter sw = new StreamWriter(cs))
                            sw.Write(plainText);
                        encrypted = ms.ToArray();
                    }
                }
            }
            return encrypted;
        }
    }
}