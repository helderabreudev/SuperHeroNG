using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using SuperHeroAPI;
using SuperHeroAPI.Controllers;
using System.Threading.Tasks;
using Xunit;

namespace SuperHeroTests
{
    public class UnitTest1
    {
        [Fact]
        public async void GetHeroes_Returns_The_Correct_Number_Of_Heroes()
        {
            //Arrange
            int count = 5;
            var fakeHeroes = A.CollectionOfDummy<SuperHero>()
            //var dataStore = A.Fake<SuperHeroController>();
            A.CallTo(() => dataStore.GetSuperHeroes()).Returns(Task.FromResult()); 
            var controller = new SuperHeroController();
            // Act
            var actionResult = await controller.GetSuperHeroes();
            // Assert
            var result = actionResult.Result as OkObjectResult;
        }
    }
}