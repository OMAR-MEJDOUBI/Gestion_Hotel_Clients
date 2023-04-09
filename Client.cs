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

        private static int nbrClient = 0;
        public int NumeroReservation { get; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Courriel { get; set; }
        public string CarteCredit { get; set; }
        public int NumeroChambre { get; set; }

        // Constructeur
        public Client(string nom, string prenom, string courriel, string carteCredit, int numeroChambre)
        {
            NumeroReservation = ++nbrClient;
            Nom = nom;
            Prenom = prenom;
            Courriel = courriel;
            CarteCredit = carteCredit;
            NumeroChambre = numeroChambre;

        }

        public override string ToString()
        {
            string clientInfo = string.Format("Le nom de client est {0}" + ", son prenom est {1}" + ", son numero de reservation est {2}" + " et son numero de chambre c'est: {3}", Nom, Prenom, NumeroReservation, NumeroChambre );
            return clientInfo;
        }


    }
}
