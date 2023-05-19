using System;
using FriendAppCustomised.Models;
using FriendAppCustomised.Service;

namespace FriendAppCustomised.UserInterface
{
    public class MainApplication
    {
        public static void Main()
        {
            void display()
            {
                Console.WriteLine("1:Add Friend in List");
                Console.WriteLine("2:Show All Friend in List");
                Console.WriteLine("3:Remove Friend in List");
                Console.WriteLine("4:Update Friend in List");
                Console.WriteLine("5:Search Friend in List");
                Console.WriteLine("6:Insert in Particular Index Friend in List");
            }
          
            FriendService friendService = new FriendService();
            bool check = true;
            while(check)
            {
                display();
                Console.WriteLine("Enter your choice:-");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                            friendService.createFriend();
                            break;
                    case 2:
                        {
                            friendService.getFriendList();
                            break;
                        }
                    case 3:
                        
                            friendService.removeFriend();
                            break;

                    case 4:
                        
                            friendService.updateFriend();
                            break;
                    case 5:
                       
                            friendService.searchFriend();
                            break;
                    case 6:
                            friendService.insertFriend();
                            break;
                    case 7:
                        check =false; break; 

                    default:
                        Console.WriteLine("Enter wrong Choice:");
                        break;
                }
                 
                       
                
            }
        }
    }
}
