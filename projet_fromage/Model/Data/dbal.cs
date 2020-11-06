using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using MySql.Data.MySqlClient;
using projetfromage.Model.Business;
using projetfromage.Model.Data;

namespace projetfromage.Model.Data
{
    class dbal
    {
        #region attributs privés
        private MySqlConnection connexion;
        private string server;
        private string database;
        private string userid;
        private string pwd;
        #endregion

        #region Méthodes
        public dbal()
        {
            initialize();
        }
        //Connexion à la DB
        private void initialize()
        {
            database = "fromage";
            server = "localhost";
            userid = "root";
            pwd = "5MichelAnnecy";
            string co = "Database = " + database + ";" + "server = " + server + ";" + "user id = " + userid + ";" + "Password = " + pwd + ";"
;
            connexion = new MySqlConnection(co);
        } 
        //Ouverture de connexion à la DB
        private bool OpenConnection()
        {
            try
            {
                connexion.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Echec de la connexion au serveur. Contacter l'administrateur.");
                        break;
                    case 1045:
                        Console.WriteLine("Mot de passe ou nom d'utilisateur incorrect.");
                        break;
                }
                return false;
            }
        }

        //Fermeture de la connexion à la DB
        private bool CloseConnection()
        {
            try
            {
                connexion.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private void ExecuteNonQuery(string query)//Paramètre query = chaîne de caractère = commande Insert|Update|Delete (qui renvoie pas de données mais modif la DB)
        {
            //Création commande mysql
            MySqlCommand cmd = new MySqlCommand(query, connexion);
            cmd.CommandText = query;
            cmd.Connection = connexion;
            //Execution de la commande
            cmd.ExecuteNonQuery();
        }

        //Insertion de données dans la DB
        public void Insert(string query)
        {
            string query2 = "INSERT INTO " + query + ";";
            Console.WriteLine(query2);
            //Ouverture de la connexion
            if (this.OpenConnection() == true)
            {
                //Creation de la commande qui assigne les variables du constructeur
                MySqlCommand cmd = new MySqlCommand(query2, connexion);
                cmd.ExecuteNonQuery();
                //Fermeture de la connexion
                this.CloseConnection();
            }
        }

        //Mise à jour des données dans la DB
        public void Update(string query)
        {
            string query3 = "UPDATE " + query + ";";

            //Ouverture de connexion
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query3;
                cmd.Connection = connexion;
                //Execute query
                cmd.ExecuteNonQuery();
                //Fermeture de connexion
                this.CloseConnection();
            }
        }

        //Supprimer des données de la DB
        public void Delete(string query)
        {
            string query4 = "DELETE FROM " + query + ";";

            //Ouverture de la connexion
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query4, connexion);
                cmd.ExecuteNonQuery();
                //Fermeture de connexion
                this.CloseConnection();
            }
        }

        public DataSet RQuery(string query)
        {
            DataSet dataset = new DataSet();
            if (this.OpenConnection() == true)
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = new MySqlCommand(query, connexion);
                adapter.Fill(dataset);
            }
            return dataset;
        }

        public DataTable SelectAll(string table)
        {
            return this.RQuery("select * from " + table).Tables[0];
        }
        public DataTable SelectByField(string table, string fieldTestCondition)
        {
            return this.RQuery("select * from " + table + " where " + fieldTestCondition).Tables[0];
        }
        public DataRow SelectById(string table, int id)
        {
            return this.RQuery("select * from " + table + " where " + id).Tables[0].Rows[0];
        }
        #endregion
    }
    
}
