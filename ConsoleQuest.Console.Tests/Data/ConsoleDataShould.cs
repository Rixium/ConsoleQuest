using ConsoleQuest.Console.Data;
using NUnit.Framework;
using Shouldly;

namespace ConsoleQuest.Console.Tests.Data
{
    public class ConsoleDataShould
    {

        [Test]
        public void WriteDataToItself()
        {
            var expectedString = "Test Data";
            var data = new ConsoleData(expectedString);
            
            data.Read().ShouldBe(expectedString);
        }

        [Test]
        public void NotThrowWhenReadingEmptyData()
        {
            var data = new ConsoleData(null);

            Should.NotThrow(data.Read);
        }

        [Test]
        public void AllowDataToBeOverwritten()
        {
            var initialData = "Test Data";
            var data = new ConsoleData(initialData);
            var overwriteData = "Overwrite Data";
            
            data.Write(overwriteData);
            
            data.Read().ShouldNotBe(initialData);
            data.Read().ShouldBe(overwriteData);
            
        }
    }
}