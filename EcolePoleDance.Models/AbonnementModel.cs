using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcolePoleDance.Models
{
    public class AbonnementModel
    {
        #region Fields
        private int _idCours, _nombreCredits;
        private decimal _montant, _prixParCours;
        #endregion

        #region Props
        public int IdCours
        {
            get
            {
                return _idCours;
            }

            set
            {
                _idCours = value;
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

