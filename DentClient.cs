using System;
using Npgsql;
namespace Dentiste
{
    internal class DentClient
    {
        // Attributs
        private string idDentClient;
        private string idDent;
        private string idClient;
        private int noteIndividuel;

        // Constructeur
        public DentClient(string idDentClient, string idDent, string idClient, int noteIndividuel)
        {
            this.idDentClient = idDentClient;
            this.idDent = idDent;
            this.idClient = idClient;
            this.noteIndividuel = noteIndividuel;
        }
          public DentClient(string idDent, string idClient, int noteIndividuel)
        {
            this.idDent = idDent;
            this.idClient = idClient;
            this.noteIndividuel = noteIndividuel;
        }

         public DentClient(string idDent,int noteIndividuel)
        {
            this.idDent = idDent;
            this.noteIndividuel = noteIndividuel;
        }

        // Getters et Setters
        public string IdDentClient
        {
            get { return idDentClient; }
            set { idDentClient = value; }
        }

        public string IdDent
        {
            get { return idDent; }
            set { idDent = value; }
        }

        public string IdClient
        {
            get { return idClient; }
            set { idClient = value; }
        }

        public int NoteIndividuel
        {
            get { return noteIndividuel; }
            set { noteIndividuel = value; }
        }


        private Connect connectionManager = new Connect();

            public Dent GetDentByID(string id)
{
    Dent dent = null;
    string query = $"SELECT * FROM Dent WHERE idDent='{id}'";

    try
    {
        using (NpgsqlConnection connection = connectionManager.DbConnect("postgres"))
        {
            connection.Open();

            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            using (NpgsqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    dent = new Dent
                    {
                        IdDent = reader.GetString(reader.GetOrdinal("idDent")),
                        Position = Convert.ToInt32(reader.GetDecimal(reader.GetOrdinal("position"))),
                        Emplacement = reader.GetString(reader.GetOrdinal("emplacement"))
                    };
                }
            }
        }
    }
    catch (NpgsqlException e)
    {
        throw e;
    }

    return dent;
}
    }
}
