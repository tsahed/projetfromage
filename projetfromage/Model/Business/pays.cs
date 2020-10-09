using System;
using System.Collections.Generic;
using System.Text;
using projetfromage.Model.Business;
using projetfromage.Model.Data;

namespace projetfromage.Model.Business
{
    class pays
    {
        #region Proprietes privées
        private int _id;
        private string _nom;
        #endregion

        #region Constructeurs
        public pays(int id, string nom)
        {
            Id = id;
            Nom = nom;
        }
        public pays()
        {
            Id = 0;
            Nom = "";
        }
        #endregion

        #region Accesseurs
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        #endregion 
        
    }
}
