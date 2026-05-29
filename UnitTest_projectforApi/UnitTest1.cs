using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Testing;
namespace UnitTest_projectforApi
{
    public class UnitTest1
    {
        [Fact]
        public async Task allstudent()
        {
           var factory = new WebApplicationFactory<Program>();
            var client = factory.CreateClient();
            var response = await client.GetAsync("/api/allstudents");
            Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(200, (int)response.StatusCode);
        }

        [Theory]
        [InlineData(1,200)]
        [InlineData(7, 200)]
        [InlineData(6, 200)]
        [InlineData(10, 200)]
        [InlineData(12, 200)]
        
        public async Task GetByIdTest(int id, int expected)
        {
            var factory = new WebApplicationFactory<Program>();
            var client = factory.CreateClient();
            var response = await client.GetAsync("/api/student/2");
           // Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(expected, (int)response.StatusCode);
        }

        [Theory]
        [InlineData(1, 200)]
        [InlineData(7, 200)]
        [InlineData(6, 200)]
        [InlineData(10, 200)]
        [InlineData(8, 200)]
        public async Task GetNameByIdTest(int id, int expected)
        {
            var factory = new WebApplicationFactory<Program>();
            var client = factory.CreateClient();
            var response = await client.GetAsync("/api/studentnamebyid/2");
            Assert.Equal(System.Net.HttpStatusCode.OK, response.StatusCode);
            Assert.Equal(expected, (int)response.StatusCode);
        }
    }
}