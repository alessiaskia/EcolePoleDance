using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcolePoleDance.Entities
{
    public class CoursEntity
    {
        #region Fields
        private int _idCours, _maxParticipants, _duree;
        private string _nomCours, _description, _image;
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

        public int MaxParticipants
        {
            get
            {
                return _maxParticipants;
            }

            set
            {
                _maxParticipants = value;
            }
        }

        public int Duree
        {
            get
            {
                return _duree;
            }

            set
            {
                _duree = value;
            }
        }

        public string NomCours
        {
            get
            {
                return _nomCours;
            }

            set
            {
                _nomCours = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public string Image
        {
            get
            {
                return _image;
            }

            set
            {
                _image = value;
            }
        } 
        #endregion
    }
}
