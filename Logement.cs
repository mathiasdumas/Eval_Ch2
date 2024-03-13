using System;
namespace MNS
{
	public class Logement
	{
		public Client Proprietaire { get; set; }
		public Client Locataire { get; set; }
		public float TarifLocation { get; set; }
		public string NomDuLogement { get; set; }
        public Calendrier calendrier { get; set; }



        public Logement(Client proprietaire, Client locataire, float tarifLocation, string nomDuLogement, Calendrier calendrier)
        {
            Proprietaire = proprietaire;
            Locataire = locataire;
            TarifLocation = tarifLocation;
            NomDuLogement = nomDuLogement;
            if (calendrier.DayNumber == 1)
            {
                calendrier.OnPremierDuMois += PayerLoyer;
            }
        }

        public void PayerLoyer()
        {
            Locataire.Fonds -= TarifLocation;
            Proprietaire.Fonds += TarifLocation;
        }
    }
}

