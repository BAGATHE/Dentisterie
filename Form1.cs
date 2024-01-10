using Npgsql;
using System.Text;

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
            TextBox texbox = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

        }

        private void Validation(object sender, EventArgs e){
    // Collecte des données des champs de texte
    
    List<EtatNify> dB = new List<EtatNify>();
    List<EtatNify> dH = new List<EtatNify>();

    List<EtatNify> dentB = new List<EtatNify>();
    List<EtatNify> dentH = new List<EtatNify>();
    List<EtatNify> allDent= new List<EtatNify>();
    for (int i = 1; i <= 16; i++)
    {
        TextBox dentHaut = Controls.Find("DH_" + i, true).FirstOrDefault() as TextBox;
        TextBox dentBas = Controls.Find("DB_" + i, true).FirstOrDefault() as TextBox;

        if (dentHaut != null && dentBas != null)
        {
               if (int.TryParse(dentBas.Text, out int etatBas) && int.TryParse(dentHaut.Text, out int etatHaut))
            {
                dB.Add(new EtatNify(dentBas.Name, etatBas));
                dH.Add(new EtatNify(dentHaut.Name, etatHaut));
            }
            else
            {
            // Gérer l'erreur de conversion si nécessaire    
            }
        }
    }

    allDent.AddRange(dentH);
    allDent.AddRange(dentB);
    EtatNify etat = new EtatNify();
   dentB = etat.RearrangeOrder(dB);
   dentH = etat.RearrangeOrder(dH);

    // Récupération des valeurs du ComboBox et du champ de texte
    string comboBoxValue = comboBox1.SelectedItem?.ToString();
    string textBox33Value = textBox33.Text;



    // Affichage des données dans un MessageBox
    StringBuilder messageBuilder = new StringBuilder("Donnees du formulaire :\n");

    for (int i = 0; i < 16; i++)
    {
        messageBuilder.AppendLine($"DentBas {i + 1}: {dentB[i].IdDent} - Etat: {dentB[i].Etat}");
    }

    for (int i = 0; i < 16; i++)
    {
        messageBuilder.AppendLine($"DentHaut {i + 1}: {dentH[i].IdDent} - Etat: {dentH[i].Etat}");
    }

    messageBuilder.AppendLine($"comboBox1: {comboBoxValue}");
    messageBuilder.AppendLine($"textBox33: {textBox33Value}");

    MessageBox.Show(messageBuilder.ToString(), "Résultat");
}

        

    }
}
