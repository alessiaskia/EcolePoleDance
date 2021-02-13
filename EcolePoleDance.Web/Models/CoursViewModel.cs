using EcolePoleDance.Models;
using EcolePoleDance.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace EcolePoleDance.Web.Models
{
    public class CoursViewModel
    {
        private DataContext ctx = new DataContext(ConfigurationManager.ConnectionStrings["Cnstr"].ConnectionString);

        private List<CoursModel> _cours;

        public CoursViewModel()
        {
            Cours = ctx.GetAllCours();
        }

        #region Props
        public List<CoursModel> Cours
        {
            get
            {
                return _cours;
            }

            set
            {
                _cours = value;
            }
        } 
        #endregion
    }
}