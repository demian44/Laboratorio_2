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
                Paciente paciente = new Paciente("Nombre", "Apellido");
                if (paciente.Turno != 1)
                    Assert.Fail("Error, muestra el numero nº " + paciente.Turno + ". Debe mostrar el 1.");
            }
            catch (Exception exception)
            {
                Assert.Fail(exception.Message);
            }
            
            Paciente paciente2 = new Paciente("Nombre", "Apellido", 5);
            if (paciente2.Turno != 5)
                Assert.Fail("Error, muestra el numero nº " + paciente2.Turno + ". Debe mostrar el 5.");

            Paciente paciente3 = new Paciente("Nombre", "Apellido");
            if (paciente3.Turno != 6)
                Assert.Fail("Error, muestra el numero nº " + paciente3.Turno + ". Debe mostrar el 6.");
        }
               
                
    }
}
