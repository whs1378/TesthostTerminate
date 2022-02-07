using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.OleDb;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            OleDbConnection connection = new OleDbConnection(
                "Provider = Microsoft.ACE.OLEDB.12.0;" +
                $"Data Source=../../../../Database1.accdb");
            connection.Open();

            //if connection is not closed, testhost.exe does not terminate
            //and holds test dlls failing build

            //connection.Close();

        }
    }
}