using ClassWork_11._02._2020.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_11._02._2020.Servises
{
    public class SpecialtyProvider
    {
        private SqlConnection _connection;
        public SpecialtyProvider(SqlConnection connection)
        {
            _connection = connection;
        }

        public List<Specialty> GetAllSpecialties() 
        {
            var result = new List<Specialty>();

            try
            {
                _connection.Open();

                var cmd = new SqlCommand(@"
                                            SELECT
                                                [id],
                                                [code],
                                                [name]
                                            FROM
                                                [Specialty]
                                            WHERE
                                                [isDeleted] = 'False'
                                            ", _connection);
                using(var reader = cmd.ExecuteReader()) 
                {
                    while (reader.Read()) 
                    {
                        var specialty = new Specialty
                        {
                            Id = reader.GetInt32(0),
                            Code = reader.GetString(1),
                            Name = reader.GetString(2)
                        };
                        result.Add(specialty);
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }
        public bool Update(int id, Specialty updateData) 
        {
            var result = false;

            try
            {
                _connection.Open();
                var cmd = new SqlCommand(@"
                                            UPDATE [Specialty]
                                            SET
                                                [code] = @Code,
                                                [name] = @Name
                                            WHERE
                                                [id] = @Id
                                            ", _connection);
                cmd.Parameters.AddWithValue("@Code", updateData.Code);
                cmd.Parameters.AddWithValue("@Name", updateData.Name);
                cmd.Parameters.AddWithValue("@Id", id);


                result = cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }

        public bool Add(Specialty addData) 
        {
            var result = false;
            try
            {
                _connection.Open();
                var cmd = new SqlCommand(@"
                                            INSERT INTO [Specialty]
                                                ([code], [name])
                                            VALUES
                                                (@Code, @Name)
                                            ", _connection);
                cmd.Parameters.AddWithValue(@"Code",addData.Code);
                cmd.Parameters.AddWithValue(@"Name",addData.Name);

                result = cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }
            return result;
        }
        public bool Delete(int id)
        {
            var result = false;

            try
            {
                _connection.Open();
                var cmd = new SqlCommand(@"
                                            UPDATE [Specialty]
                                            SET
                                                [isDeleted] = 'True'
                                            WHERE
                                                [id] = @Id
                                            ", _connection);
                cmd.Parameters.AddWithValue("@id", id);

                result = cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }
    }
}
