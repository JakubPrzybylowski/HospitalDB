using HospitalDatabase.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace HospitalDatabase.Repositories
{
    public class HospitalRepository : IHospitalRepository
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString;

        public void CreateHospital(Hospital hospital)
        {
            throw new NotImplementedException();
        }

        public void DeleteHospital(int id)
        {
            throw new NotImplementedException();
        }

        public Hospital GetHospital(int id)
        {
            throw new NotImplementedException();
        }

        public void GetHospitals()
        {
            throw new NotImplementedException();
        }

        public List<Hospital> UpdateHospital(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = connection.CreateCommand())
            {
                var hospital = GetHospital(id);
                command.CommandText = "UPDATE Hospital SET Name = @name where id = @id";

                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@id", myId);

                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
