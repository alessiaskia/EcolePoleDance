using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcolePoleDance.Entities
{
    public class ProfEntity
    {
        #region Fields
        private int _idProf;
        private string _prenom, _infoProf, _photo;
        #endregion

        #region Props
        public int IdProf
        {
            get
            {
                return _idProf;
            }

            set
            {
                _idProf = value;
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

        public string InfoProf
        {
            get
            {
                return _infoProf;
            }

            set
            {
                _infoProf = value;
            }
        }

        public string Photo
        {
            get
            {
                return _photo;
            }

            set
            {
                _photo = value;
            }
        } 
        #endregion
    }
}
