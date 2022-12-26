using System;
using System.Collections.Generic;

namespace JogoDaVelha {
    class Jogadores {

        bool jogadorUm, jogadorDois;
        Menus menu = new Menus();
        JogoDaVelha jogoDaVelha = new JogoDaVelha();

        public static List<string> nomesJogadores = new List<string>();
        public static List<double> scoreJogadores = new List<double>();

        public void AdicionarJogador(List<string> nomesJogadores, List<double> scoreJogadores) {
            Console.Clear();
            Console.Write("\nDigite o nome do(a) Jogador(a): ");
            string nomeJogador = Console.ReadLine().Trim();

            if (ConferirCadastroJogador(nomeJogador) == false) {

                nomesJogadores.Add(nomeJogador);
                scoreJogadores.Add(0);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nCadastro concluído com sucesso.\n");
                Console.ResetColor();

            } else {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNão foi possível cadastrar o usuário, nome já está em uso.\n");
                Console.ResetColor();

            }
        }

        public bool ConferirCadastroJogador(string nomeJogador) {
            return nomesJogadores.Contains(nomeJogador);
        }

        public int IndiceDoJogador(string nomeJogador) {
            return nomesJogadores.IndexOf(nomeJogador);
        }

        public void ExcluirJogador(List<string> nomesJogadores, List<double> scoreJogadores) {
            Console.Clear();
            Console.Write("\nDigite o nome do(a) jogador(a): ");
            string nomeJogador = Console.ReadLine().Trim();

            if (ConferirCadastroJogador(nomeJogador) == true) {
                Console.WriteLine($"\nCerteza que deseja excluir o(a) jogador(a)");

                menu.MenuExcluirJogador();
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1) {
                    nomesJogadores.RemoveAt(IndiceDoJogador(nomeJogador));
                    scoreJogadores.RemoveAt(IndiceDoJogador(nomeJogador));

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nJogador(a) removido com sucesso.\n");
                    Console.ResetColor();

                } else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nJogador(a) não foi removido(a).\n");
                    Console.ResetColor();
                }
            } else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nJogador(a) não encontrado(a).\n");
                Console.ResetColor();
            }
        }

        public void MostrarTodosJogadores(List<string> nomesJogadores, List<double> scoreJogadores) {
            Console.Clear();
            for (int i = 0; i < nomesJogadores.Count(); i++) {
                Console.WriteLine($"[{i}] - {nomesJogadores[i]} | {scoreJogadores[i]} pontos");
            }
        }

        public void SelecionarJogadoresUmEDois(List<string> nomesJogadores, List<double> scoreJogadores) {


        }
    }
}



