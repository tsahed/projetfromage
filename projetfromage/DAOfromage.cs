using System;
using System.Collections.Generic;
using System.Text;

namespace projetfromage
{
    class DAOFromage
    {
        #region Attributs
        private dbal _dbal;
        private DAOpays _DAOpays;
        #endregion

        #region Constructeurs
        public void DaoFromage(dbal dbal, DAOpays DAOpays)
        {
            _dbal = dbal;
            _DAOpays = DAOpays;
        }
        #endregion

        #region Autres méthodes
        public void insert(fromage unfromage)
        {
            string FromageInsert;

            FromageInsert = ("fromage(id, pays_origine, nom, creation, image) values(" + unfromage.Id + "," + unfromage.Pays_origine + "," + unfromage.Nom + "," + unfromage.Creation + "," + unfromage.Image +")");
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

            FromageUpdate = ("pays set id ='" + unfromage.Id + "', pays_origine = '" + unfromage.Pays_origine + "' , nom = '" + unfromage.Nom + "', creation = '" + unfromage.Creation + "', image = '" + unfromage.Image + "'");
            _dbal.Update(FromageUpdate);
        }
    } 
    #endregion
}
