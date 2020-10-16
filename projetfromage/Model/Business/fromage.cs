using System;
using System.Collections.Generic;
using System.Text;
using projetfromage.Model.Business;
using projetfromage.Model.Data;

namespace projetfromage.Model.Business
{
    class fromage
    {
        #region Proprietes privées
        private int _id;
        private string _pays_origine;
        private string _nom;
        private string _creation;
        private string _image;
        private string _dureeAffinage;
        private string _recette;
        private string _histoire;
        #endregion

        #region Constructeurs
        public fromage(int id, string pays_origine, string nom, string creation, string image, string dureeAffinage, string recette, string histoire)
        {
            _id = id;
            _pays_origine = pays_origine;
            _nom = nom;
            _creation = creation;
            _image = image;
            _dureeAffinage = dureeAffinage;
            _recette = recette;
            _histoire = histoire;
        }

        public fromage()
        {
            _id = 0;
            _pays_origine = "";
            _nom = "";
            _creation = "";
            _image = "";
        }        
        #endregion

        #region Accesseurs
        public int Id { get => _id; set => _id = value; }
        public string Pays_origine { get => _pays_origine; set => _pays_origine = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public string Creation { get => _creation; set => _creation = value; }
        public string Image { get => _image; set => _image = value; }
        public string DureeAffinage { get => _dureeAffinage; set => _dureeAffinage = value; }
        public string Recette { get => _recette; set => _recette = value; }
        public string Histoire { get => _histoire; set => _histoire = value; }
        #endregion
    }
}
