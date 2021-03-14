using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcolePoleDance.Models
{
    public class ClientAbonnementModel
    {
        #region Fields
        private int _idAbonnement, _idClient, _idEcole, _creditsRestants;
        private DateTime _dateValidation, _dateEcheanche;
        private bool _annule;
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

        public int IdClient
        {
            get
            {
                return _idClient;
            }

            set
            {
                _idClient = value;
            }
        }

        public int IdEcole
        {
            get
            {
                return _idEcole;
            }

            set
            {
                _idEcole = value;
            }
        }

        public int CreditsRestants
        {
            get
            {
                return _creditsRestants;
            }

            set
            {
                _creditsRestants = value;
            }
        }

        public DateTime DateValidation
        {
            get
            {
                return _dateValidation;
            }

            set
            {
                _dateValidation = value;
            }
        }

        public DateTime DateEcheanche
        {
            get
            {
                return _dateEcheanche;
            }

            set
            {
                _dateEcheanche = value;
            }
        }

        public bool Annule
        {
            get
            {
                return _annule;
            }

            set
            {
                _annule = value;
            }
        }
        #endregion
    }
}

