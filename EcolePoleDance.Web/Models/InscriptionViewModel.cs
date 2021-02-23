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
        private InscriptionModel _formInscription;

        public InscriptionViewModel()
        {
            Abonnements = ctx.GetAllAbonnements();
            FormInscription = ctx.SaveInscription();
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

        public InscriptionModel FormInscription
        {
            get
            {
                return _formInscription;
            }

            set
            {
                _formInscription = value;
            }
        }

        #region Props

        #endregion
    }
}