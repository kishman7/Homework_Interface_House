using System;
using System.Collections.Generic;

namespace Homework_House
{
    class Program
    {
        static void Main(string[] args)
        {
            bool action = true;
            while(action)
            {
                Console.WriteLine("=====MENU=====");
                Console.WriteLine("1.Create a team of workers.");
                Console.WriteLine("2.Building a house.");
                Console.WriteLine("0.Exit.");
                Console.Write("Select a menu item: ");
                int enter = Convert.ToInt32(Console.ReadLine());

                switch (enter)
                {
                    case 1:
                        
                            // Створюємо команду робітників
                            Console.WriteLine("Enter name TeamLeader: ");
                            string name_teamleader = Console.ReadLine();
                            TeamLeader teamLeader = new TeamLeader(name_teamleader); // створюємо бригадира
                            Console.WriteLine("Enter the number workers for the team: ");
                            int number_team = int.Parse(Console.ReadLine());
                            for (int i = 0; i < number_team; i++)
                            {
                                Worker worker = new Worker("Tom"); // створюємо робітника
                                Team.workers.Add(worker); // добавляємо робітника в список
                            }
                            // Виводимо команду робітників з бригадиром
                            Console.WriteLine();
                            Console.WriteLine("Our team."); 
                            //teamLeader.Print();
                            Console.WriteLine(teamLeader);
                            Team.PrintTeam();
                            break;
                        
                    case 2:
                        
                            Console.WriteLine();
                        //teamLeader.start_huose = true;
                        Team.teamLeader.Start(); // тут ламається, бо teamLeader тут null !!!

                        //if (Team.teamLeader.start_huose)
                        //{
                        //    Team.teamLeader.Start();
                        //}
                        Console.WriteLine("Our team start building house!");

                        // Створюємо фундамнт
                        Console.WriteLine("Сreate the foundation!");
                        Basement basement = new Basement();
                        basement.Build();
                        Console.WriteLine();

                        // Створюємо стіни
                        Console.WriteLine("Сreate the walls!");
                        int num_wall = 4; // кількість стін
                        List<Walls> walls = new List<Walls>();
                        for (int i = 0; i < num_wall; i++)
                        {
                            Console.WriteLine($"Add wall {i+1}.");
                            Walls wall = new Walls();
                            walls.Add(wall);
                            Console.ReadKey();
                        }
                        Console.WriteLine($"Build {num_wall} walls!");
                        Console.WriteLine();
                        //foreach (var item in walls)
                        //{
                        //    item.Build();
                        //}

                        // Створюємо двері
                        Console.WriteLine("Сreate the door!");
                        Door door = new Door();
                        door.Build();
                        Console.WriteLine();

                        // створюємо вікна
                        Console.WriteLine("Сreate the windows!");
                        int num_window = 4; // кількість стін
                        List<Window> windows = new List<Window>();
                        for (int i = 0; i < num_window; i++)
                        {
                            Console.WriteLine($"Add window {i + 1}.");
                            Window window = new Window();
                            windows.Add(window);
                            Console.ReadKey();
                        }
                        Console.WriteLine($"Build {num_window} windows!");
                        Console.WriteLine();

                        // створюємо дах
                        Console.WriteLine("Сreate the roof!");
                        Roof roof = new Roof();
                        roof.Build();
                        Console.Clear();

                        Console.WriteLine("==========The house is built=========");
                        //House house = new House(basement, walls, door, windows, roof); 
                        House house = new House(); // створюємо об’єкт будинок
                        basement.Build(); // виводимо фундамент
                        foreach (Walls wall in walls) // виводимо стіни
                        {
                            wall.Build();
                        }
                        door.Build(); // виводимо двері
                        foreach (Window window in windows) // виводимо вікна
                        {
                            window.Build();
                        }
                        roof.Build(); // виводимо дах
                        Console.WriteLine();

                        Console.WriteLine("OUR HOUSE!!!");

                        //house.PrintHouse();
                        house.PrintHouse2();

                        Console.WriteLine();
                        Console.WriteLine();

                        break;
                        
                    case 0:
                        {
                            action = false;
                            break;
                        }
                    default:
                        Console.WriteLine("The menu item entered is incorrect !!!");
                        Console.WriteLine();
                        break;

                }
            }
            


            //Basement basement = new Basement(Basement.EnumBasement.solid);
            //basement.Build();

            //Worker worker1 = new Worker("Tom");
            //Team.workers.Add(worker1);
            //worker1.Work();

            //Walls wall = new Walls();
            //wall.Build();
            //List<Walls> walls = new List<Walls>();
            //walls.Add(wall);

            //Door door = new Door(Door.EnumDoor.wooden);

            //Window window1 = new Window();
            //List<Window> windows = new List<Window>();
            //windows.Add(window1);

            //Roof roof = new Roof();

            //Console.WriteLine(basement);
            //House house = new House(basement, walls, door, windows, roof);

            //house.PrintHouse();
            //house.PrintHouse2();



        }
    }
}
