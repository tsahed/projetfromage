using System;
using System.Collections.Generic;
using System.Text;

namespace projetfromage
{
    class DAOFromage
    {
        public void insert(int id, string pays_origine, string nom, string creation, string image)
        {
            dbal insert = new dbal();
            string FromageInsert;

            FromageInsert = ("Insert into fromage(id, pays_origine, nom, creation, image) values(" + id + "," + pays_origine + "," + nom + "," + creation + "," + image + ");");
            insert.Insert(FromageInsert);
        }

        public void delete(int id)
        {
            dbal delete = new dbal();
            string FromageDelete;

            FromageDelete = ("Delete from pays where id ='" + id + "';");
            delete.Delete(FromageDelete);
        }

        public void update(int id, string pays_origine, string nom, string creation, string image)
        {
            dbal update = new dbal();
            string FromageUpdate;

            FromageUpdate = ("update pays set id ='" + id + "', pays_origine = '" + pays_origine + "' , nom = '" + nom + "', creation = '" + creation + "', image = '" + image +"';");
            update.Update(FromageUpdate);
        }
    }
}
