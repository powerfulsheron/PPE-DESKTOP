using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;

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
    }
}
