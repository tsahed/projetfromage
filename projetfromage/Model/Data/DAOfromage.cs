using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using projetfromage.Model.Business;
using projetfromage.Model.Data;

namespace projetfromage.Model.Data
{
    class DAOFromage
    {
        #region Attributs
        private dbal _dbal;
        private DAOpays _DAOpays;
        #endregion

        #region Constructeurs
        public void DAOfromage(dbal dbal, DAOpays DAOpays)
        {
            _dbal = dbal;
            _DAOpays = DAOpays;
        }
        #endregion

        #region Autres méthodes
        public void insert(fromage unfromage)
        {
            string FromageInsert;

            FromageInsert = ("fromage(id, pays_origine, nom, creation, image) values(" + unfromage.Id + "," + unfromage.Pays_origine.Replace("'","''") + "," + unfromage.Nom.Replace("'", "''") + "," + unfromage.Creation.Replace("'", "''") + "," + unfromage.Image +")");
            _dbal.Insert(FromageInsert);
        }

        public void delete(fromage unfromage)
        {
            string FromageDelete;

            FromageDelete = ("pays where id ='" + unfromage.Id +"'");
            _dbal.Delete(FromageDelete);
        }

        public void update(fromage unfromage)
        {
            string FromageUpdate;

            FromageUpdate = ("pays set id ='" + unfromage.Id + "', pays_origine = '" + unfromage.Pays_origine.Replace("'", "''") + "' , nom = '" + unfromage.Nom.Replace("'", "''") + "', creation = '" + unfromage.Creation.Replace("'", "''") + "', image = '" + unfromage.Image + "'");
            _dbal.Update(FromageUpdate);
        }

        public void InsertFromCSV(string chemin)
        {
            using (var reader = new StreamReader(chemin))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
                var record = new fromage();
                IEnumerable<fromage> records = csv.EnumerateRecords(record);

                foreach (fromage fromage in records)
                {
                    insert(fromage);
                }
            }
        }
    } 
    #endregion
}
