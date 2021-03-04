
using EcolePoleDance.Models;
using EcolePoleDance.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace EcolePoleDance.Web.Models
{
    public class EquipeViewModel
    {
        private DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

        private List<ProfModel> _equipe;

        public EquipeViewModel()
        {
            Equipe = ctx.GetProfs();
        }

        #region Props
        public List<ProfModel> Equipe
        {
            get
            {
                return _equipe;
            }

            set
            {
                _equipe = value;
            }
        } 
        #endregion
    }
}