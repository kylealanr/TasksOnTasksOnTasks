using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Moq;
using TasksOnTasksOnTasks;

namespace TestsOnTestsOnTests
{
    [TestFixture]
    class SimpleAsyncTest
    {
        [Test]
        public async static Task AsyncAdditionReturnsValue()
        {
            int result = await SimpleAsync.AsyncAddition(2, 3);
            Assert.AreEqual(5, result);
        }
    }
}
