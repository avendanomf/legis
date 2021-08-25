using CLDataAccess.EFDataAccess;
using CLEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace CLDataAccess.Repository
{
    public class DACandidatos
    {
        private DB_EvoteEntities db = new DB_EvoteEntities();
        private MapperConfiguration config1 = new MapperConfiguration(cfg =>
           cfg.CreateMap<Candidatos, candidatoEntity>());
        private MapperConfiguration config2 = new MapperConfiguration(cfg =>
           cfg.CreateMap<candidatoEntity, Candidatos>());
        public List<candidatoEntity> getAllCandidatos()
        {
            Mapper mapper = new Mapper(config1);
            List<candidatoEntity> candidatos = new List<candidatoEntity>();
            List<Candidatos> candidatosFromDb = db.Candidatos.ToList();
            foreach (Candidatos item in candidatosFromDb)
            {
                candidatoEntity CDT = mapper.Map<candidatoEntity>(item);
                candidatos.Add(CDT
                    );
            }
            return candidatos;
        }

        public void addCandidato(candidatoEntity candidatoRequest)
        {
            Mapper mapper = new Mapper(config2);
            if (candidatoRequest != null)
            {
                Candidatos candidatoToDb = mapper.Map<Candidatos>(candidatoRequest);
                db.Candidatos.Add(candidatoToDb);
                db.SaveChanges();
            }
        }
    }
}
