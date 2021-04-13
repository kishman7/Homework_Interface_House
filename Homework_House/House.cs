using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_House
{
    class House
    {
        //Basement basement = new Basement(/*Basement.EnumBasement.collective*/);
        //List <Walls> walls = new List<Walls>();
        //Door door = new Door();
        //List<Window> windows = new List<Window>();
        //Roof roof = new Roof();
        //public House(Basement basement, List<Walls> walls, Door door, List<Window> windows, Roof roof)
        //{
        //    this.basement = basement;
        //    this.walls = walls;
        //    this.door = door;
        //    this.windows = windows;
        //    this.roof = roof;
        //}
        //public void Build()
        //{
        //    Console.WriteLine($"Build {basement}");
        //}

        public void PrintHouse()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 1; j <= 9 - i; j++)
                    Console.Write(" ");
                for (int j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 17; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        public void PrintHouse2()
        {
            string domik = @"
                           (   )
                          (    )
                           (    )
                          (    )
                            )  )
                           (  (                  /\
                            (_)                 /  \  /\
                    ________[_]________      /\/    \/  \
           /\      /\        ______    \    /   /\/\  /\/\
          /  \    //_\       \    /\    \  /\/\/    \/    \
   /\    / /\/\  //___\       \__/  \    \/
  /  \  /\/    \//_____\       \ |[]|     \
 /\/\/\/       //_______\       \|__|      \
/      \      /XXXXXXXXXX\                  \
        \    /_I_II  I__I_\__________________\
               I_I|  I__I_____[]_|_[]_____I
               I_II  I__I_____[]_|_[]_____I
               I II__I  I     XXXXXXX     I
            ~~~~~'   '~~~~~~~~~~~~~~~~~~~~~~~~";

            Console.WriteLine(domik);
        }
    }
}
