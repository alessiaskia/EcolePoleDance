using EcolePoleDance.DAL.Repositories;
using EcolePoleDance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcolePoleDance.Repositories
{
    public class EcoleRepository : BaseRepository<EcoleEntity>, IConcreteRepository<EcoleEntity>
    {
        public EcoleRepository(string connectionString) : base(connectionString)
        {

        }

        public bool Delete(EcoleEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<EcoleEntity> Get()
        {
            string requete = "Select * from Ecole";

            return base.Get(requete);
        }

        public EcoleEntity GetOne(int PK)
        {
            string requete = "Select * from Ecole where IdEcole =@id";

            return base.GetOne(PK, requete);
        }

        public bool Insert(EcoleEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(EcoleEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}


