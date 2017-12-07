using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                Persona  persona = new Persona(15, Corredor.Carril.Carril_2, "Fernando");
                Assert.Fail("No debe permitir valores superiores a 10");
            }
            catch(Exception exception)
            {
               
            }
        }
    }
}
