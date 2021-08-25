using CLBussiness.BussinessLayer;
using CLEntities.Entities;
using System;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApiEvote.util;

namespace WebApiEvote.Controllers
{
    [MycrosHot]
    [System.Web.Http.RoutePrefix("Candidato")]
    public class CandidatoController : ApiController
    {
        private BLCandidatos candidatosbl_ = new BLCandidatos();


        [System.Web.Http.Route("getAllCandidatos")]
        [System.Web.Http.HttpGet]
        public HttpResponseMessage getAllCandidatos()
        {
            try
            {
                var response = this.Request.CreateResponse(HttpStatusCode.OK, candidatosbl_.getAllCandidatos());
                return response;
            }
            catch (Exception eException)
            {
                throw new HttpResponseException(new HttpResponseMessage()
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Content = new StringContent(eException.Message)
                });
            }
        }
        [System.Web.Http.Route("addCandidato")]
        [System.Web.Http.HttpPut]
        public HttpResponseMessage addCandidato(candidatoEntity candidatoRequest)
        {
            try
            {
                var response = this.Request.CreateResponse(HttpStatusCode.OK, candidatosbl_.addCandidato(candidatoRequest));
                return response;
            }
            catch (Exception eException)
            {
                throw new HttpResponseException(new HttpResponseMessage()
                {
                    StatusCode = HttpStatusCode.BadRequest,
                    Content = new StringContent(eException.Message)
                });
            }
        }
    }
}