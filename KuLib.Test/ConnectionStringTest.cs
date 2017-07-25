using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KuLib.Test
{
    [TestClass]
    public class ConnectionStringTest
    {
        [TestMethod]
        public void BasicTest()
        {
            string connectionString = "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
            ConnectionString connStr = connectionString.AsConnectionString();
            Assert.AreEqual("myServerAddress", connStr.Server);
            Assert.AreEqual("myDataBase", connStr.Database);
            Assert.AreEqual("myUsername", connStr.UserId);
            Assert.AreEqual("myPassword", connStr.Password);
        }
    }
}
