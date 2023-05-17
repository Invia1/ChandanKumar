using FootballTeamApp.Models;
using System;


namespace FootballTeamApp.Functionality
{
    public interface IPlayerOperation
    {
        int createPlayer();
        List<Player> GetPlayersList();
        void removePlayer();
        void updatePlayer();
        void searchPlayer();
        void fetchAll();
       
    }
}
