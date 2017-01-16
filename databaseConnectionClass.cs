using MySql.Data.MySqlClient;

class DataBaseConnect

{

    private MySqlConnection connection;

    private string server;

    private string database;

    private string uid;

    private string password;

 

    //Constructeur

    public DataBaseConnect()

    {

        Initialize();

    }

//Initialisation des paramètres de connexion

    private void Initialize()

    {

        server = "localhost";

        database = "mabase"

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

    }

 

    //Close

    private bool CloseConnection()

    {

    }

 

    //Insert

    public void Insert(string marequete)

    {

    }

 

    //Update

    public void Update(string marequete)

    {

    }

 

    //Delete

    public void Delete(string marequete)

    {

    }

 

    //Select

    public string Select(string marequete)

    {

//Retourne une chaine resultat de la requête mais au final on renverra de quoi traiter le résultat de la requête, le type retourné ne sera donc pas une chaîne

    }

 

    //Count

    public int Count(string marequete)

    {

    }

}
