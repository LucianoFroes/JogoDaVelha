using System;
using System.Collections.Generic;

namespace JogoDaVelha {
    class Menus {

        public void MenuPrincipal() {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("------------------------ BEM VINDO AO JOGO DA VELHA -------------------------");
            Console.ResetColor();

            Console.WriteLine("\n[1] - Jogar");
            Console.WriteLine("[2] - Cadastro Jogadores");
            Console.WriteLine("[3] - Acessar Ranking");
            Console.WriteLine("[4] - Jogadores Cadastrados");
            Console.WriteLine("[0] - Encerrar Programa");
            Console.WriteLine("\nSelecione a opção desejada.");

        }

        public void MenuCadastroJogadores() {

            Console.WriteLine("[1] - Adicionar Jogador");
            Console.WriteLine("[2] - Remover Jogador");
            Console.WriteLine("\nSelecione a opção desejada.");
        }

        public void MenuExcluirJogador() {
            Console.WriteLine("[1] Sim");
            Console.WriteLine("[2] Não");
            Console.WriteLine("\nSelecione a opção desejada.");
        }

        public void MenuIstrucaoJogoDaVelha() {

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n---------------------------- INSTRUÇÕES DE JOGO -----------------------------");
            Console.ResetColor();

            Console.WriteLine("\nCada número corresponde ao local que o jogador deseja inserir X ou O.\n");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("       |       |        ");
            Console.WriteLine("   7   |   8   |   9    ");
            Console.WriteLine("_______|_______|_______ ");
            Console.WriteLine("       |       |        ");
            Console.WriteLine("   4   |   5   |   6    ");
            Console.WriteLine("_______|_______|_______ ");
            Console.WriteLine("       |       |        ");
            Console.WriteLine("   1   |   2   |   3    ");
            Console.WriteLine("       |       |        ");

            Console.ResetColor();

            Console.WriteLine("\nAperte Enter para continuar.");
            Console.ReadLine();
            Console.Clear();
        }

        public void MenuFinalizarPrograma() {
            Console.WriteLine("Certeza que deseja finalizar o programa?");
            Console.WriteLine("[1] Sim");
            Console.WriteLine("[2] Não");
            Console.WriteLine("\nSelecione a opção desejada.");
        }

    }
}
