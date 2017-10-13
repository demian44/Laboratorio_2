using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    static class ControllerComputadora
    {
        public static void controllerComputer()
        {
            Computadora[] ComputerList = new Computadora[5];
            ComputerList[0] = new Computadora(false);
            ComputerList[0].SetEstaEncedida(true);
            Array.Resize(ref ComputerList, 10); 
        }
        
    }
}
