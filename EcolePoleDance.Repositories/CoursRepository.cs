using EcolePoleDance.DAL.Repositories;
using EcolePoleDance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcolePoleDance.Repositories
{
    public class CoursRepository : BaseRepository<CoursEntity>, IConcreteRepository<CoursEntity>
    {
        public CoursRepository(string connectionString) : base(connectionString)
        {

        }
       
        public List<CoursEntity> Get()
        {
            string requete = "Select * from Cours";

            return base.Get(requete);
        }

        public CoursEntity GetOne(int PK)
        {

            string requete = "Select * from Cours where IdCours =@id";

            return base.GetOne(PK, requete);
        }

        public List<CoursEntity> GetFromProf(int idProf)
        {
            string requete = @"SELECT Cours.NomCours
                               FROM  Prof LEFT JOIN
                               Cours ON Prof.IdProf = Cours.IdProf
                               WHERE Prof.IdProf=" + idProf;
           
            //string requete = "Select * from V_Profs";

            return base.Get(requete);
        }

        public bool Insert(CoursEntity toInsert)
        {
            throw new NotImplementedException();
        }

        public bool Update(CoursEntity toUpdate)
        {
            throw new NotImplementedException();
        }

        public bool Delete(CoursEntity toDelete)
        {
            throw new NotImplementedException();
        }
    }
}
