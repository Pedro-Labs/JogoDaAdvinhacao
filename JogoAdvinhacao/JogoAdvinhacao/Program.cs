using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoAdvinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine($"Certo, {nome}, estou pensando em um número entre 1 e 100. Tente adivinhar!");

            Random random = new Random();
            int numeroSecreto = random.Next(1, 101);

            int tentativas = 0;
            int palpite = 0;

            while (palpite != numeroSecreto)
            {
                Console.Write("Digite seu palpite: ");
                if (!int.TryParse(Console.ReadLine(), out palpite))
                {
                    Console.WriteLine("Por favor, digite um número válido.");
                    continue;
                }

                tentativas++;

                if (palpite < numeroSecreto)
                {
                    Console.WriteLine("Dica: O número é maior.");
                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Dica: O número é menor.");
                }
                else
                {
                    Console.WriteLine($"Parabéns, {nome}! Você acertou em {tentativas} tentativas.");
                }
            }
        }
    }
}
