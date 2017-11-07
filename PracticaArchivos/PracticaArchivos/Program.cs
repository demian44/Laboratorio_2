using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Peperdo peperdo = new Peperdo();
            Xml<Peperdo> coso = new Xml<Peperdo>();
            coso.Guardar("Archivo.xml", peperdo);

        }
    }

    public class Peperdo
    {
        private  int mocoloco;
        public int Mocoloco
        {
            get { return this.mocoloco; }
            set {  this.mocoloco = value; }
        }
        public string MocoCuerdo
        {
            get { return this.mocoCuerdo; }
            set { this.mocoCuerdo = value; }
        }
        private string mocoCuerdo;


        public Peperdo()
        {
            mocoloco = 333;
            mocoCuerdo = "Moco cuerdo";
        }
    }
}
