using System;
using musica.Interfaces;

namespace musica.Models
{
    public class Tambores : InstrumentoMusical, IPercussao
    {
        public bool ManterRitmo(){
            System.Console.WriteLine("Mantendo ritmo dos Tambores");
            return true;
        }
    }
}