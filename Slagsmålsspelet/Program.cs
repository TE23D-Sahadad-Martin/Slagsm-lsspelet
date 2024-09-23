using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {

            int Player1hp = 100;
            int Player2hp = 100;

            string Player1name = "Player1";
            string Player2name = "Player2";

            Random random = new Random();

            Console.WriteLine("Välkommen till Slagsmålsspelet");
            Console.WriteLine("Tryck på Enter för att börja slåss!");

            while (Player1hp > 0 && Player2hp > 0)
            {
                
                Console.ReadLine();

                int damageToPlayer1 = random.Next(1, 40);
                int damageToPlayer2 = random.Next(1, 40);

                Player1hp -= damageToPlayer2;
                Console.WriteLine($"{Player2name} slår {Player1name} och gör {damageToPlayer2} skada!");

                Player2hp -= damageToPlayer1;
                Console.WriteLine($"{Player1name} slår {Player2name} och gör {damageToPlayer1} skada!");

                Player2hp = Math.Max(0,Player2hp);
                Player1hp = Math.Max(0,Player1hp);

                Console.WriteLine($"{Player1name} har {Player1hp} HP kvar.");
                Console.WriteLine($"{Player2name} har {Player2hp} HP kvar.");
                Console.WriteLine();
            }

            if (Player1hp <= 0 && Player2hp <= 0)
            {
                Console.WriteLine("Det blev oavgjort! Båda spelarna har ingen HP kvar.");
            }
            else if (Player1hp <= 0)
            {
                Console.WriteLine($"{Player2name} vann slagsmålet!");
            }
            else if (Player2hp <= 0)
            {
                Console.WriteLine($"{Player1name} vann slagsmålet!");
            }

            
            Console.WriteLine("Vill du spela igen? (j/n): ");
            string response = Console.ReadLine().ToLower();

            if (response != "j")
            {
                playAgain = false;
            }
        }

        Console.WriteLine("Tack för att du spelade!");
        Console.ReadLine(); 
    }
}
