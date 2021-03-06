﻿using EcolePoleDance.Models;
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

        public TarifsViewModel()
        {
            Tarifs = ctx.GetAllAbonnements();
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
    }
}