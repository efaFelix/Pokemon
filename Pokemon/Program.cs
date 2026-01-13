using Microsoft.VisualBasic;

namespace Pokemon
{

    public class GameController
    {
        Pokemon yourPokemon;

        private List<Pokemon> pokeList = new List<Pokemon>();

        public GameController()
        {
            pokeList.Add(new Pokemon("Glumanda", "Fire", 100, 75));
            pokeList.Add(new Pokemon("Schiggy", "Whater", 125, 50));
            pokeList.Add(new Pokemon("Bisasam", "Plant", 175, 25));
        }


        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Dr. Oak: Hello! Do you want to become a Trainer? [yes/no]");
                string input = Console.ReadLine()?.Trim().ToLower();

                if (input == "yes")
                {
                    Console.WriteLine("Dr. Oak: Okay then!");
                    ChoosePokemon();
                    break;
                }
                else if (input == "no")
                {
                    Console.WriteLine("Dr. Oak: Well, that's fair enough.");
                    break;
                }
                else
                {
                    Console.WriteLine("Dr. Oak: I couldn't understand you, let's try again...");
                    Start();
                }
            }
        }


        public void ChoosePokemon()
        {
            while (true)
            {
                Console.WriteLine("Dr. Oak: Please choose your starter! We have:");
                ShowPokemon();

                string input = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Dr. Oak: You didn't enter anything. Try again!");
                    continue;
                }

                // Prüfen, ob das Pokémon existiert (Case-insensitive)
                if (pokeList.Exists(p => p.Name.Equals(input, StringComparison.OrdinalIgnoreCase)))
                {
                    Console.WriteLine($"Dr. Oak: You have chosen {input}. Are you sure you want to become its Trainer? [yes/no]");
                    string ans = Console.ReadLine()?.Trim().ToLower();

                    if (ans.Equals(ans, StringComparison.OrdinalIgnoreCase))
                    {
                        yourPokemon = pokeList.FirstOrDefault(p => p.Name == "Glumanda");
                        Console.WriteLine("Dr. Oak: Great!");
                        var enemyPokemon = SetEnemyPokemon(yourPokemon);
                        break; // Schleife verlassen
                    }
                    else if (ans == "no")
                    {
                        Console.WriteLine("Dr. Oak: Okay, then let's have another look!");
                        continue; // Zurück zur Auswahl
                    }
                    else
                    {
                        Console.WriteLine("Dr. Oak: I'll take that as a yes!");
                        yourPokemon = pokeList.FirstOrDefault(p => p.Name == "Glumanda");
                        var enemyPokemon = SetEnemyPokemon(yourPokemon);
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Dr. Oke: I'm sorry, but there is no such Pokémon.");
                }
            }
        }

        public void ShowPokemon()
        {
            foreach (var pokemon in pokeList)
            {
                Console.WriteLine(pokemon.ToString());
            }
        }

        public Pokemon SetEnemyPokemon(Pokemon yourPokemon)
        {
            Pokemon enemyPokemon;

            Console.WriteLine("Unknown: Not so fast old mann, I also come here to become a Pokemon trainer!");

            if (yourPokemon.Name == "Glumanda")
            {
                enemyPokemon = pokeList.FirstOrDefault(p => p.Name == "Shiggy");
            }
            else if (yourPokemon.Name == "Schiggy")
            {
                enemyPokemon = pokeList.FirstOrDefault(p => p.Name == "Bisasam");
            }
            else
            {
                enemyPokemon = pokeList.FirstOrDefault(p => p.Name == "Glumanda");
            }

            Console.WriteLine("Unknown: I am Blue! And I choose you " + enemyPokemon.Name + "!");
            Console.WriteLine("Blue: And you, yeah you lets fight!");
            return enemyPokemon;
        }
    }


    public class Programm
    {
        public static void Main(string[] args)
        {
            var gameController = new GameController();
            gameController.ShowPokemon();
            gameController.Start();
        }
    }
}


