using System;
using System.Collections.Generic;
using System.Text;

namespace projetfromage
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
        #endregion

        #region Accesseurs
        public int Id { get => _id; set => _id = value; }
        public string Nom { get => _nom; set => _nom = value; }
        #endregion 
        
    }
}
