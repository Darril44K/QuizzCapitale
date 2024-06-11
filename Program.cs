using System.Security.Cryptography.X509Certificates;

string[] pays = { "Albanie", "Allemage", "Andorre", "Autriche", "Belgique", "Biélorussie", "Bosnie-Herzégovine", "Bulgarie", "Chypre", "Croatie" };
string[] capitale = { "Tirana", "Berlin", "Andorre-la-Vieille", "Vienne", "Bruxelles", "Minsk", "Sarajevo", "Sofia", "Nicosie", "Zagreb" };

int bonneReponse = 0;
bool play = true;


    playGame();
    
    void playGame()
    {
        Loop(pays, capitale);
    }

    void Loop(string[] pays, string[] capitale)
    {
        while ( play )
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
            Win(bonneReponse);
            Replay();
        }
        
    }

    static void Win(int reponseBonne)
    {
        Console.WriteLine($"Vous avez un total de bonne réponse de {reponseBonne} !!!");
    }

    void Replay()
    {
        Console.WriteLine("Rejouer taper O");
        string repPlay = Console.ReadLine();
        if (repPlay == "o" || repPlay == "O")
        {
            Console.Clear();
            bonneReponse = 0;        
        }
        else
        {
            play = false;
            Console.Clear();
            Console.WriteLine("Merci d'avoir jouer au jeu");
        }
    }

    
    

    


