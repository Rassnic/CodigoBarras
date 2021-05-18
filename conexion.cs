using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETIQUETADO_ARTICULOS
{
    class conexion
    {
        //palki connection
       private string connectionString = @"Data Source=;Initial Catalog=;Persist Security Info=True;User ID=sa;Password=";
                
       
        public SqlConnection connection = new SqlConnection();

        public object Connection { get; internal set; }

        private void connect()
        {
            connection = new SqlConnection(connectionString);
        }

        public conexion()
        {
            connect();
        }

        public SqlConnection getCon()
        {
            return connection;
        }


    }
}
