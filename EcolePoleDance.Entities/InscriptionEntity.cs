using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcolePoleDance.Entities
{
    public class InscriptionEntity
    {
        #region Fields
        private int _idInscription;
        private string _prenom, _nom, _email, _typeAbonnement;
        #endregion

        #region Props
        public int IdInscription
        {
            get
            {
                return _idInscription;
            }

            set
            {
                _idInscription = value;
            }
        }

        public string Prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
                _prenom = value;
            }
        }

        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string TypeAbonnement
        {
            get
            {
                return _typeAbonnement;
            }

            set
            {
                _typeAbonnement = value;
            }
        } 
        #endregion
    }
}
