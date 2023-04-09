using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Hotel_Clients
{
    internal class Client
    {
        // Propriétés
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Courriel { get; set; }
        public string CarteCredit { get; set; }
        public int NumeroChambre { get; set; }

        // Constructeur
        public Client(string nom, string prenom, string courriel, string carteCredit, int numeroChambre)
        {
            Nom = nom;
            Prenom = prenom;
            Courriel = courriel;
            CarteCredit = carteCredit;
            NumeroChambre = numeroChambre;
        }
    }
}
