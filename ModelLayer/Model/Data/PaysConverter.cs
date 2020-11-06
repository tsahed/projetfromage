using projetfromage.Model.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace projetfromage.Model.Data
{
    class PaysConverter<P> : pays
    {
        #region Attributs
        private string _pays;
        #endregion

        #region Constructeur
        public PaysConverter(pays unpays)
        {
            _pays = Convert.ToString(unpays);
        }
        #endregion

        #region Accesseurs
        public string Pays { get => _pays; set => _pays = value; }
        #endregion

        public override object ConvertFromString(string text)
           
        {
            foreach (DataRow r in DAOpays.SelectByName("pays", "nom like '" + text + "'").Rows)
                {
                    Console.WriteLine(r["id"] + " | " + r["nom"]);            
                }

            return PaysConverter.DeserializeObject<P>(text);
        }
    }
}
