using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ej20_Bolígrafo
{
    public enum E_Estado { lleno, vacio}
    class Boligrafo
    {
        private const int maximoAzul = 100;
        private const int maximoRojo = 50;
        ConsoleColor color;
        private int tinta;
        public Boligrafo(ConsoleColor valorColor, E_Estado estado)
        {
            color = valorColor;
            if (estado == E_Estado.lleno)
            {
                Recargar();
            }
        }
        public Boligrafo()
        {
            color = ConsoleColor.Black;
            Recargar();
        }
        public ConsoleColor Pintar(int gasto)
        {
            ConsoleColor retornoColor = ConsoleColor.Black;
            if (tinta >= gasto)
            {
                tinta -= gasto;
                retornoColor = color;
            }
            return retornoColor;
        }
        public void ElegirColor(ConsoleColor valorColor)
        {
            color = valorColor;
        }
        public void Recargar()
        {
            switch (color)
            {
                case ConsoleColor.Blue:
                    tinta = maximoAzul;
                    break;
                case ConsoleColor.Red:
                    tinta = maximoRojo;
                    break;
                default:
                    tinta = 30;
                    break;
            }
        }
        public void Recargar(int cantTinta)
        {
            tinta = cantTinta;
        }
    }
}
