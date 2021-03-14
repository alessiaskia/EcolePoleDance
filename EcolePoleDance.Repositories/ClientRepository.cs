using EcolePoleDance.DAL.Repositories;
using EcolePoleDance.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace EcolePoleDance.Repositories
{
    public class ClientRepository : BaseRepository<ClientEntity>, IConcreteRepository<ClientEntity>
    {
        public ClientRepository(string ConnectionString) : base(ConnectionString)
        {

        }
        public bool Delete(ClientEntity toDelete)
        {
            throw new NotImplementedException();
        }

        public bool Update(ClientEntity toUpdate)
        {
            throw new NotImplementedException();
        }

        public List<ClientEntity> Get()
        {
            return base.Get("Select * from Client");
        }

        public ClientEntity GetOne(int PK)
        {
            return base.GetOne(PK, "Select * from Client where IdClient=@id");
        }

        //inscription nouvel utilisateur
        public bool Insert(ClientEntity toInsert)
        {
            SecurityHelper securityHelper = new SecurityHelper();
            byte[] salt = securityHelper.GenerateLongRandomSalt();
            toInsert.Salt = Convert.ToBase64String(salt);
            toInsert.Password = securityHelper.createHash(toInsert.Password, salt);
            string requete = @"INSERT INTO [dbo].[Client]
           ([Prenom]
           ,[Nom]
           ,[Email]
           ,[Password]
           ,[Salt])
            VALUES
           (@Prenom
           ,@Nom 
           ,@Email 
           ,@Password 
           ,@Salt)";

            return base.Insert(toInsert, requete);
        }

        //login
        public ClientEntity GetFromLogin(string login)
        {
            Dictionary<string, object> p = new Dictionary<string, object>();
            p.Add("email", login);
            return base.Get("Select * from [Client] where Email=@email", p).FirstOrDefault();
        }
    }
}