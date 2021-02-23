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
        IConcreteRepository<AbonnementEntity> _abonnementRepo;
        IConcreteRepository<InscriptionEntity> _inscriptionRepo;

        public DataContext(string connectionString)
        {
            _profRepo = new ProfRepository(connectionString);
            _coursRepo = new CoursRepository(connectionString);
            _abonnementRepo = new AbonnementRepository(connectionString);
            _inscriptionRepo = new InscriptionRepository(connectionString);
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
                }
                ).ToList();
        }
        #endregion

        #region Abonnements
        public List<AbonnementModel> GetAllAbonnements()
        {
            return _abonnementRepo.Get()
                .Select(a =>
                new AbonnementModel()
                {
                    IdAbonnement = a.IdAbonnement,
                    NombreCredits = a.NombreCredits,
                    Montant = a.Montant,
                    PrixParCours = a.PrixParCours,
                }
                ).ToList();
        }
        #endregion

        #region Inscription
        public bool SaveInscription(InscriptionModel im)
        {
            InscriptionEntity ie = new InscriptionEntity();
            ie.Prenom = im.Prenom;
            ie.Nom = im.Nom;
            ie.Email = im.Email;
            ie.TypeAbonnement = im.TypeAbonnement;

            return _inscriptionRepo.Insert(ie);
        }
        #endregion
    }
}

