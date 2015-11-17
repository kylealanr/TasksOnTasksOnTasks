using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TasksOnTasksOnTasks
{
    public class ConsumerProducerExample
    {
        private BlockingCollection<decimal> _numberCollection;

        public void Start()
        {
            _numberCollection = new BlockingCollection<decimal>();

            // producers
            Task.Factory.StartNew(produce);

            // consumers
            Task.Factory.StartNew(consume);
            Task.Factory.StartNew(consume);
            Task.Factory.StartNew(consume);
        }

        private void produce()
        {
            foreach(var num in randomDecimals(100))
            {
                Thread.Sleep(250);
                _numberCollection.Add(num);
            }
        }

        private void consume()
        {
            foreach(var num in _numberCollection.GetConsumingEnumerable())
            {
                Thread.Sleep(250);
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " | " + num.ToString("$#,##0.00;($#,##0.00);$0.00"));
            }
        }

        private IEnumerable<decimal> randomDecimals(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                yield return Convert.ToDecimal(new Random(i).NextDouble());
            }
        }
    }
}
