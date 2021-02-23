using EcolePoleDance.DAL.Repositories;
using EcolePoleDance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcolePoleDance.Repositories
{
    public class InscriptionRepository : BaseRepository<InscriptionEntity>, IConcreteRepository<InscriptionEntity>
    {
        public InscriptionRepository(string connectionString) : base(connectionString)
        {

        }

        public bool Delete(InscriptionEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public List<InscriptionEntity> Get()
        {
            throw new NotImplementedException();
        }

        public InscriptionEntity GetOne(int PK)
        {
            throw new NotImplementedException();
        }

        public bool Insert(InscriptionEntity toInsert)
        {
            string requete = @"INSERT INTO Inscription (Prenom, Nom, Email, TypeAbonnement, DateEnvoi) VALUES (@Prenom, @Nom, @Email, @TypeAbonnement, GETDATE())";
            return base.Insert(toInsert, requete);
        }

        public bool Update(InscriptionEntity toUpdate)
        {
            throw new NotImplementedException();
        }

        List<InscriptionEntity> IConcreteRepository<InscriptionEntity>.Get()
        {
            throw new NotImplementedException();
        }

        InscriptionEntity IConcreteRepository<InscriptionEntity>.GetOne(int PK)
        {
            throw new NotImplementedException();
        }
    }
}
