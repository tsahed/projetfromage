using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using projetfromage.Model.Business;
using projetfromage.Model.Data;
using System.Data;

namespace projetfromage.Model.Data
{
    class DAOpays
    {
        #region Attributs
        private dbal _dbal;
        #endregion

        #region Constructeur
        public DAOpays(dbal dbal)
        {
            _dbal = dbal;
        
        } 
        #endregion

        #region Autres méthodes
        public void insert(pays unpays)
        {
            string PaysInsert;

            PaysInsert = ("pays(id, nom) values(" + unpays.Id + ",'" + unpays.Nom.Replace("'","''") +"')");
            _dbal.Insert(PaysInsert);
        }

        public void delete(pays unpays)
        {
            string PaysDelete;

            PaysDelete = ("pays where id ='" + unpays.Id +"'");
            _dbal.Delete(PaysDelete);
        }

        public void update(pays unpays)
        {
            string PaysUpdate;

            PaysUpdate = ("pays set id ='" + unpays.Id + "' , nom = '" + unpays.Nom.Replace("'", "''") + "'");
            _dbal.Update(PaysUpdate);
        }

        public void InsertFromCSV(string chemin)
        {
            using (var reader = new StreamReader(chemin))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
                var record = new pays();
                IEnumerable<pays> records = csv.EnumerateRecords(record);

                foreach (pays pays in records)
                {                   
                    insert(pays);
                }
            }
        }

        public List<pays> SelectAll()
        {
            List<pays> listPays = new List<pays>();
            foreach (DataRow r in _dbal.SelectAll("pays").Rows)
            {
                listPays.Add(new pays((int)r["id"], (string)r["nom"]));
            }
            return listPays;
        }

        public pays SelectByName(string nomPays)
        {
            DataRow r = _dbal.SelectByField("pays", "nom like '" + nomPays + "'").Rows[0];
            return new pays((int)r["id"], (string)r["nom"]);
        }

        public pays SelectById(int idPays)
        {
            DataRow r = _dbal.SelectById("pays", idPays);
            return new pays((int)r["id"], (string)r["nom"]);
        }
        #endregion
    } 
   
}
