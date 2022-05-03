using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Remap.Models;

namespace Remap.Controllers
{
    [RoutePrefix("api/medicaoSolar")]
    public class SunController : ApiController
    {
        private static List<SunModel> listamedicaoSolars = new List<SunModel>();

        [AcceptVerbs("POST")]
        [Route("CadastrarMedicaoSolar")]
        public string CadastrarmedicaoSolar(SunModel medicaoSolar)
        {
            listamedicaoSolars.Add(medicaoSolar);
            return "Medição cadastrada com sucesso!";
        }


        [AcceptVerbs("PUT")]
        [Route("AlterarMedicaoSolar")]
        public string AlterarMedicaoSolar(SunModel medicaoSolar)
        {
            listamedicaoSolars.Where(n => n.CdSolarId == medicaoSolar.CdSolarId)
            .Select(s => {
                s.CdSolarId = medicaoSolar.CdSolarId;
                s.CdUserId = medicaoSolar.CdUserId;
                s.CdItensidade = medicaoSolar.CdItensidade;
                s.DtSolarRegistroInicio = medicaoSolar.DtSolarRegistroInicio;
                s.DtSolarRegistroFim = medicaoSolar.DtSolarRegistroFim;
                return s;
            }).ToList();
            return "Medição alterada com sucesso!";
        }


        [AcceptVerbs("DELETE")]
        [Route("ExcluirMedicaoSolar/{cdUserId}")]
        public string ExcluirmedicaoSolar(int cdUserId)
        {
            SunModel medicaoSolar = listamedicaoSolars.Where(n => n.CdUserId == cdUserId)
            .Select(n => n)
            .First();
            listamedicaoSolars.Remove(medicaoSolar);
            return "Registro excluido com sucesso!";
        }


        [AcceptVerbs("GET")]
        [Route("ConsultarMedicaoSolarPorCodigo/{CdUserId}")]
        public List<SunModel> ConsultarmedicaoSolarPorCodigo(int CdUserId)
        {
            List<SunModel> medicaoSolarFiltrada = new List<SunModel>();

            foreach (var item in listamedicaoSolars)
            {
                if (item.CdUserId == CdUserId)
                {
                    medicaoSolarFiltrada.Add(item);
                }
            }
            
            return medicaoSolarFiltrada;
        }


        [AcceptVerbs("GET")]
        [Route("ConsultarMedicaoSolars")]
        public List<SunModel> ConsultarmedicaoSolars()
        {
            return listamedicaoSolars;
        }

        [AcceptVerbs("GET")]
        [Route("CarregarMedicaoSolars")]
        public string CarregarmedicaoSolars()
        {
            listamedicaoSolars.Clear();
            listamedicaoSolars.Add(new SunModel(1, 1, 100, System.DateTime.Today, System.DateTime.Today));
            listamedicaoSolars.Add(new SunModel(2, 1, 200, System.DateTime.Today, System.DateTime.Today));
            listamedicaoSolars.Add(new SunModel(3, 1, 300, System.DateTime.Today, System.DateTime.Today));
            listamedicaoSolars.Add(new SunModel(4, 1, 400, System.DateTime.Today, System.DateTime.Today));
            listamedicaoSolars.Add(new SunModel(5, 2, 200, System.DateTime.Today, System.DateTime.Today));
            listamedicaoSolars.Add(new SunModel(6, 2, 300, System.DateTime.Today, System.DateTime.Today));
            listamedicaoSolars.Add(new SunModel(7, 2, 400, System.DateTime.Today, System.DateTime.Today));
            listamedicaoSolars.Add(new SunModel(8, 2, 500, System.DateTime.Today, System.DateTime.Today));
            listamedicaoSolars.Add(new SunModel(9, 3, 10, System.DateTime.Today, System.DateTime.Today));
            listamedicaoSolars.Add(new SunModel(10, 3, 20, System.DateTime.Today, System.DateTime.Today));
            listamedicaoSolars.Add(new SunModel(11, 3, 30, System.DateTime.Today, System.DateTime.Today));
            listamedicaoSolars.Add(new SunModel(12, 3, 40, System.DateTime.Today, System.DateTime.Today));
            listamedicaoSolars.Add(new SunModel(13, 4, 400, System.DateTime.Today, System.DateTime.Today));
            listamedicaoSolars.Add(new SunModel(14, 4, 800, System.DateTime.Today, System.DateTime.Today));
            listamedicaoSolars.Add(new SunModel(15, 4, 800, System.DateTime.Today, System.DateTime.Today));
            listamedicaoSolars.Add(new SunModel(16, 4, 400, System.DateTime.Today, System.DateTime.Today));
            return "medicaoSolars Carregados com Sucesso";
        }
    }
}