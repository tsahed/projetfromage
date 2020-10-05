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
            string PaysInsert;

            PaysInsert = ("Insert into pays(id, nom) values(" + unpays.Id + "," + unpays.Nom + ");");
            _dbal.Insert(PaysInsert);
        }

        public void delete(pays unpays)
        {
            string PaysDelete;

            PaysDelete = ("Delete from pays where id ='" + unpays.Id + "';");
            _dbal.Delete(PaysDelete);
        }

        public void update(pays unpays)
        {
            string PaysUpdate;

            PaysUpdate = ("update pays set id ='" + unpays.Id + "' , nom = '" + unpays.Nom + "';");
            _dbal.Update(PaysUpdate);
        }
    } 
    #endregion
}
