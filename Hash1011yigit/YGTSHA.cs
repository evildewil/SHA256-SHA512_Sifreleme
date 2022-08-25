using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Hash1011yigit
{
    class YGTSHA
    {
        public static string SHA256_Cevir(string deger)
        {
            SHA256 sha = SHA256.Create();
            byte[] degerBytes = Encoding.UTF8.GetBytes(deger);
            byte[] shaBytes = sha.ComputeHash(degerBytes);

            return HashtoByte(shaBytes);
        }
        public static string SHA512_Cevir(string deger)
        {
            SHA512 sha = SHA512.Create();
            byte[] degerBytes = Encoding.UTF8.GetBytes(deger);
            byte[] shaBytes = sha.ComputeHash(degerBytes);

            return HashtoByte(shaBytes);
        }
        public static string SHA256_File(string yol)
        {
            SHA256 sha = SHA256.Create();
            FileInfo f = new FileInfo(yol);
            FileStream fileStream = f.Open(FileMode.Open);
            fileStream.Position = 0;
            byte[] shaBytes = sha.ComputeHash(fileStream);
            fileStream.Close();
            return HashtoByte(shaBytes);
        }
        public static string SHA512_File(string yol)
        {
            SHA512 sha = SHA512.Create();
            FileInfo f = new FileInfo(yol);
            FileStream fileStream = f.Open(FileMode.Open);
            fileStream.Position = 0;
            byte[] shaBytes = sha.ComputeHash(fileStream);
            fileStream.Close();
            return HashtoByte(shaBytes);
        }
        public static string HashtoByte(byte[] hash)
        {
            StringBuilder sb = new StringBuilder();

            foreach (byte item in hash)
            {
                sb.Append(item.ToString("x2"));
            }
            return sb.ToString();
        }
    }
}
