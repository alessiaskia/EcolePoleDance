﻿using EcolePoleDance.DAL.Repositories;
using EcolePoleDance.Entities;
using EcolePoleDance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;

namespace EcolePoleDance.Repositories
{
    public class DataContext
    {
        IConcreteRepository<ProfEntity> _profRepo;
        IConcreteRepository<CoursEntity> _coursRepo;
        IConcreteRepository<AbonnementEntity> _abonnementRepo;
        IConcreteRepository<ClientEntity> _clientRepo;
        IConcreteRepository<EcoleEntity> _ecoleRepo;
        IConcreteRepository<ClientAbonnementEntity> _instanceAbonnementRepo;

        public DataContext(string connectionString)
        {
            _profRepo = new ProfRepository(connectionString);
            _coursRepo = new CoursRepository(connectionString);
            _abonnementRepo = new AbonnementRepository(connectionString);
            _clientRepo = new ClientRepository(connectionString);
            _ecoleRepo = new EcoleRepository(connectionString);
            _instanceAbonnementRepo = new ClientAbonnementRepository(connectionString);
        }

        #region Professeurs
       
        public List<ProfModel> GetProfs()
        {
            List<ProfEntity> listProfs = _profRepo.Get();

            List<ProfModel> allProfs = new List<ProfModel>();
            foreach (ProfEntity item in listProfs)
            {
                ProfModel p = new ProfModel
                {
                    IdProf = item.IdProf,
                    Prenom = item.Prenom,
                    InfoProf = item.InfoProf,
                    Photo = item.Photo
                };

                allProfs.Add(p);
                List<CoursEntity> coursDesProfs = ((CoursRepository)_coursRepo).GetFromProf(p.IdProf);
                string listeDeCours = "";
                foreach (CoursEntity truc in coursDesProfs)
                {
                    listeDeCours += " " + truc.NomCours + ",";
                }
                listeDeCours = listeDeCours.Substring(0, listeDeCours.Length - 1);
                p.CoursDonnees = listeDeCours;
            }
            return allProfs;
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
                    PrenomProf = ((ProfRepository)_profRepo).GetFromCours(c.IdCours).Prenom
                }
                ).ToList();
        }

        #endregion

        #region Abonnements

        //show all abonnements
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

        //get chosen abonnement
        //to insert into table ClientAbonnement

        public bool CreateInstanceAbonnement(ClientAbonnementModel cam)
        {
            ClientAbonnementEntity instanceAbonnement = new ClientAbonnementEntity()
            {
                IdAbonnement = cam.IdAbonnement,
                IdClient = cam.IdClient,
                IdEcole = cam.IdEcole,
                CreditsRestants = cam.CreditsRestants,
                DateValidation = cam.DateValidation,
                DateEcheanche = cam.DateEcheanche,
                Annule = false
            };
            return _instanceAbonnementRepo.Insert(instanceAbonnement);
        }
        #endregion

        #region Inscription
        public bool CreateClient(ClientModel cm)
        {
            ClientEntity clientEntity = new ClientEntity()
            {
                Prenom = cm.Prenom,
                Nom = cm.Nom,
                Email = cm.Email,
                Password = cm.Password,
            };

            return _clientRepo.Insert(clientEntity);
        }
        #endregion

        #region Ecole
        //still don't know what I need here
        #endregion

        #region Account
        //user authentification
        public ClientModel ClientAuth(LoginModel lm)
        {
            ClientEntity ce = ((ClientRepository)_clientRepo).GetFromLogin(lm.Email);
            if (ce == null) return null;
            SecurityHelper sh = new SecurityHelper();
            if (sh.VerifyHash(lm.Password, ce.Password, ce.Salt))
            {
                return new ClientModel()
                {
                    IdClient = ce.IdClient,
                    Prenom = ce.Prenom,
                    Nom = ce.Nom,
                    Email = ce.Email
                };
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}

