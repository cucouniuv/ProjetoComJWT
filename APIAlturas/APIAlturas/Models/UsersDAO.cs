using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using Dapper;

namespace APIAlturas.Models
{
    public class UsersDAO
    {
        private readonly IConfiguration _configuration;

        public UsersDAO(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public User Find(string userID)
        {
            using (MySqlConnection conexao = new MySqlConnection(
                _configuration.GetConnectionString("exemplojwt")))
            {
                return conexao.QueryFirstOrDefault<User>(
                    "SELECT UserID, AccessKey " +
                    "FROM Users " +
                    "WHERE UserID = @UserID", new { UserID = userID });
            }
        }
    }
}
