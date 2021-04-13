using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_House
{
    class Basement : IPart // створюємо фундамент
    {
        public enum EnumBasement
        {
            tape = 1, // стрічковий фундамент
            collective, // збірний
            columnar, // стовпчастий
            solid, // суцільний
            welded, // зварний
        }
        public Basement(/*EnumBasement enumBasement*/ /*= EnumBasement.tape*/) // створюємо фундамент
        {
            EnumBasement enumBasement;
            Console.WriteLine("Choose the type of foundation");
            Console.WriteLine("1 - tape,\n2 - collective,\n3 - columnar,\n4 - solid,\n5 - welded.");
            int choose = int.Parse(Console.ReadLine());
            if (choose == 1)
            {
                enumBasement = EnumBasement.tape;
                this.enumBasement = enumBasement;
            }
            else if (choose == 2)
            {
                enumBasement = EnumBasement.collective;
                this.enumBasement = enumBasement;
            }
            else if (choose == 3)
            {
                enumBasement = EnumBasement.columnar;
                this.enumBasement = enumBasement;
            }
            else if (choose == 4)
            {
                enumBasement = EnumBasement.solid;
                this.enumBasement = enumBasement;
            }
            else if (choose == 5)
            {
                enumBasement = EnumBasement.welded;
                this.enumBasement = enumBasement;
            }
            else
            {
                Console.WriteLine("You have chosen the wrong number!!!");
            }
        }
        public EnumBasement enumBasement { get; set; }

        public string Name { get; set; } = "Basement";

        public void Build()
        {
            Console.WriteLine($"Build the {this.Name}, type: {this.enumBasement}");
        }
    }
    class Walls : IPart // створюємо стіни
    {
        public string Name { get; set; } = "Wall";
        public void Build()
        {
            Console.WriteLine($"Build the {this.Name}");
        }
        public void BuildWalls(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Build the {this.Name} {i+1}.");
            }
        }
    }
    class Door : IPart // створюємо двері
    {
        public enum EnumDoor 
        {
            glass = 1, // скляні двері
            metal, // металеві двері
            wooden, // дерев’яні двері
            profile, // профільні двері
        }

        public EnumDoor enumDoor { get; set; }

        public Door(/*EnumDoor enumDoor = EnumDoor.glass*/)
        {
            EnumDoor enumDoor;
            Console.WriteLine("Choose the type of door.");
            Console.WriteLine("1 - glass,\n2 - metal,\n3 - wooden,\n4 - profile.");
            int choose = int.Parse(Console.ReadLine());
            if (choose == 1)
            {
                enumDoor = EnumDoor.glass;
                this.enumDoor = enumDoor;
            }
            if (choose == 2)
            {
                enumDoor = EnumDoor.metal;
                this.enumDoor = enumDoor;
            }
            if (choose == 3)
            {
                enumDoor = EnumDoor.wooden;
                this.enumDoor = enumDoor;
            }
            if (choose == 4)
            {
                enumDoor = EnumDoor.profile;
                this.enumDoor = enumDoor;
            }
            else
            {
                Console.WriteLine("You have chosen the wrong number!!!");
            }
        }
        public string Name { get; set; } = "Door";

        public void Build()
        {
            Console.WriteLine($"Build the {this.Name}, type: {this.enumDoor}.");
        }
    }
    class Window : IPart // створюємо вікна
    {
        public string Name { get; set; } = "Window";

        public void Build()
        {
            Console.WriteLine($"Build the {this.Name}.");
        }
        public void BuildWindows(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Build the {this.Name} {i + 1}.");
            }
        }
    }
    class Roof : IPart // створюємо дах
    {
        public string Name { get; set; } = "Roof";

        public void Build()
        {
            Console.WriteLine($"Build the {this.Name}.");
        }
    }
}
