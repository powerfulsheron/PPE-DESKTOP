using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

//Classe référençant divers méthodes "outils"

namespace Maquette_Belle_Table_Final
{
    class Tools
    {
        //using System.IO;
        //Créer et écrire dans un fichier
        public void CreateAndWriteFileDemo()
        {
            //Possibilité de créer un fichier de n'importe quelle extension (.csv, .xml, ...)
            string path = @"C:\AppServ\Example.txt";
            //Si le fichier n'existe pas
            if (!File.Exists(path))
            {
                //On le créer
                File.Create(path);
                //On écrit dedans
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine("The very first line!");
                tw.Close();
            }
            //Sinon si le fichier existe déjà, ony ajoute une ligne
            else if (File.Exists(path))
            {
                //On écrit dedans
                TextWriter tw = new StreamWriter(path);
                tw.WriteLine("The next line!");
                tw.Close();
            }
        }

        public string ReadFileDemo(string path)
        {
            //using System.IO;
            // Read the file as one string.
            //path est une variable strinf qui contient le chemin vers le ficher "c:\\test.txt"
            System.IO.StreamReader myFile = new System.IO.StreamReader(path);
            string myString = myFile.ReadToEnd();

            myFile.Close();

            return myString;
        }

        public void CreatePDFdemo()
        {
            //using iTextSharp;
            //using iTextSharp.text.pdf;
            //using iTextSharp.text;
            //Tuto en français: https://dotnet.developpez.com/articles/itextsharp/
            //On instancie le document
            Document nouveauDocument = new Document();

            try
            {
                //On créer physiquement sur le disque le document, on créer un stream pour écrire dedans
                PdfWriter.GetInstance(nouveauDocument, new FileStream("fichier.pdf", FileMode.Create));
                // On l'ouvre pour écrire dedans
                nouveauDocument.Open();
                nouveauDocument.Add(new Phrase("hello world"));
            }
            catch (DocumentException de)
            {
                Console.WriteLine("error " +de.Message);
            }
            catch (System.IO.IOException ioe)
            {
                Console.WriteLine("error " +ioe.Message);
            }
            nouveauDocument.Close();
        }

            public void ConnectMySQL()
            {//SCRIPT POUR SE CONNECTER A MYSQL SUR WAMP EN LOCAL SANS NHIBERNATE

            // 1. ajouter aux références "SQL.Data" 

            // 2. Puis ajouter cette librairie :

            //using MySql.Data.MySqlClient;
             //3. et enfin :
                MySqlConnection Connect = new MySqlConnection("Server = localhost; Port = 3306; Database = gepev; Uid = root; Pwd =;"); 
                //a modifier si différent pour sois-même
                        try
                        {
                            Connect.Open();
                            //MessageBox.Show("Connecté à la base", "tu es connecté");  
                
                           }
                        catch(MySqlException ex)
                        {
                                MessageBox.Show(ex.ToString());
                                }
				
                                 //Connect.Close();
                }
        //Graphiques: http://plasserre.developpez.com/cours/chart/ et voir le Windows Form GraphDemo
        public void HelloChart()
        {
            //Le chart et les deux DateTimePicker doivent être déposé dans le formulaire via la boite à outil
            //il n'y aura donc pas besoin de les déclarer comme sur les 3 lignes qui suivent:
            Chart chart1 = new Chart();
            DateTimePicker dateTimePicker1 = new DateTimePicker();
            DateTimePicker dateTimePicker2 = new DateTimePicker();

            //Dans un graphique Chart il y a une ou plusieur Série de donnée, ici on en veut une seule
            chart1.Series.Add("Series1");

            //On détermine la date minimum et maximum qui apparaitera sur l'axe Y du graphique
            //AxisY.Minimum ne reçoit que des type 'doubles', dateTimePicker2.Value.Date.ToOADate(); est un double
            chart1.ChartAreas["ChartArea1"].AxisY.Minimum = dateTimePicker2.Value.Date.ToOADate();
            chart1.ChartAreas["ChartArea1"].AxisY.Maximum = dateTimePicker1.Value.Date.ToOADate();

            // On fait une requete select toute simple
            MySqlConnection conDataBase = new MySqlConnection("Server = localhost; Port = 3306; Database = gepev; Uid = root; Pwd =;");
            MySqlCommand cmdDataBase = new MySqlCommand(" select * from utilisateur ;", conDataBase);
            //Un reader qui nous servira à lire la requête
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();

                while (myReader.Read())
                {
                    //A chaque ligne trouvée on ajoute à l'axe X le 'prenomUtilisateur' auquel on associe sur l'axe Y la date 'dateDernierLogin'
                    // les données proviennent de la BDD
                    // On remarque GetString ou GetDateTime en fonction du type de donnée
                    chart1.Series["Series1"].Points.AddXY(myReader.GetString("prenomUtilisateur"), myReader.GetDateTime("dateDernierLogin"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }
}
