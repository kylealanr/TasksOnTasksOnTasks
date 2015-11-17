using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksOnTasksOnTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            new ConsumerProducerExample().Start();

            while (true)
            {
                if(Console.ReadLine() == "exit")
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
