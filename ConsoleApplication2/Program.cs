using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] players = {"pedro", "edilson", "buzz", "gustavo", "matheus", "duda", "anhetti", "bretas", "yan", "andre"};

            int[] highscore = {349, 452, 241, 458, 522, 535, 747, 356, 946, 560};
            
            for (int j = 0; j < highscore.Length; j++)
            {
                for (int i = 0; i < highscore.Length - 1; i++)
                {
                    if (highscore[i] < highscore[i + 1])
                    {
                        int temp = 0;
                        temp = highscore[i + 1];
                        highscore[i + 1] = highscore[i];
                        highscore[i] = temp;

                        String temp2 = players[i + 1];
                        players[i + 1] = players[i];
                        players[i] = temp2;

                    }
                }
            }

            
            for (int i = 0; i < highscore.Length; i++)
                Console.WriteLine(" " + highscore[i] + "     " + players[i]);

            Console.WriteLine(" ");

            Console.WriteLine("Diga seu nome");
            String nome = Console.ReadLine();

            Console.WriteLine("Diga seu score");
            int score = int.Parse(Console.ReadLine());

            if (score > highscore[highscore.Length - 1])
            {
                highscore[highscore.Length - 1] = score;
                players[players.Length - 1] = nome;

                for (int j = 0; j < highscore.Length; j++)
                {
                    for (int i = 0; i < highscore.Length - 1; i++)
                    {
                        if (highscore[i] < highscore[i + 1])
                        {
                            int temp = 0;
                            temp = highscore[i + 1];
                            highscore[i + 1] = highscore[i];
                            highscore[i] = temp;

                            String temp2 = players[i + 1];
                            players[i + 1] = players[i];
                            players[i] = temp2;

                        }
                    }
                }

                Console.WriteLine(" ");

               for (int i = 0; i < highscore.Length; i++)

                    Console.WriteLine(" " + highscore[i] + "     " + players[i]);

                Console.WriteLine(" ");
                Console.WriteLine("Novo valor de HighScore");
                
            }

            else
                Console.WriteLine("jogue novamente");

        }
    }
}
