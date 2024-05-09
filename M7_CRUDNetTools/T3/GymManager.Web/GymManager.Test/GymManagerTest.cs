using GymManager.ApplicationServices.Members;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;

namespace GymManager.Test
{
    [TestFixture]
    public class GymManagerTest
    {
        protected TestServer server;
        [OneTimeSetUp]
        public void Setup()
        {
            this.server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
        }

        [Test]
        public void GymManagerTest1()
        {
            var repository = server.Host.Services.GetService<IMembersAppService>();

            var list = repository.GetMembersAsync();

            Assert.Pass();
        }

        [OneTimeTearDownAttribute]
        public void TearDown()
        {
            this.server.Dispose();
        }
    }
}