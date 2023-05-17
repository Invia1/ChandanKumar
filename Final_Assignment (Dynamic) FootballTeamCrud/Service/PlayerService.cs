using System;
using FootballTeamApp.Models;
using System.Collections.Generic;
using FootballTeamApp.Functionality;

namespace FootballTeamApp.Service
{
    public class PlayerService:IPlayerOperation
    {
        List<Player> objList=new List<Player>();
        public  int createPlayer()
        {
            Console.Write("Enter Player Id:-");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Player Name:-");
            string name=Console.ReadLine();
            Console.Write("Enter Player Age:-");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Player State:-");
            string state = Console.ReadLine();
            Console.Write("Enter Player MobNo:-");
            int mobno = Convert.ToInt32(Console.ReadLine());
            objList.Add(new Player(id, name, age, state, mobno)); 
            
            Console.WriteLine("Player SuccessFully Added in List");
            return 1;
        }
        public  List<Player> GetPlayersList() 
        {
            return objList;
        }
        public  void removePlayer()
        {
            Console.WriteLine("Enter Id for remove player in the Football Team");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (Player p in objList)
            {
                if (p.Id == id)
                {
                    objList.Remove(p);

                    Console.WriteLine("Your Data is Successully Deleted");
                    return;
                }
            }
            Console.WriteLine("Player is not Available in the List");
        }
        public void updatePlayer()
        {
            Console.WriteLine("Enter Id for update player in the Football Team");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (Player p in objList)
            {
                if (p.Id == id)
                {
                    Console.WriteLine("Enter New Name Of Player");
                    p.Name = Console.ReadLine();
                    Console.WriteLine("Enter New State Of Player");
                    p.state = Console.ReadLine();
                    Console.WriteLine("Enter New Age Of Player");
                    p.Age =Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Enter New ContactNo Of Player");
                    p.MobNo = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine("Your Data is Successully Updated");
                    return;
                }
            }
            Console.WriteLine("Player is not Available in the List");
        }
        public void searchPlayer()
        {
            Console.WriteLine("Enter Id for Search player in the Football Team");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (Player p in objList)
            {
                if (p.Id == id)
                {
                    Console.WriteLine("Player Id="+p.Id+"  "+"Player Name="+p.Name+"  "+"Player State="+p.state+"  "+"Player Age="+p.Age+"  "+"Player MobNo="+p.MobNo);
                    return;
                }
            }
            Console.WriteLine("Player is not Available in the List");
        }
        public void fetchAll()
        {
            
            foreach (Player p in objList)
            {
                Console.WriteLine("Show All Data in the List");
                Console.WriteLine("Player Id=="+p.Id+"\t"+"Player Name=="+ p.Name+"\t"+"Player Age=="+p.Age+"\t"+"Player State=="+p.state+"\t"+"Player MobNo=="+p.MobNo);
                Console.WriteLine();
                return;
            }
            Console.WriteLine("List Is Empty Please add the after that show:-");
        }

    }
}
