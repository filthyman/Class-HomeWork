using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_11._02._2020.Servises
{
    public class StorageContext
    {
        public SpecialtyProvider Specialty { get; }

        public StudentGroupProvider Group { get; }

        public StorageContext()
        {
            var connection = Connection();
            Specialty = new SpecialtyProvider(connection);
            Group = new StudentGroupProvider(connection);
        }

        public SqlConnection Connection() 
        {
            var sqlConnection = new SqlConnectionStringBuilder()
            {
                DataSource = @"DESKTOP-OTQ2DC3",
                IntegratedSecurity = true,
                InitialCatalog = "GROUPSTUDENTSBD"
            };
            return new SqlConnection(sqlConnection.ToString());
        }
    }
}
