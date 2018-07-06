using Microsoft.VisualStudio.TestTools.UnitTesting;
using WCFSecurity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WCFSecurity.Tests
{
    [TestClass()]
    public class CommonUnitTests
    {
        [TestMethod()]
        public void DecryptTest()
        {
            Common common = new Common();
            var decrypt = common.Encrypt("Este es un mensaje ", "");
            Debug.WriteLine(decrypt);
            Assert.IsTrue(!string.IsNullOrEmpty(decrypt));
        }

        [TestMethod()]
        public void GenerateSHA256Test()
        {
            Common common = new Common();
            string key = common.GenerateSHA256("Visual001");
            Debug.WriteLine("LLave SHA256 Generada: " + key);
            Assert.IsTrue(!string.IsNullOrEmpty(key));
        }

        [TestMethod()]
        public void GenerateKeyTest()
        {
            Common common = new Common();
            string key = common.GenerateKey();
            Debug.WriteLine("LLave Generada: " + key);
            Assert.IsTrue(!string.IsNullOrEmpty(key));
        }

        [TestMethod()]
        public void EncryptTest()
        {
            Common common = new Common();
            var encrypt = common.Encrypt("Este es un mensaje ", "");
            Debug.WriteLine(encrypt);
            Assert.IsTrue(!string.IsNullOrEmpty(encrypt));
        }
    }
}