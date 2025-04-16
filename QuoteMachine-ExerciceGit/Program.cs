using QuoteMachine_ExerciceGit;

var manager = new QuoteManager();
string path = "citations.csv";
bool quit = false;

do
{
    AfficherMenu();
    Console.Write("Votre choix : ");
    string? keyPressed = Console.ReadLine();
    switch (keyPressed)
    {
        case "1":
            ShowRandomQuote(manager);
            break;
        case "2":
            AddNewQuote(manager);
            break;
        case "3":
            LoadQuotesFromFile(manager);
            break;
        case "4":
            SaveQuotesToFile(manager);
            break;
        case "5":
            quit = true;
            break;
        default:
            Console.WriteLine("Votre choix est invalide ou vous n'avez entré aucun choix");
            break;
    }
    Console.WriteLine();

} while (!quit);

static void AfficherMenu()
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("=== Menu Principal ===");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("1. Afficher une citation aléatoire");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("2. Ajouter une citation");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("3. Charger les citations");
    Console.WriteLine("4. Sauvegarder les citations");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("5. Quitter");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
}

static void ShowRandomQuote(QuoteManager manager)
{
    Console.WriteLine("[Simulation] Une citation aléatoire s’afficherait ici.");
    // Exemple futur : Console.WriteLine(manager.GetRandomQuote());
}

static void AddNewQuote(QuoteManager manager)
{
    Console.WriteLine("[Simulation] On ajouterait une nouvelle citation ici.");
    // Exemple futur :
    // Console.Write("Texte : ");
    // var texte = Console.ReadLine();
    // Console.Write("Auteur : ");
    // var auteur = Console.ReadLine();
    // manager.AddQuote(texte, auteur);
    // Console.WriteLine("Citation ajoutée !");
}

static void SaveQuotesToFile(QuoteManager manager)
{
    try
    {
        Console.WriteLine("[Simulation] On sauvegarderait les citations ici.");
        // Exemple futur :
        // manager.SaveToFile("citations.txt");
        //Console.WriteLine("Citations sauvegardées !");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erreur : {ex.Message}");
    }
}

static void LoadQuotesFromFile(QuoteManager manager)
{
    try
    {
        manager.LoadFromCSVFile("citations.csv");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erreur : {ex.Message}");
    }
}

