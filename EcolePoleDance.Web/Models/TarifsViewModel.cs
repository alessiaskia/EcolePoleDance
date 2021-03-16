using EcolePoleDance.Models;
using EcolePoleDance.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace EcolePoleDance.Web.Models
{
    public class TarifsViewModel
    {
        private DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

        private List<AbonnementModel> _tarifs;

        private ClientAbonnementModel _instance;
        private AbonnementModel _typeAbonnement;

        public TarifsViewModel()
        {
            Tarifs = ctx.GetAllAbonnements();
            Instance = ctx.CreateInstanceAbonnement(TypeAbonnement);
        }

        public List<AbonnementModel> Tarifs
        {
            get
            {
                return _tarifs;
            }

            set
            {
                _tarifs = value;
            }
        }

        public ClientAbonnementModel Instance
        {
            get
            {
                return _instance;
            }

            set
            {
                _instance = value;
            }
        }

        public AbonnementModel TypeAbonnement
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
    }
}