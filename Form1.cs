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
 
         string baseConnection = "postgres"; // Remplacez par la valeur appropri�e
         Connect connect = new Connect();
         NpgsqlConnection connection = connect.DbConnect(baseConnection);

         // V�rifier si la connexion n'est pas null
         if (connection != null)
         {
             try
             {
                 // Ouvrir la connexion
                 connection.Open();
                 
                 // Afficher le statut de la connexion
                    MessageBox.Show($"�tat de la connexion : {connection.State}", "MEss", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Fermer la connexion une fois les op�rations termin�es
                    connection.Close();
             }
             catch (Exception ex)
             {
                    MessageBox.Show($"Erreur : {ex.Message}", "MEss", MessageBoxButtons.OK, MessageBoxIcon.Information);
             }
             finally
             {
                 // Assurez-vous de fermer la connexion m�me en cas d'exception
                 if (connection != null && connection.State == System.Data.ConnectionState.Open)
                 {
                     connection.Close();
                 }
             }
         }
         else
         {
                MessageBox.Show("La connexion est null. Impossible de se connecter � la base de donn�es.", "MEss", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
