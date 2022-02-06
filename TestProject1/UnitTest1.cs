using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinFormsApp1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Repository repository = new Repository();

            bool rc = repository.Open();
            Assert.IsTrue(rc);

            //if connection is not closed, testhost.exe does not terminate
            //and holds test dlls failing build

            //rc = repository.Close();
            //Assert.IsTrue(rc);
        }
    }
}