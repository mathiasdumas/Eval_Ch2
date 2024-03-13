namespace MNS;

class Program
{
    static void Main(string[] args)
    {
        //Calendrier calendrier = new Calendrier(2024, Day.Monday, Month.January, 1);
        //Client client1 = new Client("Gualtieri", "Jessica", 10000);
        //Client client2 = new Client("Dumas", "Mathias", 10000);
        //Logement logement = new Logement(client2, client1, 400, "appartement", calendrier);

        //Console.WriteLine(client1.Fonds);
        //Console.WriteLine(client2.Fonds);

        APItem Rabaddon = new APItem("Radabbon", 3000, 0, 1000, 0);
        Joueur joueur1 = new Joueur(100, 100, 100);
        joueur1.PO += 4000;
        joueur1.AcheterObjet(Rabaddon, 3);

        joueur1.AfficherInventaire();
        Console.WriteLine(joueur1.AP);

    }
}

