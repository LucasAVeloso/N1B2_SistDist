using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Remap.Models;

namespace Remap.Controllers
{
    [RoutePrefix("api/medicaoVento")]
    public class WindController : ApiController
    {
        private static List<WindModel> listamedicaoVentos = new List<WindModel>();

        [AcceptVerbs("POST")]
        [Route("CadastrarMedicaoVento")]
        public string CadastrarmedicaoVento(WindModel medicaoVento)
        {
            listamedicaoVentos.Add(medicaoVento);
            return "Medição cadastrada com sucesso!";
        }


        [AcceptVerbs("PUT")]
        [Route("AlterarMedicaoVento")]
        public string AlterarMedicaoVento(WindModel medicaoVento)
        {
            listamedicaoVentos.Where(n => n.CdVentoId == medicaoVento.CdVentoId)
            .Select(s => {
                s.CdVentoId = medicaoVento.CdVentoId;
                s.CdUserId = medicaoVento.CdUserId;
                s.CdItensidade = medicaoVento.CdItensidade;
                s.DtVentoRegistroInicio = medicaoVento.DtVentoRegistroInicio;
                s.DtVentoRegistroFim = medicaoVento.DtVentoRegistroFim;
                return s;
            }).ToList();
            return "Medição alterada com sucesso!";
        }


        [AcceptVerbs("DELETE")]
        [Route("ExcluirMedicaoVento/{CdVentoId}")]
        public string ExcluirmedicaoVento(int CdVentoId)
        {
            WindModel medicaoVento = listamedicaoVentos.Where(n => n.CdVentoId == CdVentoId)
            .Select(n => n)
            .First();
            listamedicaoVentos.Remove(medicaoVento);
            return "Registro excluido com sucesso!";
        }


        [AcceptVerbs("GET")]
        [Route("ConsultarMedicaoVentoPorCodigo/{CdUserId}")]
        public List<WindModel> ConsultarmedicaoVentoPorCodigo(int CdUserId)
        {
            List<WindModel> medicaoVentoFiltrada = new List<WindModel>();

            foreach (var item in listamedicaoVentos)
            {
                if (item.CdUserId == CdUserId)
                {
                    medicaoVentoFiltrada.Add(item);
                }
            }

            return medicaoVentoFiltrada;
        }


        [AcceptVerbs("GET")]
        [Route("ConsultarMedicaoVentos")]
        public List<WindModel> ConsultarmedicaoVentos()
        {
            return listamedicaoVentos;
        }

        [AcceptVerbs("GET")]
        [Route("CarregarMedicaoVentos")]
        public string CarregarmedicaoVentos()
        {
            listamedicaoVentos.Clear();
            listamedicaoVentos.Add(new WindModel(1, 1, 1000, System.DateTime.Today, System.DateTime.Today));
            listamedicaoVentos.Add(new WindModel(2, 1, 2000, System.DateTime.Today, System.DateTime.Today));
            listamedicaoVentos.Add(new WindModel(3, 1, 3000, System.DateTime.Today, System.DateTime.Today));
            listamedicaoVentos.Add(new WindModel(4, 1, 4000, System.DateTime.Today, System.DateTime.Today));
            listamedicaoVentos.Add(new WindModel(5, 2, 2000, System.DateTime.Today, System.DateTime.Today));
            listamedicaoVentos.Add(new WindModel(6, 2, 3000, System.DateTime.Today, System.DateTime.Today));
            listamedicaoVentos.Add(new WindModel(7, 2, 4000, System.DateTime.Today, System.DateTime.Today));
            listamedicaoVentos.Add(new WindModel(8, 2, 5000, System.DateTime.Today, System.DateTime.Today));
            listamedicaoVentos.Add(new WindModel(9, 3, 100, System.DateTime.Today, System.DateTime.Today));
            listamedicaoVentos.Add(new WindModel(10, 3, 200, System.DateTime.Today, System.DateTime.Today));
            listamedicaoVentos.Add(new WindModel(11, 3, 300, System.DateTime.Today, System.DateTime.Today));
            listamedicaoVentos.Add(new WindModel(12, 3, 400, System.DateTime.Today, System.DateTime.Today));
            listamedicaoVentos.Add(new WindModel(13, 4, 4000, System.DateTime.Today, System.DateTime.Today));
            listamedicaoVentos.Add(new WindModel(14, 4, 8000, System.DateTime.Today, System.DateTime.Today));
            listamedicaoVentos.Add(new WindModel(15, 4, 8000, System.DateTime.Today, System.DateTime.Today));
            listamedicaoVentos.Add(new WindModel(16, 4, 4000, System.DateTime.Today, System.DateTime.Today));
            return "medicaoVentos Carregados com Sucesso";
        }
    }
}