using System;

internal class Program
{
    private static void Main(string[] args)
    {
        bool canDo = true;
        while (canDo)
        {
            Console.WriteLine("Entrez la taille du labyrinth souhaite entre 3 et 100:");
            string input = Console.ReadLine();
            try
            {
                int t = Convert.ToInt32(input);
                if (t < 3 || t > 100) { throw new Exception("Nombre doit etre compris entre 3 et 100"); }
                Labyrinth labyrinth = new Labyrinth(t);
                labyrinth.Display();
                Console.WriteLine("Recommencer? : Y/N");
                string reponse = Console.ReadLine();
                switch (reponse)
                {
                    case "Y":
                        break;
                    case "N":
                        canDo = false;
                        break;
                    case "y":
                        break;
                    case "n":
                        canDo = false;
                        break;
                    default:
                        canDo = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Reessayer? : Y/N");
                string reponse = Console.ReadLine();
                switch (reponse)
                {
                    case "Y":
                        break;
                    case "N":
                        canDo = false;
                        break;
                    case "y":
                        break;
                    case "n":
                        canDo = false;
                        break;
                    default:
                        canDo = false;
                        break;
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("App par CHIARLINI Chloe et VOLLAND Jimmy");
        Console.ReadKey();

    }
}