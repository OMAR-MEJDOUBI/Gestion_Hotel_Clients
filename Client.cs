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

        
        public override string ToString()
        {
            string clientInfo = string.Format(
                "Le nom de client est {0}" 
                + ", son prenom est {1}"
                + ", son courriel est {2}"
                + ", son numero de carte credit est {3}" 
                + " et son numero de chambre c'est: {4}", 
                Nom, Prenom, Courriel, CarteCredit, NumeroChambre);
            return clientInfo;
        }
        
    
    }
}
