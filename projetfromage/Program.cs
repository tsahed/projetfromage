using Org.BouncyCastle.Crypto.Agreement.Srp;
using Org.BouncyCastle.Ocsp;
using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace projetfromage
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

            DAOpays undaoPAys = new DAOpays(projetfromage);
            undaoPAys.InsertFromCSV("D:\\Thalia\\projetfromage\\projetfromage\\pays.csv");

            //DAOFromage undaofromage = new DAOFromage(projetfromage, undaoPAys);
            //undaofromage.InsertFromCSV("D:\\Thalia\\projetfromage\\projetfromage\\fromage.csv");
        }
    }
}
