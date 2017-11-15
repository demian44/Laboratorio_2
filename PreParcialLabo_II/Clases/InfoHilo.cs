using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Clases
{
    //    Clase InfoHilos:
    //a. Atributo estático randomizer. El mismo se inicializará en un constructor de clase.
    //b. El Thread hilo ejecutará el método Ejecutar.
    //c. Ejecutar frenará el código durante un tiempo aleatorio de entre 1 y 5 segundos. Luego de
    //transcurrir este tiempo, utilizará el método RespuestaHilo de callback pasando como
    //parámetro el atributo id.
    public class InfoHilo
    {
        private Random _randomizer;
        private int id;
        private Thread hilo;
        IRespuesta<int> callback;
    }
}
