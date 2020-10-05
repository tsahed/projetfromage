using System;
using System.Collections.Generic;
using System.Text;

namespace projetfromage
{
    class DAOpays
    {
        public void insert(int id, string nom)
        {
            dbal insert  = new dbal();
            string PaysInsert;

            PaysInsert = ("Insert into pays(id, nom) values(" + id + "," + nom + ");");
            insert.Insert(PaysInsert);
        }

        public void delete(int id)
        {
            dbal delete = new dbal();
            string PaysDelete;

            PaysDelete = ("Delete from pays where id ='" + id + "';");
            delete.Delete(PaysDelete);
        }

        public void update(int id, string nom)
        {
            dbal update = new dbal();
            string PaysUpdate;

            PaysUpdate = ("update pays set id ='" + id + "' , nom = '" + nom + "';");
            update.Update(PaysUpdate);
        }
    }
}
