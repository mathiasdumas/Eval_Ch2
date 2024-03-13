using System;
namespace MNS
{
	public class APItem
	{
		public string Nom { get; set; }
		public int Valeur { get; set; }
        public int BonusPV { get; set; }
        public int BonusAP { get; set; }
        public int BonusPM { get; set; }

        public APItem(string nom, int valeur, int bonusPV, int bonusAP, int bonusPM)
        {
            Nom = nom;
            Valeur = valeur;
            BonusPV = bonusPV;
            BonusAP = bonusAP;
            BonusPM = bonusPM;
        }
    }
}

