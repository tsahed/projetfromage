using System;
using System.Collections.Generic;
using System.Text;

namespace projetfromage
{
    class DAOFromage
    {
        #region Attributs
        private fromage _unfromage;
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

            FromageInsert = ("fromage(id, pays_origine, nom, creation, image) values(" + unfromage.Id + "," + unfromage.Pays_origine + "," + unfromage.Nom + "," + unfromage.Creation + "," + unfromage.Image + ")");
            insert.Insert(FromageInsert);
        }

        public void delete(fromage unfromage)
        {
            dbal delete = new dbal();
            string FromageDelete;

            FromageDelete = ("Delete from pays where id ='" + unfromage.Id + "';");
            delete.Delete(FromageDelete);
        }

        public void update(fromage unfromage)
        {
            dbal update = new dbal();
            string FromageUpdate;

            FromageUpdate = ("update pays set id ='" + unfromage.Id + "', pays_origine = '" + unfromage.Pays_origine + "' , nom = '" + unfromage.Nom + "', creation = '" + unfromage.Creation + "', image = '" + unfromage.Image + "';");
            update.Update(FromageUpdate);
        }
    } 
    #endregion
}
