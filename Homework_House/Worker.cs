using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_House
{
    class Worker : IWorker
    {
        public string Name { get; set; }
        public Worker(string name)
        {
            Console.WriteLine("Enter name worker: ");
            name = Console.ReadLine();
            Name = name;
        }
        public void Work()
        {
            Console.WriteLine($"Worker {Name} is working.");
        }
        public override string ToString()
        {
            string result = $"Worker: {Name}";
            return result;
        }
        
    }
}
