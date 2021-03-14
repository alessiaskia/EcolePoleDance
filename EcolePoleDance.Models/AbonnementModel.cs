using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcolePoleDance.Models
{
    public class AbonnementModel
    {
        #region Fields
        private int _idAbonnement, _nombreCredits;
        private decimal _montant, _prixParCours;
        #endregion

        #region Props
        public int IdAbonnement
        {
            get
            {
                return _idAbonnement;
            }

            set
            {
                _idAbonnement = value;
            }
        }

        public int NombreCredits
        {
            get
            {
                return _nombreCredits;
            }

            set
            {
                _nombreCredits = value;
            }
        }

        public decimal Montant
        {
            get
            {
                return _montant;
            }

            set
            {
                _montant = value;
            }
        }

        public decimal PrixParCours
        {
            get
            {
                return _prixParCours;
            }

            set
            {
                _prixParCours = value;
            }
        }
        #endregion
    }
}

