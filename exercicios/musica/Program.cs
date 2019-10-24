using System;
using musica.Models;
using musica.Interfaces;

namespace musica
{

    enum FormacaoEnum : int
    {
        TRIO = 3,
        QUARTETO
    };

    enum InstrumentosEnum : int 
    {
        BAIXO,
        BATERIA,
        CONTRABAIXO,
        GUITARRA,
        TECLADO,
        TAMBORES,
        VIOLAO,
    };

    enum CategoriaEnum : int 
    {
        HARMONIA,
        PERCUSSAO,
        MELODIA
    };

    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = false;
            string[] itensMenuPrincipal = Enum.GetNames(typeof(FormacaoEnum));
            string[] itensMenuCategoria = Enum.GetNames(typeof(CategoriaEnum));
            
            var opcoesFormacao = new List <string> ()
            {
                    "  -0  ",
                    "  -1  "
            };
           
        }
    }
}



/* InstrumentoMusical generico = new InstrumentoMusical();
            System.Console.WriteLine("Generico: "+ generico.TocarMusica());

            Violao violao1 = new Violao();
            System.Console.WriteLine("Violao "+violao1);
            violao1.TocarAcordes();*/