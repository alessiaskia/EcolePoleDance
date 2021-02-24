using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcolePoleDance.Entities
{
    public class EcoleEntity
    {
        private int _idEcole;
        private string _email, _tel, _compteBancaire, _rue, _numero, _ville;

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

        public string Tel
        {
            get
            {
                return _tel;
            }

            set
            {
                _tel = value;
            }
        }

        public string CompteBancaire
        {
            get
            {
                return _compteBancaire;
            }

            set
            {
                _compteBancaire = value;
            }
        }

        public string Rue
        {
            get
            {
                return _rue;
            }

            set
            {
                _rue = value;
            }
        }

        public string Numero
        {
            get
            {
                return _numero;
            }

            set
            {
                _numero = value;
            }
        }

        public string Ville
        {
            get
            {
                return _ville;
            }

            set
            {
                _ville = value;
            }
        }
    }
}
