using FootballTeamApp.Functionality;
using FootballTeamApp.Models;
using FootballTeamApp.Service;
using System;


namespace FootballTeamApp.UI
{
    public class FootballApp
    {
        public static void Main()
        {
            void display()
            {
                Console.WriteLine("1:-Add Player");
                Console.WriteLine("2:-Remove Player");
                Console.WriteLine("3:-Update Player");
                Console.WriteLine("4:-Search Player");
                Console.WriteLine("5:-FetchAll Player");
            }



            IPlayerOperation es = new PlayerService();
            bool check = true;
            while (check)
            {
                display();
                Console.WriteLine("Select Your Choice what do you want:-");
                int n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        es.createPlayer();
                        break;
                    case 2:
                        es.removePlayer();
                        break;
                    case 3:
                        es.updatePlayer();
                        break;
                    case 4:
                        es.searchPlayer();
                        break;
                    case 5:
                        es.fetchAll();
                        break;
                    case 6:
                        Console.WriteLine("Choice Option:");
                        check = false; break;
                    default:
                        Console.WriteLine("\n\t\t Wrong value enters.....");
                        break;
                }


            }
        }
    }
}
