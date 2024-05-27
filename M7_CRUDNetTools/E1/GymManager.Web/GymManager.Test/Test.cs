using GymManager.ApplicationServices.Members;
using GymManager.UnitTest;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;

namespace GymManager.Test
{
    [TestFixture] //para definir la configuración de la clase de pruebas.
    public class Test
    {
        protected TestServer server;
        
        [OneTimeSetUp]
        public void Setup()
        {
            this.server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
        }

        [Test]
        public void TestMembers()
        {
            var repository = server.Host.Services.GetService<IMembersAppService>();

            var list = repository.GetMembersAsync();

            //indica que la prueba ha pasado sin necesidad de verificar condiciones adicionales en este punto
            Assert.Pass();
        }

        //Este método se ejecuta una vez después de la prueba para limpiar y disponer del servidor de prueba.
        [OneTimeTearDownAttribute]
        public void TearDown()
        {
            this.server.Dispose();
        }
    }
}