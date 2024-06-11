namespace QuizzCapitale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] pays = {"Albanie","Allemage","Andorre","Autriche","Belgique","Biélorussie","Bosnie-Herzégovine","Bulgarie","Chypre","Croatie"};
            string[] capitale = { "Tirana", "Berlin", "Andorre-la-Vieille", "Vienne", "Bruxelles", "Minsk", "Sarajevo", "Sofia", "Nicosie", "Zagreb" };

            int bonneReponse = 0;
            bool play = true;


            while (play)
            {
                for (int i = 0; i < pays.Length; i++)
                {
                    Console.WriteLine($"Quels est la capitale du pays :{pays[i]}");
                    string rep = Console.ReadLine();

                    if (rep == capitale[i])
                    {
                        Console.WriteLine("Bravo");
                        bonneReponse++;
                    }
                    else
                    {
                        Console.WriteLine($"Mauvaise réponse. La réponse était {capitale[i]}");
                    }

                }
                Console.WriteLine($"Vous avez un total de bonne réponse de {bonneReponse} !!!");

                Console.WriteLine("Rejouer taper O");
                string repPlay = Console.ReadLine();

                if (repPlay == "o" || repPlay == "O")
                {
                    Console.Clear();
                }else
                {
                    play = false;
                    Console.WriteLine("Merci d'avoir jouer au jeu");
                }

            }

            



        }
    }
}
