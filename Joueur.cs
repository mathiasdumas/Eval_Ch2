using System;
namespace MNS
{
	public class Joueur
	{
		public APItem[] Inventaire;
		public int PO { get; set; }
		public int AP { get; set; }
		public int PV { get; set; }
		public int PM { get; set; }

        public Joueur(int aP, int pV, int pM)
        {
            Inventaire = new APItem[6];
            PO = 0;
            AP = aP;
            PV = pV;
            PM = pM;
        }

        public void AcheterObjet(APItem aPItem, int index)
		{
			if (Inventaire[index] == null && PO >= aPItem.Valeur)
			{
                PO -= aPItem.Valeur;
				Inventaire[index] = aPItem;
				AP += aPItem.BonusAP;
				PV += aPItem.BonusPV;
				PM += aPItem.BonusPM;
            } else
			{
				Console.WriteLine("Je ne peux pas acheter l'objet");
			}
		}

		public void AfficherInventaire()
		{
			foreach (var item in Inventaire)
			{
				if (item == null)
				{
					Console.WriteLine("vide");
				} else
				{
                    Console.WriteLine(item.Nom);
                }
				
			}
		}

	
	}
}

