using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcolePoleDance.Models
{
    public class ClientModel
    {
        //private int _idClient;
        private string _prenom, _nom, _email, _password, _confirmPassword;

        //public int IdClient
        //{
        //    get
        //    {
        //        return _idClient;
        //    }

        //    set
        //    {
        //        _idClient = value;
        //    }
        //}

        [Required]
        [MaxLength(50)]
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

        [Required]
        [MaxLength(50)]
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

        [Required]
        [MaxLength(323)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
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

        [Required]
        [MaxLength(50)]
        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }

        [Required]
        [MaxLength(50)]
        [Compare("Password", ErrorMessage = "No Matching Password")]
        public string ConfirmPassword
        {
            get
            {
                return _confirmPassword;
            }

            set
            {
                _confirmPassword = value;
            }
        }

    }
}
