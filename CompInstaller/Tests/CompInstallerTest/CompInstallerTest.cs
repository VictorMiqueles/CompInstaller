using CompInstaller;

namespace CompInstallerTest
{
    public class CompInstallerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CurrentDirectoryTest()
        {
            // Arrange
            string dir = "C:\\CompInstaller";
            Directory.SetCurrentDirectory(dir);

            string expected = dir;

            // Act
            string actual = Directory.GetCurrentDirectory();

            // Assert
            Assert.AreEqual(expected, actual);

        }
    }
}