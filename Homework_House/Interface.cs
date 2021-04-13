using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_House
{
    interface IWorker // інтерфейс працівника
    {
        string Name { get; set; }
        void Work();
    }
    interface IPart // інтерфейс частин будинку
    {
        string Name { get; set; }
        void Build();
    }
}
