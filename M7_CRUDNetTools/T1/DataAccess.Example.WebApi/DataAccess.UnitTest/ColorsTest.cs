using NUnit.Framework; 
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using DataAccess.Example.EntityFramework;
using Microsoft.Extensions.DependencyInjection;


namespace DataAccess.UnitTest
{
    [TestFixture]
    public class ColorsTest
    {
        protected TestServer server;

        [OneTimeSetUp]
        public void Setup()
        {
            this.server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
        }

        [Test]
        public void GetAllColors_Test()//como no esta implementado el metodo marca el error
        {
            var repository = server.Host.Services.GetService<IVehiclesDataManager>();

            var list = repository.GetAll();

            Assert.Pass();
        }
    }
}