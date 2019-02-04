using Domain.Interfaces;
using Moq;
using Service.Services;
using System;
using Xunit;

namespace Test
{
    public class UnitTest1
    {
        Mock<IGameResultRepository> gameResultRepository = new Mock<IGameResultRepository>();
        GameResultService service
        {
            get
            {
                return GetService();
            }
        }

        [Fact]
        public void Test1()
        {

        }

        private GameResultService GetService()
        {
            return new GameResultService(gameResultRepository.Object);
        }
    }
}
