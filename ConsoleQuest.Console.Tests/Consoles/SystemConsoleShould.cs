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

        [Test]
        public void HaveAnEmptyQueueWhenFlushed()
        {
            var console = new SystemConsole();
            var data = new ConsoleData("Test Data");
            
            console.BufferData(data);
            console.Flush();
            
            console.GetBuffered().ShouldBeEmpty();
        }

        [Test]
        public void ShouldNotThrowWhenFlushingEmptyQueue()
        {
            var console = new SystemConsole();

            Should.NotThrow(console.Flush);
        }
    }
}