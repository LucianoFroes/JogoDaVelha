using System;
using System.Collections.Generic;

namespace JogoDaVelha {
    class JogoDaVelha {

        //Menus menu = new Menus();
        //Jogadores jogadores = new Jogadores();

        //char[,] posicoes = new char[,] { { '7', '8', '9' }, { '4', '5', '6' }, { '1', '2', '3' } };
        char[,] posicoes = new char[,] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };

        public void ExibirJogoDaVelha() {

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("       |       |        ");
            Console.WriteLine($"   {posicoes[0, 0]}   |   {posicoes[0, 1]}   |   {posicoes[0, 2]}    ");
            Console.WriteLine("_______|_______|_______ ");
            Console.WriteLine("       |       |        ");
            Console.WriteLine($"   {posicoes[1, 0]}   |   {posicoes[1, 1]}   |   {posicoes[1, 2]}    ");
            Console.WriteLine("_______|_______|_______ ");
            Console.WriteLine("       |       |        ");
            Console.WriteLine($"   {posicoes[2, 0]}   |   {posicoes[2, 1]}   |   {posicoes[2, 1]}    ");
            Console.WriteLine("       |       |        ");
            Console.ResetColor();

        }

        public void XisOuBolinha() {
        }

        //public void ReceberEscolha() {

        //    int escolha = int.Parse(Console.ReadLine());

        //    switch (escolha) {
        //        case 1:
        //            posicoes[2, 0] =
        //    }
        //}
    }
}

