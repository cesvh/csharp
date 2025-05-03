using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _001TestSameDirTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string respuesta_esperada = "Test";

            string respuesta_obtenida = _001TestSameDir.Program.Test();
            Assert.AreEqual(respuesta_esperada, respuesta_obtenida);
        }

        [TestMethod]
        public void LoginTrue()
        {
            string user = "admin";
            string password = "1234";
            bool respuesta_esperada = true;

            bool respuesta_obtenida = _001TestSameDir.Program.Login(user, password);
            Assert.AreEqual(respuesta_esperada, respuesta_obtenida);
        }

        [TestMethod]
        public void LoginFalse()
        {
            string user = "admin.";
            string password = "1234.";
            bool respuesta_esperada = false;

            bool respuesta_obtenida = _001TestSameDir.Program.Login(user, password);
            Assert.AreEqual(respuesta_esperada, respuesta_obtenida);
        }
    }
}
