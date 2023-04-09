namespace Gestion_Hotel_Clients
{
    internal class Mains
    {
        static void Main(string[] args)
        {
            Hotel hotel1 = new Hotel("Hotel XYZ", "123 rue de la Paix");
            Client client1 = new Client("Dupont", "Pierre", "pierre.dupont@example.com", "1234 5678 9012 3456", 101);
            hotel1.AjouterClient(client1);



            Console.WriteLine(client1.Nom); 
            Console.WriteLine(client1.NumeroChambre);
            Console.WriteLine(hotel1.Clients.Count);
        }
    }
}