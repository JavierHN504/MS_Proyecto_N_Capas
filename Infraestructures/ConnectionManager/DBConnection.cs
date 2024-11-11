using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructures.ConnectionManager
{
    public class DBConnection
    {
        private OleDbConnection _connection;
        private string _stringConnection;
        
        public DBConnection(string DataSource, string DataBase, string Provider)
        {
            _stringConnection = $"Provider={Provider}; Data Source={DataSource}; Initial Catalog={DataBase} Integrate Security=SSPI; Trust Server Certificate=False";
        }

        public void CreateConnection()
        {
            _connection = new OleDbConnection(_stringConnection);
        }

        public OleDbConnection Open()
        { 
            if(_connection == null ) return null;
            if(_connection.State == System.Data.ConnectionState.Open) return _connection;
            else
            {
                _connection.Open();
                return _connection;
            }
        
        }

        public void Close()
        {
            _connection.Close();
        }

    }
}
