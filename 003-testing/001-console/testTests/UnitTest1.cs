using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string respuesta_esperada = "Hello World!";
            string resultado_test = _000_test.Program.Something();
            Assert.AreEqual(respuesta_esperada, resultado_test);
        }

        [TestMethod]
        public void TestLoginTrue()
        {
            bool respuesta_esperada = true;
            bool resultado_test = _000_test.Program.Login("admin", "admin");
            Assert.AreEqual(respuesta_esperada, resultado_test);
        }

        [TestMethod]
        public void TestLoginFalse()
        {
            bool respuesta_esperada = false;
            bool resultado_test = _000_test.Program.Login("admin1", "admin1");
            Assert.AreEqual(respuesta_esperada, resultado_test);
        }
    }
}
