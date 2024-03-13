using System;
namespace MNS
{
	public class Client
	{
		public string Nom { get; set; }
		public string Prenom { get; set; }
		public float Fonds { get; set; }

        public Client(string nom, string prenom, float fonds)
        {
            Nom = nom;
            Prenom = prenom;
            Fonds = fonds;
        }


    }
}

