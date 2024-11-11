using Infraestructures.ConnectionManager;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructures.Repository.Base
{
    public abstract class RepositoryBase
    {
        public OleDbConnection _connection;

        protected RepositoryBase()
        {
            DBConnection connection = new DBConnection("(local)", "Northwind", "MSOLEBSQL.1");
            _connection = connection.Open();
        }

        public abstract string ProcessRequest();
    }
}
