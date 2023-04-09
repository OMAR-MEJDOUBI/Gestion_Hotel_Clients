namespace Gestion_Hotel_Clients
{
    internal class Mains
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Donnez le nom du Client svp : ");
            string nomClient = Console.ReadLine();

            Console.WriteLine("Donnez le prenom du Client svp : ");
            string prenomClient = Console.ReadLine();

            Console.WriteLine("Donnez le courriel du Client svp : ");
            string courrielClient = Console.ReadLine();

            Console.WriteLine("Donnez le numero de carte credit du Client svp : ");
            string numCarteCreditClient = Console.ReadLine();

            Console.WriteLine("Donnez le numero du chambre du Client svp : ");
            int numeroChambre = Int32.Parse(Console.ReadLine());


            Client client2 = new Client(nomClient, prenomClient, courrielClient, numCarteCreditClient, numeroChambre);

            Console.WriteLine(client2);

        }
        
    }
}