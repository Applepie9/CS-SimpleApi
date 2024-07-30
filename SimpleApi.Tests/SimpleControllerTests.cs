using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;

namespace SimpleApi.Tests
{
    public class SimpleControllerTests : IClassFixture<WebApplicationFactory<SimpleApi.Startup>>
    {
        private readonly WebApplicationFactory<SimpleApi.Startup> _factory;

        public SimpleControllerTests(WebApplicationFactory<SimpleApi.Startup> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task Get_ReturnsHelloWorld()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/simple");

            if (!response.IsSuccessStatusCode)
            {
                var errorResponseString = await response.Content.ReadAsStringAsync(); // Renamed variable
                Assert.True(false, $"Failed with status code {response.StatusCode}, response: {errorResponseString}");
            }

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            Assert.Equal("Hello, World!", responseString);
        }
    }
}
