using NUnit.Framework;

namespace PlaywrightBase.Core.Infastructure
{
    [Parallelizable(scope: ParallelScope.All)]
    [TestFixture]
    public abstract class BaseTest
    {
        public static TestContext TestContext => TestContext.CurrentContext;

        [OneTimeSetUp]
        public void OneTimeSetUp() 
        {
            Configure();
            Console.WriteLine("One Time Setup");
        }

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Do Base Test Setup");
        }

        [TearDown]
        public void TearDown() { }

        [OneTimeTearDown]
        public void OneTimeTearDown() { }

        private void Configure() 
        {
            
        }
    }
}
