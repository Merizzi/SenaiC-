using System;
using System.Collections.Generic;

namespace mes {
    class Program {
        static void Main (string[] args) {
            int i, opcao;
            bool sai = false;
            Console.WriteLine ("Meses do Ano!");
            Dictionary<int, string> calendario = new Dictionary<int, string> ();
            calendario.Add (1, "Janeiro");
            calendario.Add (2, "Fevereiro");
            calendario.Add (3, "Março");
            calendario.Add (4, "Abril");
            calendario.Add (5, "Maio");
            calendario.Add (6, "Junho");
            calendario.Add (7, "Julho");
            calendario.Add (8, "Agosto");
            calendario.Add (9, "Setembro");
            calendario.Add (10, "Outubro");
            calendario.Add (11, "Novembro");
            calendario.Add (12, "Dezembro");

            do {
                System.Console.WriteLine ("Digite um número de 1 à 12 correposdente aos meses do ano: ");
                i = int.Parse (Console.ReadLine ());

                if( i>= 1 && i<=12){
                    System.Console.WriteLine();
                    System.Console.WriteLine(calendario[i]);
                }
                else{
                    System.Console.WriteLine("Por favor Digite um número valido");
                }

                System.Console.WriteLine("Deseja repetir a operação? 1-SIM // 2-NÃO");
                opcao = int.Parse(Console.ReadLine());

                if(opcao == 2){
                    sai = true;
                }
            } while(!sai);
        }
    }
}