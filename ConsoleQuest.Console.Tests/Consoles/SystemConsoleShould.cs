using ConsoleQuest.Console.Consoles;
using ConsoleQuest.Console.Data;
using NUnit.Framework;
using Shouldly;

namespace ConsoleQuest.Console.Tests.Consoles
{
    public class SystemConsoleShould
    {
        [Test]
        public void ReturnLastDataQueued()
        {
            var console = new SystemConsole();
            var data = new ConsoleData("Test Data");

            console.QueueData(data);

            console.GetLast().ShouldBe(data);
        }
    }
}