using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_House
{
    static class Team
    {
        public static List <Worker> workers = new List <Worker>();
        public static TeamLeader teamLeader;
        //public static Team (List<Worker> workers, TeamLeader teamLeader)  
        //{
        //    this.workers = workers;
        //    this.teamLeader = teamLeader;
        //}
        public static void PrintTeam()
        {
            //Console.WriteLine(teamLeader);
            //string result = default;
            foreach (var item in workers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
