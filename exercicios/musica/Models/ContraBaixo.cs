using System;
using musica.Interfaces;

namespace musica.Models
{
    public class ContraBaixo : InstrumentoMusical, IPercussao, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine("Mantendo Ritmo do Contrabaixo");
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando Acordes de Contrabaixo");
            return true;
        }
    }
}