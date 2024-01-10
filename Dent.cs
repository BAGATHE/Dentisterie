using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Dentiste
{
    internal class Dent
    {
        String idDent;
        int position;
        String emplacement;


        public Dent(string idDent, int position, string emplacement)
        {
            this.idDent = idDent;
            this.position = position;
            this.emplacement = emplacement;
        }

          public Dent(string idDent)
        {
            this.idDent = idDent;
        }

    public Dent(){}
        public string IdDent
        {
            get { return idDent; }
            set { idDent = value; }
        }

        public int Position
        {
            get { return position; }
            set { position = value; }
        }

        public string Emplacement
        {
            get { return emplacement; }
            set { emplacement = value; }
        }

        public bool IsCentral()
        {
            return this.position > 6 && this.position < 11;
        }

        public bool IsLateral()
        {
            return (this.position > 0 && this.position < 7) || (this.position > 10 && this.position < 33);
        }




private Connect connectionManager = new Connect();
public Dent GetDentByID(string id)
{
    Dent dent = null;
    string query = $"SELECT * FROM Dent WHERE idDent='{id}'";
    NpgsqlConnection connection = null;

    try
    {
        connection = connectionManager.DbConnect("postgres");
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
    catch (NpgsqlException e)
    {
        throw e;
    }
    finally
    {
        if (connection != null)
        {
            connection.Close();
        }
    }

    return dent;
}




public List<Dent> GetCentral(List<Dent> dents)
{
    List<Dent> dentCentral = new List<Dent>();

    foreach (Dent dent in dents)
    {
        Dent retrievedDent = GetDentByID(dent.IdDent);

        if (retrievedDent != null && retrievedDent.IsCentral())
        {
            dentCentral.Add(retrievedDent);
        }
    }

    return dentCentral;
}


public List<Dent> GetLateral(List<Dent> dents)
{
    List<Dent> dentLateral = new List<Dent>();

    foreach (Dent dent in dents)
    {
        Dent retrievedDent = GetDentByID(dent.IdDent);

        if (retrievedDent.IsLateral())
        {
            dentLateral.Add(retrievedDent);
        }
    }

    return dentLateral;
}





       
    }
}
