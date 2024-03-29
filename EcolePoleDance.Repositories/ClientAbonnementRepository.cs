﻿using EcolePoleDance.DAL.Repositories;
using EcolePoleDance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcolePoleDance.Repositories
{
    public class ClientAbonnementRepository : BaseRepository<ClientAbonnementEntity>, IConcreteRepository<ClientAbonnementEntity>
    {
        public ClientAbonnementRepository(string connectionString) : base(connectionString)
        {

        }

        //procedure stockée pour l'insertion d'une instance d'abonnement
        public bool Insert(ClientAbonnementEntity toInsert)
        {
            string requete = @"exec InsertInstanceAbonnement
                                @idClient,
	                            @idAbonnement,
	                            @idEcole,
	                            @creditsRestants,
	                            @dateValidation,
	                            @dateEcheanche,
	                            @annule";

            return base.Insert(toInsert, requete);
        }

        public bool Delete(ClientAbonnementEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<ClientAbonnementEntity> Get()
        {
            throw new NotImplementedException();
        }

        public ClientAbonnementEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Update(ClientAbonnementEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
