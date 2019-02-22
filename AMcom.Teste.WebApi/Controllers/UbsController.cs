using AMcom.Teste.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace AMcom.Teste.WebApi.Controllers
{
    [RoutePrefix("api/Ubs")]
    public class UbsController : ApiController
    {
        [HttpGet]
        [Route("GetUbs")]
        public HttpResponseMessage GetUbs()
        {
            return Request.CreateResponse(HttpStatusCode.BadRequest, "Erro ao efetuar chamado ao UbsController");
        }

        [HttpGet]
        [Route("GetUbs")]
        public HttpResponseMessage GetUbs(double pLatitude, double pLongetude)
        {
            try
            {
                List<UbsDTO> ubsDtoReturnList = UbsService.GetNearestUbs(pLatitude, pLongetude);

                return Request.CreateResponse(HttpStatusCode.OK, ubsDtoReturnList);
            }
            catch(Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, "Erro na ação GetUbs: " + e.Message);
            }
        }
    }
}