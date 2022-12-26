using System;
using System.Collections.Generic;

namespace JogoDaVelha {
    public class Program {
        public static void Main(string[] args) {

            var menu = new Menus();
            var jogadores = new Jogadores();
            var jogoDaVelha = new JogoDaVelha();
            int opcoes;

            do {
                menu.MenuPrincipal();
                opcoes = int.Parse(Console.ReadLine());

                switch (opcoes) {
                    case 0:
                        menu.MenuFinalizarPrograma();
                        opcoes = int.Parse(Console.ReadLine());

                        if(opcoes == 1) {
                        Console.WriteLine("\nPrograma encerrado :(");
                        return;
                        } else {
                            Console.Clear();
                            continue;
                        }
                    case 1:
                        menu.MenuIstrucaoJogoDaVelha();
                        jogadores.SelecionarJogadoresUmEDois(Jogadores.nomesJogadores, Jogadores.scoreJogadores);


                        break;
                    case 2:
                        menu.MenuCadastroJogadores();
                        opcoes = int.Parse(Console.ReadLine());

                        switch (opcoes) {
                            case 1:
                                jogadores.AdicionarJogador(Jogadores.nomesJogadores, Jogadores.scoreJogadores);
                                break;
                            case 2:
                                jogadores.ExcluirJogador(Jogadores.nomesJogadores, Jogadores.scoreJogadores);
                                break;
                        }
                        break;
                    case 3:
                        break;
                    case 4:
                        jogadores.MostrarTodosJogadores(Jogadores.nomesJogadores, Jogadores.scoreJogadores);
                        break;
                }

            } while (opcoes != 0);
        }
    }
}