using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_House
{
    class TeamLeader : IWorker
    {
        public string Name { get; set; }
        public TeamLeader(string name)
        {
            Name = name;
        }
        public override string ToString()
        { 
            string  result = $"TeamLeader: {Name}";
            return result;
        }
        public void Print()
        {
            Console.WriteLine($"TeamLeader: {Name}");
        }
        public void Work()
        {
            Console.WriteLine($"TeamLeader {Name} is generates a report!");
        }

        public bool start_huose = true;
        public bool Start()
        {
            start_huose = true;
            Console.WriteLine($"TeamLeader {Name} start a building house!");
            return start_huose;
        }
    }
}
