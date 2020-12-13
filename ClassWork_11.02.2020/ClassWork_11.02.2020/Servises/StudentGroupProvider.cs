using ClassWork_11._02._2020.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_11._02._2020.Servises
{
    public class StudentGroupProvider
    {
        private SqlConnection _connection;

        public StudentGroupProvider(SqlConnection connection)
        {
            _connection = connection;
        }


        public List<StudentGroup> GetAllWhichGroups()
        {
            var result = new List<StudentGroup>();

            try
            {
                _connection.Open();

                var cmd = new SqlCommand(@"
                                            SELECT 
                                                [Groups].[id], 
                                                [Groups].[name], 
                                                [Groups].[specialty_id], 
                                                [Groups].[numbersOfStudents], 
                                                [Specialty].[id], 
                                                [Specialty].[code], 
                                                [Specialty].[name]
                                            FROM
                                                [Groups]
                                            LEFT JOIN
                                                [Specialty]
                                            ON 
                                                [Groups].[specialty_id] = [Specialty].[id]
                                            WHERE
                                                [Groups].[isDeleted] = 'False'
                                            AND
                                                [Specialty].[isDeleted] = 'False'
                                            ", _connection);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var group = new StudentGroup
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Specialty_id = reader.GetInt32(2),
                            NumberOfStudents = reader.GetInt32(3),
                            Specialty = new Specialty
                            {
                                Id = reader.GetInt32(4),
                                Code = reader.GetString(5),
                                Name = reader.GetString(6)
                            }
                        };
                        result.Add(group);
                    }
                }
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }
        public bool Update(int id, StudentGroup updateData)
        {
            var result = false;

            try
            {
                _connection.Open();
                var cmd = new SqlCommand(@"
                                            UPDATE [Groups]
                                            SET
                                                [name] = @Name, 
                                                [specialty_id] = @Specialty_id, 
                                                [numbersOfStudents] = @NumbersOfStudents
                                            WHERE
                                                [Id] = @Id
                                            ", _connection);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", updateData.Name);
                cmd.Parameters.AddWithValue("@Specialty_id", updateData.Specialty_id);
                cmd.Parameters.AddWithValue("@NumbersOfStudents", updateData.NumberOfStudents);

                result = cmd.ExecuteNonQuery() > 0;
            }
            finally
            {
                _connection.Close();
            }

            return result;
        }

        public bool Add(StudentGroup addData)
        {
            var result = false;
            try
            {
                _connection.Open();
                var cmd = new SqlCommand(@"
                                            INSERT INTO [Groups]
                                                (name, specialty_id, numbersOfStudents)
                                            VALUES
                                                (@Name, @Specialty_id, @NumbersOfStudents)
                                            ", _connection);
                cmd.Parameters.AddWithValue(@"Name", addData.Name);
                cmd.Parameters.AddWithValue(@"Specialty_id", addData.Specialty_id);
                cmd.Parameters.AddWithValue(@"NumbersOfStudents", addData.NumberOfStudents);

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
                                            UPDATE [Groups]
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
