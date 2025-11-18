using PlaywrightBase.Core.Infastructure;

namespace PlaywrightBase.Web
{
    public class Tests2 : BaseTest
    {

        [SetUp]
        public void TestsSetup()
        {
            Console.WriteLine("Do Tests Setup");
        }

        [TearDown]
        public void Teardown() 
        {
            Console.WriteLine("Do Teardown");
        }

        [Test]
        public void Test1()
        {
            var test = TestContext.CurrentContext.Test.Name;
            Console.WriteLine($"Starting {test}");
            Thread.Sleep(4000);
            Assert.That(true);
            Console.WriteLine($"Finished {test}");
        }

        [Test]
        public void Test2()
        {
            var test = TestContext.CurrentContext.Test.Name;
            Console.WriteLine($"Starting {test}");
            Thread.Sleep(4000);
            Assert.That(true);
            Console.WriteLine($"Finished {test}");
        }
    }
}
