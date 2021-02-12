using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EcolePoleDance.Entities;
using EcolePoleDance.DAL.Repositories;

namespace EcolePoleDance.Repositories
{
    public class ProfRepository : BaseRepository<ProfEntity>, IConcreteRepository<ProfEntity>
    {
        public ProfRepository(string connectionString) : base(connectionString)
        {

        }

        public bool Delete(ProfEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<ProfEntity> Get()
        {
            string requete = "Select * from Prof";

            return base.Get(requete);
        }

        public ProfEntity GetOne(int PK)
        {
            string requete = "Select * from Prof where IdProf =@id";

            return base.GetOne(PK, requete);
        }

        public bool Insert(ProfEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(ProfEntity toUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
