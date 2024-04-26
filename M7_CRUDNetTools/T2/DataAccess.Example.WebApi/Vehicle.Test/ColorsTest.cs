using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;

namespace Vehicle.Test
{
    [TestFixture]
    public class ColorsTest
    {
        private TestServer server;

        [OneTimeSetUp]
        public void Setup()
        {
            this.server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}