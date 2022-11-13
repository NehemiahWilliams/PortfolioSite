namespace tests
{
    [TestClass]
    public class ArtilceServiceTests
    {
        [TestMethod]
        public Task GetById_ValidId_ReturnsArtileData()
        {
            Assert.Fail();
        }

        [TestMethod]
        public Task GetById_BadId_ReturnsNull()
        {
            Assert.Fail();
        }

        [TestMethod]
        public Task GetPage_NullPageThrowsArgumentNullException()
        {
            Assert.Fail();
        }

        [TestMethod]
        public Task GetPage_HasData_ReturnsPage()
        {
            
        }
        
        
    }
}