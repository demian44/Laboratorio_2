using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test
{
    [TestClass()]
    public class ConstructoresPaciente
    {
        [TestMethod()]
        public void TestMethod1()
        {
            
            Paciente paciente1= new Paciente("Nombre", "Apellido");
            if (paciente1.Turno != 3)
                Assert.Fail("El primer valor debe ser 1.");
            
            Paciente paciente2 =new Paciente("Nombre", "Apellido", 5);
            if(paciente2.Turno!=5)
                Assert.Fail("El segundo valor debe ser 5.");

            Paciente paciente3 =new Paciente("Nombre", "Apellido");
            if (paciente3.Turno != 6)
                Assert.Fail("El ultimo valor debe continuar al anterior (5). Valor: " + paciente3.Turno);
        }
    }
}
