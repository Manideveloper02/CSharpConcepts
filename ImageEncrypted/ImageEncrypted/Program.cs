using System;
using System.IO;
using System.Security.Cryptography;

namespace ImageEncrypted
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encrypt or Decrypt");
            string action = Console.ReadLine();
            Console.WriteLine("Enter file path");
            string inputFilePath = Console.ReadLine();
            string fileName = Path.GetFileNameWithoutExtension(inputFilePath);
            string fileExtension = Path.GetExtension(inputFilePath);
            Console.WriteLine("Enter Save path");
            string outputfilePath = Console.ReadLine();

            if (action == "Encrypt")
            {
                Encrypt(inputFilePath, outputfilePath + fileName + "_Decrypt" + fileExtension);
            }
            else if (action == "Decrypt")
            {
                Decrypt(inputFilePath, outputfilePath + fileName + "_Encrypt" + fileExtension);
            }
            else
            {
                Console.WriteLine("Invalid Action");
            }
        }

        private static void Encrypt(string inputFilePath, string outputfilePath)
        {
            try
            {
                string EncryptionKey = "MAKAV2SPBNI99212";
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (FileStream fsOutput = new FileStream(outputfilePath, FileMode.Create))
                    {
                        using (CryptoStream cs = new CryptoStream(fsOutput, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            using (FileStream fsInput = new FileStream(inputFilePath, FileMode.Open))
                            {
                                int data;
                                while ((data = fsInput.ReadByte()) != -1)
                                {
                                    cs.WriteByte((byte)data);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }
            finally
            {
                Console.WriteLine("Action Completed");
            }
        }
        private static void Decrypt(string inputFilePath, string outputfilePath)
        {
            try
            {
                string EncryptionKey = "MAKAV2SPBNI99212";
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (FileStream fsInput = new FileStream(inputFilePath, FileMode.Open))
                    {
                        using (CryptoStream cs = new CryptoStream(fsInput, encryptor.CreateDecryptor(), CryptoStreamMode.Read))
                        {
                            using (FileStream fsOutput = new FileStream(outputfilePath, FileMode.Create))
                            {
                                int data;
                                while ((data = cs.ReadByte()) != -1)
                                {
                                    fsOutput.WriteByte((byte)data);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }
            finally {
                Console.WriteLine("Action Completed");
            }
        }
    }
}
