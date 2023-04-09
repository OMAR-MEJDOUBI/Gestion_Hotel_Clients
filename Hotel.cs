using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Hotel_Clients
{
    internal class Hotel
    {
        // Propriétés
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public ArrayList Clients { get; set; }

        // Constructeur
        public Hotel(string nom, string adresse)
        {
            Nom = nom;
            Adresse = adresse;
            Clients = new ArrayList();
        }

        // Méthode pour ajouter un client
        public void AjouterClient(Client client)
        {
            Clients.Add(client);
        }
    }
}
