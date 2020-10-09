using System;
using System.Collections.Generic;
using System.Text;

namespace projetfromage
{
    class fromage
    {
        #region Proprietes privées
        private int _id;
        private string _pays_origine;
        private string _nom;
        private string _creation;
        private string _image;
        #endregion

        #region Constructeurs
        public fromage(int id, string pays_origine, string nom, string creation, string image)
        {
            _id = id;
            _pays_origine = pays_origine;
            _nom = nom;
            _creation = creation;
            _image = image;
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
        #endregion
    }
}
