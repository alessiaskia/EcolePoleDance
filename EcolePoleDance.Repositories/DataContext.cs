using EcolePoleDance.DAL.Repositories;
using EcolePoleDance.Entities;
using EcolePoleDance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcolePoleDance.Repositories
{
    public class DataContext
    {
        IConcreteRepository<ProfEntity> _profRepo;
        IConcreteRepository<CoursEntity> _coursRepo;

        public DataContext(string connectionString)
        {
            _profRepo = new ProfRepository(connectionString);
            _coursRepo = new CoursRepository(connectionString);
        }

        #region Professeurs

        //public ProfModel GetProfModel()
        //{
        ////Récupération entity
        //ProfEntity profFromDB = _profRepo.GetOne(5);

        ////Mapping entity vers Model

        //}

        public List<ProfModel> GetAllProfs()
        {
            return _profRepo.Get()
                .Select(p =>
                new ProfModel()
                {
                    Prenom = p.Prenom,
                    InfoProf = p.InfoProf,
                    Photo = p.Photo
                }
                ).ToList();
        }

        #endregion

        #region Cours
        public List<CoursModel> GetAllCours()
        {
            return _coursRepo.Get()
                .Select(c =>
                new CoursModel()
                {
                NomCours = c.NomCours,
                MaxParticipants = c.MaxParticipants,
                Description = c.Description,
                Image = c.Image,
                Duree = new TimeSpan(c.Duree)
                }
                ).ToList();
        } 
        #endregion
    }
}

