using Infraestructures.ConnectionManager;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;
using System.Data.OleDb;

namespace UnitTestProject
{

    [TestClass]
    public class DbConnectionTest
    {

        [TestMethod]
        public void DataBaseConnectionTest()
        {
            DBConnection conn = new DBConnection("(local)", "Northwind", "MSOLEDBSQL.1");
            conn.CreateConnection();
            OleDbConnection newConn = conn.Open();

            Assert.AreEqual(newConn.State, ConnectionState.Open);


        }

        [TestMethod]
        public void  DatabaseClose()
        {
            DBConnection conn = new DBConnection("(local)", "Northwind", "MSOLEDBSQL.1");
            conn.CreateConnection();
            OleDbConnection newConn = conn.Open();
            newConn.Close();

            Assert.AreEqual(newConn.State, ConnectionState.Closed);

        }
    }
}
