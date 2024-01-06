using Connection;
using Npgsql;

namespace Dentiste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clickButton(object sender, EventArgs e)
        {
 
         string baseConnection = "postgres"; // Remplacez par la valeur appropriée
         Connect connect = new Connect();
         NpgsqlConnection connection = connect.DbConnect(baseConnection);

         // Vérifier si la connexion n'est pas null
         if (connection != null)
         {
             try
             {
                 // Ouvrir la connexion
                 connection.Open();
                 
                 // Afficher le statut de la connexion
                    MessageBox.Show($"État de la connexion : {connection.State}", "MEss", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Fermer la connexion une fois les opérations terminées
                    connection.Close();
             }
             catch (Exception ex)
             {
                    MessageBox.Show($"Erreur : {ex.Message}", "MEss", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             finally
             {
                 // Assurez-vous de fermer la connexion même en cas d'exception
                 if (connection != null && connection.State == System.Data.ConnectionState.Open)
                 {
                     connection.Close();
                 }
             }
         }
         else
         {
                MessageBox.Show("La connexion est null. Impossible de se connecter à la base de données.", "MEss", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
