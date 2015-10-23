using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FilmVisningsSystemTests
{
    [TestClass]
    public class FilmFacadeTests
    {
        [TestMethod]
        public void Test_That_Facade_Can_Be_Created()
        {
            MovieFacade facade = new MovieFacade();
            Assert.IsNotNull(facade);
        }
        [TestMethod]
        public void Test_That_SF_Can_Be_Played()
        {
            MovieFacade facade = new MovieFacade();
            IPlayer sfMovie = new SF();
            sfMovie.PlayMovie("Starwars");

        }
        public void Test_That_Netflix_Can_Be_Played()
        {
            MovieFacade facade = new MovieFacade();
            IPlayer netflixMovie = new Netflix();
            netflixMovie.PlayMovie("Starwars Is being play now");

        }
    }
}
