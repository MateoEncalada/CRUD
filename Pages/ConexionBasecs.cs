using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Pages
{
    public class ConexionBasecs
    {

        private static ConexionBasecs instance;
        private readonly SqlConnection connection;

        private ConexionBasecs()
        {
            string connectionString = "Data Source=(local); Initial Catalog=Facturacion; trusted_connection=yes; TrustServerCertificate=True;";
            connection = new SqlConnection(connectionString);
        }

        public static ConexionBasecs Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConexionBasecs();
                }
                return instance;
            }
        }

        public SqlConnection GetConnection()
        {
            return connection;
        }
    }
}
