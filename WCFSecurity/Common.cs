using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace WCFSecurity
{
    public class Common
    {
        public string GenerateSHA256(string message)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(message);
            SHA256Managed sHA256 = new SHA256Managed();
            byte[] hash = sHA256.ComputeHash(bytes);

            string hashString = string.Empty;
            foreach (byte x in hash)
                hashString += String.Format("{0:x2}", x);

            return hashString;
        }

        #region RindJael

        public string GenerateKey()
        {
            SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged
            {
                KeySize = 128
            };
            symmetricAlgorithm.GenerateKey();

            return Convert.ToBase64String(symmetricAlgorithm.Key);
        }


        public string Encrypt(string message, string key)
        {
            SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged
            {
                KeySize = 128
            };
            symmetricAlgorithm.Key = Convert.FromBase64String(key);
            symmetricAlgorithm.Mode = CipherMode.ECB;

            ICryptoTransform cryptoTransform = symmetricAlgorithm.CreateEncryptor();

            Byte[] data = Encoding.UTF8.GetBytes(message);
            Byte[] dataEncrypted = cryptoTransform.TransformFinalBlock(data, 0, data.Length);

            return Convert.ToBase64String(dataEncrypted);
        }


        public string Decrypt(string message, string key)
        {
            SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged
            {
                KeySize = 128
            };
            symmetricAlgorithm.Key = Convert.FromBase64String(key);
            symmetricAlgorithm.Mode = CipherMode.ECB;

            ICryptoTransform cryptoTransform = symmetricAlgorithm.CreateDecryptor();

            Byte[] data = Encoding.UTF8.GetBytes(message);
            Byte[] dataDecrypted = cryptoTransform.TransformFinalBlock(data, 0, data.Length);

            return Convert.ToBase64String(dataDecrypted);
        }

        #endregion

    }
}