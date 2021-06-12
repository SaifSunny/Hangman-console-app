using System;

namespace hangman
{
    class Program
    {
        static void hangman(int count)
        {
            if(count == 4)
            {
                Console.WriteLine("    ________   ");
                Console.WriteLine("    |      O   ");
                Console.WriteLine("    |          ");
                Console.WriteLine("    |          ");
                Console.WriteLine("    |          ");
                Console.WriteLine("____|____      ");
            }
            else if (count == 3)
            {
                Console.WriteLine("    ________   ");
                Console.WriteLine("    |      O   ");
                Console.WriteLine("    |      |   ");
                Console.WriteLine("    |      |   ");
                Console.WriteLine("    |          ");
                Console.WriteLine("____|____      ");
            }
            else if (count == 2)
            {
                Console.WriteLine("    ________   ");
                Console.WriteLine("    |      O   ");
                Console.WriteLine("    |     \\|/  ");
                Console.WriteLine("    |      |   ");
                Console.WriteLine("    |          ");
                Console.WriteLine("____|____      ");
            }
            else if (count == 1)
            {
                Console.WriteLine("    ________   ");
                Console.WriteLine("    |      O   ");
                Console.WriteLine("    |     \\|/  ");
                Console.WriteLine("    |      |   ");
                Console.WriteLine("    |     / \\  ");
                Console.WriteLine("____|____      ");
            }
        }
        static void hangman(string word)
        {
            char[] guess = new char[word.Length];
            int count = 5;
            int l;
            Console.WriteLine("Your Word \n");

            for (int p = 0; p < word.Length; p++)
                guess[p] = '*';
            Console.WriteLine(guess);
            Console.WriteLine();
            Console.WriteLine("Please enter your guess: \n");

            while (count != 0)
            {
                l = 0;
                char playerGuess = char.ToLower(char.Parse(Console.ReadLine()));
                for (int i = 0; i < word.Length; i++)
                {
                    if (playerGuess != word[i])
                    {
                        l = 1;
                        break;
                    }
                }

                for (int i = 0; i < word.Length; i++)
                {
                    if (playerGuess == word[i])
                    {
                        guess[i] = playerGuess;
                        l = 2;
                    }
                }
                Console.WriteLine();
                Console.WriteLine(guess);
                if (l == 1)
                {
                    count--;
                    Console.WriteLine("Incorrect Guess. {0} lives Remainig", count);
                    hangman(count);
                    Console.WriteLine();
                }
                else if (l == 2)
                {
                    Console.WriteLine("Correct Guess.");
                }

                string g = new string(guess);
                if (String.Equals(word, g))
                {
                    Console.WriteLine("\nYou Won.\n\n The word was {0}", word);
                }
            }
            Console.WriteLine("\nYou Lose.\n\n The word was {0}", word);
        }
        static void animals()
        {
            string[] animal = { "sheep", "elephant", "mouse", "rabbit", "turtle", "deer", "kangaroo", "horse", "hippopotamus", "giraffe" };
            Random r = new Random();
            var ind = r.Next(animal.Length);
            string word = animal[ind];

            hangman(word);
           
            Console.WriteLine();
        }
        static void birds()
        {
            string[] bird = { "crow", "peacock", "hawk", "flamingo", "ostrich", "penguin", "woodpecker", "swan", "dove", "sparrow" };
            Random r = new Random();
            var ind = r.Next(bird.Length);
            string word = bird[ind];

            hangman(word);

            Console.WriteLine();
        }
        static void fruits()
        {
            string[] fruit = { "jackfruit", "papaya", "grapefruit", "coconut", "avocado", "banana", "raspberry", "pomegranate", "strawberry", "pear" };
            Random r = new Random();
            var ind = r.Next(fruit.Length);
            string word = fruit[ind];

            hangman(word);

            Console.WriteLine();
        }
        static void menu()
        {
            Console.WriteLine("Welcome to Hangman...");
            Console.WriteLine();
            Console.WriteLine("Hangman Catagory");
            Console.WriteLine();
            Console.WriteLine("1.Animal.");
            Console.WriteLine("2.Birds.");
            Console.WriteLine("3.Fruits.");
            Console.WriteLine();
            Console.WriteLine("Press q to Quit the game.");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            bool x = true;
            while (x == true)
            {
            m:
                Console.Clear();
                menu();
                Console.WriteLine("Select a Catagory...");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        animals();
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadLine();
                        goto m;
                        break;
                    case "2":
                        Console.Clear();
                        birds();
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadLine();
                        goto m;
                        break;
                    case "3":
                        Console.Clear();
                        fruits();
                        Console.WriteLine("Press Enter to Continue");
                        Console.ReadLine();
                        goto m;
                        break;
                    case "q":
                    case "Q":
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong Input.\nPress Enter to Try Again....");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}