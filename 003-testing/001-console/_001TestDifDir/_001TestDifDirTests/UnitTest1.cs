using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _001TestDifDirTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTest()
        {
            string respuesta_esperada = "Test";
            string respuesta_obtenida = _001TestDifDir.Program.Test();
            Assert.AreEqual(respuesta_esperada, respuesta_obtenida);
        }

        [TestMethod]
        public void LoginTrue()
        {
            bool respuesta_esperada = true;
            bool respuesta_obtenida = _001TestDifDir.Program.Login("admin", "admin");
            Assert.AreEqual(respuesta_esperada, respuesta_obtenida);
        }

        [TestMethod]
        public void LoginFalse()
        {
            bool respuesta_esperada = false;
            bool respuesta_obtenida = _001TestDifDir.Program.Login("admin.", "admin.");
            Assert.AreEqual(respuesta_esperada, respuesta_obtenida);
        }
    }
}
