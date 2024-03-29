using System;
using musica.Interfaces;

namespace musica.Models
{
    public class Teclado : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes de Teclado.");
            return true;
        }

        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando solo de teclado.");
            return true;
        }
    }
}