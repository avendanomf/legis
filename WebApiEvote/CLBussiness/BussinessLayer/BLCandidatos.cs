using CLDataAccess.Repository;
using CLEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLBussiness.BussinessLayer
{
    public class BLCandidatos
    {
        private DACandidatos candidatosda_ = new DACandidatos();
        public List<candidatoEntity> getAllCandidatos()
        {
            return candidatosda_.getAllCandidatos();
        }
        public string addCandidato(candidatoEntity candidatoRequest)
        {
            try
            {
                candidatosda_.addCandidato(candidatoRequest);
                return "Candidato Guardado correctamente";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            
        }
    }
}
