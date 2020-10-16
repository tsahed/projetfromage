using Org.BouncyCastle.Crypto.Agreement.Srp;
using Org.BouncyCastle.Ocsp;
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using projetfromage.Model.Business;
using projetfromage.Model.Data;
using System.Data;
using System.Collections.Generic;

namespace projetfromage.Model
{
    class Program
    {
        static void Main(string[] args)
        {
            //Connexion dbal
            dbal projetfromage = new dbal();


            //string insert = "pays VALUES ('2','Algérie')";
            //string update = "pays SET id ='3' where id='1'";
            //string delete = "pays";

            //projetfromage.Insert(insert);
            //Fromage.Update(update);
            //projetfromage.Delete(delete);

            //DAOpays undaoPAys = new DAOpays(projetfromage);
            //undaoPAys.InsertFromCSV("D:\\Thalia\\projetfromage\\projetfromage\\pays.csv");

            //DAOFromage undaofromage = new DAOFromage(projetfromage, undaoPAys);
            //undaofromage.InsertFromCSV("D:\\Thalia\\projetfromage\\projetfromage\\fromage.csv");

            //DataSet lespays = projetfromage.RQuery("SELECT * FROM Pays");

            //foreach (DataRow leslignes in lespays.Tables[0].Rows)
            //{

            //    Console.WriteLine(leslignes["id"]);
            //}

            //foreach (DataRow r in projetfromage.SelectAll("Pays").Rows)
            //{
            //    Console.WriteLine(r["nom"]);
            //}          

            //foreach (DataRow r in projetfromage.SelectByField("pays", "nom like 'I%'").Rows)
            //{
            //    Console.WriteLine(r["nom"]);
            //}          

            //DataRow x = projetfromage.SelectById("pays", 38);
            //Console.Write(x["nom"]);
            //Console.ReadLine();          

            //foreach (DataRow r in projetfromage.SelectAll("pays").Rows)
            //{
            //    Console.WriteLine(r["id"] + " | " + r["nom"]);
            //}


            //foreach (DataRow r in projetfromage.SelectByField("pays", "nom like '" + "I%" + "'").Rows)
            //{
            //    Console.WriteLine(r["id"] + " | " + r["nom"]);
            //}

            //DataRow x = projetfromage.SelectById("pays", 38);
            //Console.Write(x["nom"]);
            //Console.ReadLine();          

        }
    }
}
