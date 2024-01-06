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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void champFormulaire_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }

        private void validation(object sender, EventArgs e)
        {
            // Collecte des donn�es des champs de texte
            string[] textBoxValues = new string[32];

            string[] textBoxName = new string[32];
            for (int i = 1; i <= 32; i++)
            {
                TextBox textBox = Controls.Find("textBox" + i, true).FirstOrDefault() as TextBox;
                if (textBox != null)
                {
                    textBoxValues[i - 1] = textBox.Text;
                    textBoxName[i - 1] = textBox.Name;
                }
            }

            // R�cup�ration des valeurs du ComboBox et du champ de texte
            string comboBoxValue = comboBox1.SelectedItem?.ToString();
            string textBox33Value = textBox33.Text;

            // Affichage des donn�es dans un MessageBox
            string message = "Donn�es du formulaire :\n";
            for (int i = 0; i < 32; i++)
            {
                message += $"{textBoxName[i]}: {textBoxValues[i]}\n";
            }
            message += $"comboBox1: {comboBoxValue}\n";
            message += $"textBox33: {textBox33Value}";

            MessageBox.Show(message, "R�sultat");
        }

        

    }
}
