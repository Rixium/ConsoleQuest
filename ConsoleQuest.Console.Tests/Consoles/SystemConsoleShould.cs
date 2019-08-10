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

            console.BufferData(data);

            console.GetLastBuffered().ShouldBe(data);
        }

        [Test]
        public void EmptyBufferOnReset()
        {
            var console = new SystemConsole();
            var data = new ConsoleData("Test Data");
            
            console.BufferData(data);
            console.ResetBuffer();

            console.GetBuffered().ShouldBeEmpty();
        }

        [Test]
        public void ReturnNullWhenRetrievingLastBufferedWhenNotSet()
        {
            var console = new SystemConsole();
            
            console.GetLastBuffered().ShouldBeNull();
        }
    }
}