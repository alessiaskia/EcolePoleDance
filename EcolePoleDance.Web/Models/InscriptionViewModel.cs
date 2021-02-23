using EcolePoleDance.Models;
using EcolePoleDance.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace EcolePoleDance.Web.Models
{
    public class InscriptionViewModel
    {
        private DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

        private List<AbonnementModel> _abonnements;

        public InscriptionViewModel()
        {
            Abonnements = ctx.GetAllAbonnements();
        }

        public List<AbonnementModel> Abonnements
        {
            get
            {
                return _abonnements;
            }

            set
            {
                _abonnements = value;
            }
        }

        #region Props

        #endregion
    }
}