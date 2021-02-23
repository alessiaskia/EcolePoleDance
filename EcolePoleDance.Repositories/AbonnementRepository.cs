using EcolePoleDance.DAL.Repositories;
using EcolePoleDance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcolePoleDance.Repositories
{
    public class AbonnementRepository : BaseRepository<AbonnementEntity>, IConcreteRepository<AbonnementEntity>
    {
        public AbonnementRepository(string connectionString) : base(connectionString)
        {

        }

        public bool Delete(AbonnementEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<AbonnementEntity> Get()
        {
            string requete = "Select * from Abonnement";

            return base.Get(requete);
        }

        public AbonnementEntity GetOne(int PK)
        {
            string requete = "Select * from Abonnement where IdAbonnement =@id";

            return base.GetOne(PK, requete);
        }

        public bool Insert(AbonnementEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(AbonnementEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
