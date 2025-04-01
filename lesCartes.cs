using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5TI2025_Poker_MarcqNathan
{
    public struct lesCartes
    {
        public string Suit {  get; set; }
        public string Niveau { get; set; }
        public string Symbole { get; set; }

        public lesCartes(string suit, string niveau, string symbole)
        {
            Suit = suit;
            Niveau = niveau;
            Symbole = symbole;

        }

    }
    struct tableau
    {
        public List<lesCartes> cartes { get; set; }

        public tableau()
        {
            cartes = new List<lesCartes>();

            string[] suite = { "♥", "♠", "♣", "♦" };

            string[] niveaux = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "0", "V", "D", "R" };

            foreach (string suit in suite)
            {
                foreach (string niveau in niveaux)
                {
                    string image = $" ------- \r\n|{suit}        {suit}|\r\n|        |\r\n|    {niveau}    |\r\n|        |\r\n|{niveau}     {niveau}|\r\n ------- ";

                    cartes.Add(new lesCartes(suit, niveau, image));
                }
            }
        }
    }
    
}
