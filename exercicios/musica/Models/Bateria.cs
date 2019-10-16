using System;
using musica.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace musica.Models
{
    public class Bateria : InstrumentoMusical, IPercussao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo ritmo da bateria");
            return true;
        }
    }
}