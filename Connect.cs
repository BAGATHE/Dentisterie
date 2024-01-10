using System;
using Npgsql;

namespace Dentiste
{
    public class Connect
    {
        public NpgsqlConnection DbConnect(string baseConnection)
        {
            if (baseConnection == null)
            {
                throw new ArgumentException("Le paramètre base ne peut pas être null");
            }

            NpgsqlConnection con = null;
            string connectionString = "";

            if (baseConnection.Equals("postgres"))
            {
                // Ajustez les détails de la chaîne de connexion en fonction de votre configuration PostgreSQL
                connectionString = "Host=localhost;Port=5432;Database=dentiste;Username=postgres;Password=postgresl2;";
            }

            if (!string.IsNullOrEmpty(connectionString))
            {
                con = new NpgsqlConnection(connectionString);
            }

            return con;
        }
    }
}
