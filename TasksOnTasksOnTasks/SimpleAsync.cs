using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksOnTasksOnTasks
{
    public class SimpleAsync
    {
        public static async Task<int> AsyncAddition(int x, int y)
        {
            return await Task.Factory.StartNew(() => { return x + y; });
        }
    }
}
