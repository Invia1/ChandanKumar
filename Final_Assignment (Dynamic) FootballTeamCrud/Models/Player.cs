using System;

namespace FootballTeamApp.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }    
        public string state { get; set; }

        public long MobNo { get; set; }
        public Player(int id, string name, int age, string state, long mobNo)
        {
           this. Id = id;
           this. Name = name;
           this. Age = age;
           this.state = state;
           this.MobNo = mobNo;
        } 
    }


}
