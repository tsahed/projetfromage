using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace projetfromage
{
    class DAOpays
    {
        #region Attributs
        private DAOpays _DAOpays;
        private dbal _dbal;
        #endregion

        public void DaoFromage(dbal dbal)
        {
            _dbal = dbal;
        }

        #region Autres méthodes
        public void insert(pays unpays)
        {
            dbal insert = new dbal();
            string PaysInsert;

            PaysInsert = ("Insert into pays(id, nom) values(" + unpays.Id + "," + unpays.Nom + ");");
            insert.Insert(PaysInsert);
        }

        public void delete(pays unpays)
        {
            dbal delete = new dbal();
            string PaysDelete;

            PaysDelete = ("Delete from pays where id ='" + unpays.Id + "';");
            delete.Delete(PaysDelete);
        }

        public void update(pays unpays)
        {
            dbal update = new dbal();
            string PaysUpdate;

            PaysUpdate = ("update pays set id ='" + unpays.Id + "' , nom = '" + unpays.Nom + "';");
            update.Update(PaysUpdate);
        }
    } 
    #endregion
}
