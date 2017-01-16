using System;
using MySql.Data.MySqlClient;

class MonSql
{
    private MySqlConnection connection;
    private string server;
    private string database;
    private string uid;
    private string password;

    //Constructeur

    public MonSql()
    {
        Initialize();
    }

    public MonSql(string anyconnection)
    {
        connection = new MySqlConnection(anyconnection);
    }

    //Initialisation des paramètres de connexion

    private void Initialize()

    {
        server = "localhost";
        database = "mabase";
        uid = "username";
        password = "mm";
        string connectionString;

        connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        connection = new MySqlConnection(connectionString);

    }

    //open

    private bool OpenConnection()
    {
        try
        {
            connection.Open();
            return true;
        }

        catch (Exception e)
        {
            return false;
        }
    }

    //Close

    public bool CloseConnection()
    {
        try
        {
            connection.Close();
            return true;
        }

        catch (Exception e)
        {
            return false;
        }
    }

    //Insert

    public void Insert(string nom, string prenom, string email)

    {
        try
        {
            OpenConnection();
            MySqlCommand DbCommand = new MySqlCommand("INSERT INTO utilisateur VALUES(@nom,@prenom,@email)", connection);

            DbCommand.Parameters.AddWithValue("@nom", nom);
            DbCommand.Parameters.AddWithValue("@prenom", prenom);
            DbCommand.Parameters.AddWithValue("@email", email);
            DbCommand.Prepare();

            DbCommand.ExecuteNonQuery();

            CloseConnection();
        }

        catch (Exception e)
        {
            MessageBox.Show(e.Message);
            CloseConnection();
        }
    }

    //Update

    public void Update(string nomOld, string nomNew)

    {
        try
        {
            OpenConnection();
            MySqlCommand DbCommand = new MySqlCommand("UPDATE utilisateur SET nom = '@nomNew' WHERE nom = @nomOld", connection);

            DbCommand.Parameters.AddWithValue("@nomNew", nomNew);
            DbCommand.Parameters.AddWithValue("@nomOld", nomOld);
            DbCommand.Prepare();

            DbCommand.ExecuteNonQuery();

            CloseConnection();
        }

        catch (Exception e)
        {
            MessageBox.Show(e.Message);
            CloseConnection();
        }
    }

    //Delete

    public void Delete(string nom)

    {
        try
        {
            OpenConnection();
            MySqlCommand DbCommand = new MySqlCommand("DELETE FROM utilisateur WHERE nom = @nom", connection);

            DbCommand.Parameters.AddWithValue("@nom", nom);
            DbCommand.Prepare();

            DbCommand.ExecuteNonQuery();

            CloseConnection();
        }

        catch (Exception e)
        {
            MessageBox.Show(e.Message);
            CloseConnection();
        }
    }

    //Select

    public MySqlDataReader Select(string nom)

    {
        try
        {
            OpenConnection();
            MySqlCommand DbCommand = new MySqlCommand("SELECT * FROM utilisateur WHERE nom=@nom", connection);

            DbCommand.Parameters.AddWithValue("@nom", nom);
            DbCommand.Prepare();

            MySqlDataReader DbReader = DbCommand.ExecuteReader();
            return DbReader;
        }

        catch (Exception e)
        {
            MessageBox.Show(e.Message);
            CloseConnection();
            return null;
        }
        //Retourne une chaine resultat de la requête mais au final on renverra de quoi traiter le résultat de la requête, le type retourné ne sera donc pas une chaîne

    }

    //Count

    public MySqlDataReader Count(string param)

    {
        try
        {
            OpenConnection();
            MySqlCommand DbCommand = new MySqlCommand("SELECT COUNT() FROM utilisateur WHERE nom=@param", connection);

            DbCommand.Parameters.AddWithValue("@param", param);
            DbCommand.Prepare();

            MySqlDataReader DbReader = DbCommand.ExecuteReader();
            return DbReader;
        }

        catch (Exception e)
        {
            MessageBox.Show(e.Message);
            CloseConnection();
            return null;
        }
    }

}
