using IntegrationTest;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTestTests
{
    public class HomeControllerIntegrationTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> _factory;
        public HomeControllerIntegrationTests(WebApplicationFactory<Startup> factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("/api/Home")]
        [InlineData("/api/Values")]
        public async Task Should_Receive_Success_Response(string url)
        {
            //Arrange
            var client = _factory.CreateClient();
            //Act
            var response = await client.GetAsync(url);
            //Assert
            response.EnsureSuccessStatusCode();            
            Assert.Equal("application/json; charset=utf-8",
           response.Content.Headers.ContentType.ToString());
        }
    }
    
}
