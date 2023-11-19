using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Marcketplace
{
    public class DataAccessLayer
    {
        private readonly string ConnectionString;

        public DataAccessLayer(string connectionString)
        {
            this.ConnectionString = connectionString;
        }



        public DataTable GetClientes()
        {
            using (OleDbConnection connection = new OleDbConnection(ConnectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand("SELECT * FROM Clientes", connection))
                {
                    DataTable dataTable = new DataTable();
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                    return dataTable;
                }
            }
        }
    }

}