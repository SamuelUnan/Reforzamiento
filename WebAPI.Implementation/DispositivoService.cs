using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data.Common;
using WebAPI.Interface;
using WebAPI.Model;

namespace WebAPI.Implementation
{
    public class DispositivoService : IDispositivoService
    {
        private IConfiguration _configuration;
        public string connectionString = "";
        public DispositivoService(IConfiguration configuration) 
        {
            _configuration = configuration;
            connectionString = _configuration.GetConnectionString("DatabaseConnection");

        }
        public DispositivosEntities Add(DispositivosEntities dispositivos)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("INSERT INTO CatDispositivo (DispositivoNombre) VALUES (@Name)", connection);
                command.Parameters.AddWithValue("@Name", dispositivos.DispositivoNombre);
                connection.Open();
                command.ExecuteNonQuery();
            }
            return dispositivos;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<DispositivosEntities> GetALL()
        {
            throw new NotImplementedException();
        }

        public DispositivosEntities GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(DispositivosEntities dispositivos)
        {
            throw new NotImplementedException();
        }
    }
}
