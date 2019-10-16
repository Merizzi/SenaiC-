using System;
using System.Collections.Generic;
using System.Text;
using musica.Interfaces;

namespace musica.Models
{
    public class Violao : InstrumentoMusical, IHarmonia, IPercussao, IMelodia
    {
        public bool TocarAcordes()
        {
           System.Console.WriteLine("Tocando acordes do Violão.");
           return true;
        }

        public bool ManterRitmo(){
            System.Console.WriteLine("Mantendo Ritmo do Violão");
            return true;
        }
        public bool TocarSolo(){
            System.Console.WriteLine("Tocando solo de Violão");
            return true;
        }
    }
}