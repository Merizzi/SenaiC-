using System;
using dragon.Models;

namespace dragon {
    class Program {
        static void Main (string[] args) {

            bool jogadorNDesistiu = true;
            do {
                Console.WriteLine ("++++++++++++++Mate o Dragão!++++++++++++++");

                Console.WriteLine ("1- Iniciar Jogo");
                Console.WriteLine ("0- Sair do Jogo");

                string opcaojogador = Console.ReadLine ();

                switch (opcaojogador) {

                    case "1":
                        Console.Clear ();
                        // Inicio Guerreiro
                        Guerreiro guerreiro = CriarGuerreiro ();
                       
                        // Fim Guerreiro  //

                        // Incio Dragão
                        Dragao dragao = new Dragao ();
                        dragao.Nome = "Ghidorah";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;

                        CriarDialogo ("{0}: Seu Louco vim te Derrotar!", guerreiro.Nome);
                        System.Console.WriteLine ("{0}: {1}!, Eu sou {2} e vim lhe Derrotar!!", guerreiro.Nome, dragao.Nome, guerreiro.Nome);
                        System.Console.WriteLine ("{0}: HAHAHAHA! Faça me rir humano. Quem tu pensas que és?!?", dragao.Nome);

                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Aperte ENTER para prosseguir");
                        Console.ReadLine ();

                        Console.Clear ();
                        System.Console.WriteLine ("{0}: Eu sou {0}, da familia {1}, criatura apática. ", guerreiro.Nome, guerreiro.Sobrenome);
                        System.Console.WriteLine ("{0}: Vim de {1}, para te derrotar e trazer a paz de volta a este local ", guerreiro.Nome, guerreiro.Cidade);
                        System.Console.WriteLine ("{0}: QUEM? HAHAHAHA, Que lixão é este que você falou, eu não o conheço. Bom... tu chegaste na hora certa do meu almoço, vamos rápido! ", dragao.Nome, guerreiro.Cidade);

                        Console.Clear ();
                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;
                        bool jogadorNCorre = true;

                        int poderAtaqueGuerreiro = guerreiro.Inteligencia > guerreiro.Forca ? guerreiro.Inteligencia + guerreiro.Destreza : guerreiro.Forca + guerreiro.Destreza;

                        if (jogadorAtacaPrimeiro) {
                            Console.Clear ();
                            System.Console.WriteLine ("---------Turno do Jogador---------");
                            System.Console.WriteLine ("Escolha sua ação: ");
                            System.Console.WriteLine ("1- Atacar");
                            System.Console.WriteLine ("2- Fugir");

                            string opcaoBatalha = Console.ReadLine ();
                            switch (opcaoBatalha) {
                                case "1":
                                    Random
                                    geradorNumero = new Random ();
                                    int numeroAleatorio = geradorNumero.Next (0, 5);
                                    int numeroAleatorioDragao = geradorNumero.Next (0, 5);

                                    int guerreiroDestrezatotal = guerreiro.Destreza + numeroAleatorio;
                                    int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                    if (guerreiroDestrezatotal > dragaoDestrezaTotal) {
                                        System.Console.WriteLine ("{0}: Toma essa Lagarto MALDITO!", guerreiro.Nome);
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine ("-----------");
                                        System.Console.WriteLine ("HP Dragão: {0}", dragao.Vida);
                                        System.Console.WriteLine ("HP Guerreiro: {0}", guerreiro.Vida);

                                    } else {
                                        System.Console.WriteLine ("{0}: Errroouu, humano tolo!", dragao.Nome);
                                    }
                                    break;

                                case "2":
                                    jogadorNCorre = false;
                                    System.Console.WriteLine ("{0}: VAMBORA RAPEIZE!! VALEU FALOW ", guerreiro.Nome);
                                    System.Console.WriteLine ("{0}: GG IZI", dragao.Nome);
                                    break;
                            }
                            System.Console.WriteLine ("Aperte ENTER para prosseguir..");
                            Console.ReadLine ();

                            while (dragao.Vida >= 1 && guerreiro.Vida >= 1 && jogadorNCorre) {
                                Console.Clear ();
                                System.Console.WriteLine ("---------Turno do Dragão---------");

                                Random
                                geradorNumero = new Random ();
                                int numeroAleatorio = geradorNumero.Next (0, 5);
                                int numeroAleatorioDragao = geradorNumero.Next (0, 5);

                                int guerreiroDestrezatotal = guerreiro.Destreza + numeroAleatorio;
                                int dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                if (dragaoDestrezaTotal > guerreiroDestrezatotal) {
                                    System.Console.WriteLine ("{0}: BURN SEU MALDITO BURN!", guerreiro.Nome);
                                    guerreiro.Vida -= dragao.Forca;
                                    System.Console.WriteLine ("-----------");
                                    System.Console.WriteLine ("HP Dragão: {0}", dragao.Vida);
                                    System.Console.WriteLine ("HP Guerreiro: {0}", guerreiro.Vida);

                                } else {
                                    System.Console.WriteLine ("{0}: Vem tranquilo!", guerreiro.Nome);
                                }
                                FinalizarDialogo ();
                                System.Console.WriteLine ("---------Turno do Jogador---------");
                                System.Console.WriteLine ("Escolha sua ação: ");
                                System.Console.WriteLine ("1- Atacar");
                                System.Console.WriteLine ("2- Fugir");

                                opcaoBatalha = Console.ReadLine ();
                                switch (opcaoBatalha) {
                                    case "1":
                                        geradorNumero = new Random ();
                                        numeroAleatorio = geradorNumero.Next (0, 5);
                                        numeroAleatorioDragao = geradorNumero.Next (0, 5);

                                        guerreiroDestrezatotal = guerreiro.Destreza + numeroAleatorio;
                                        dragaoDestrezaTotal = dragao.Destreza + numeroAleatorioDragao;

                                        if (guerreiroDestrezatotal > dragaoDestrezaTotal) {
                                            System.Console.WriteLine ("{0}: Toma essa Lagarto MALDITO!", guerreiro.Nome);
                                            dragao.Vida -= poderAtaqueGuerreiro + 5;
                                            System.Console.WriteLine ("-----------");
                                            System.Console.WriteLine ("HP Dragão: {0}", dragao.Vida);
                                            System.Console.WriteLine ("HP Guerreiro: {0}", guerreiro.Vida);

                                        } else {
                                            System.Console.WriteLine ("{0}: Errroouu, humano tolo!", dragao.Nome);
                                        }
                                        if (guerreiro.Vida <= 0) {
                                            System.Console.WriteLine ("Guerreiro Pereceu!");
                                        }
                                        if (dragao.Vida <= 0) {
                                            System.Console.WriteLine ("O dragão faleceu!");
                                        }

                                        break;

                                    case "2":
                                        jogadorNCorre = false;
                                        System.Console.WriteLine ("{0}: VAMBORA RAPEIZE!! VALEU FALOW ", guerreiro.Nome);
                                        System.Console.WriteLine ("{0}: GG IZI", dragao.Nome);
                                        break;
                                }
                                FinalizarDialogo ();

                            }
                        }

                        break;

                    case "0":
                        jogadorNDesistiu = false;
                        break;

                    default:
                        System.Console.WriteLine ("Comando Inválido.Tente novamente seguindo as instruções!!!");
                        break;
                }
            } while (jogadorNDesistiu);

        }

        
        private static void CriarDialogo (string nome, string frase) {
            System.Console.WriteLine ("{0}: {1}", nome, frase);
        }

        private static void FinalizarDialogo () {
            System.Console.WriteLine ();
            System.Console.WriteLine ("Aperte ENTER para prosseguir");
            Console.ReadLine ();
            Console.Clear ();

        }

        private static Guerreiro CriarGuerreiro () {
            Guerreiro guerreiro = new Guerreiro ();
            guerreiro.Nome = "Skilpadde";
            guerreiro.Sobrenome = "Merizzi";
            guerreiro.Cidade = "Oslo";
            guerreiro.Datanascimento = DateTime.Parse ("13/03/1109");
            guerreiro.Ataque = "Espada Longa";
            guerreiro.Protecao = "Escudo";
            guerreiro.Forca = 2;
            guerreiro.Destreza = 3;
            guerreiro.Inteligencia = 3;
            guerreiro.Vida = 20;
            return guerreiro;
        }
    }

}