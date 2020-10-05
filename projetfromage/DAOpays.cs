using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace projetfromage
{
    class DAOpays
    {
        #region Attributs
        private dbal _dbal;
        #endregion

        public void DaoFromage(dbal dbal)
        {
            _dbal = dbal;
        }

        #region Autres méthodes
        public void insert(pays unpays)
        {
            string PaysInsert;

            PaysInsert = ("pays(id, nom) values(" + unpays.Id + "," + unpays.Nom +")");
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

            PaysUpdate = ("pays set id ='" + unpays.Id + "' , nom = '" + unpays.Nom + "'");
            _dbal.Update(PaysUpdate);
        }

        public void InsertFromCSV(string pays)
        {
            using (var reader = new StreamReader(pays))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var record = new pays();
                IEnumerable<pays> records = csv.EnumerateRecords(record);

                foreach (var r in records)
                {
                    Console.WriteLine(r.Id + "-" + r.Nom);
                    this.insert(record);
                }
            }
        }
    } 
    #endregion
}
