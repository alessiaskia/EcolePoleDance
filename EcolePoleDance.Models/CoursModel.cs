﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcolePoleDance.Models
{
    public class CoursModel
    {
        #region Fields
        private int _idCours, _maxParticipants;
        private TimeSpan _duree;
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

        public TimeSpan Duree
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
