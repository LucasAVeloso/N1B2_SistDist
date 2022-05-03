using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Remap.Models
{
    public class WindModel
    {
        private int cdVentoId;
        private int cdUserId;
        private int cdItensidade;
        private DateTime dtVentoRegistroInicio;
        private DateTime dtVentoRegistroFim;


        public WindModel() { }
        public WindModel
        (int cdVentoId, int cdUserId, int cdItensidade, DateTime dtVentoRegistroInicio, DateTime dtVentoRegistroFim)
        {
            this.cdVentoId = cdVentoId;
            this.cdUserId = cdUserId;
            this.cdItensidade = cdItensidade;
            this.dtVentoRegistroInicio = dtVentoRegistroInicio;
            this.dtVentoRegistroFim = dtVentoRegistroFim;
        }
        public int CdVentoId
        { get { return cdVentoId; } set { cdVentoId = value; } }
        public int CdUserId
        { get { return cdUserId; } set { cdUserId = value; } }
        public int CdItensidade
        { get { return cdItensidade; } set { cdItensidade = value; } }
        public DateTime DtVentoRegistroInicio
        { get { return dtVentoRegistroInicio; } set { dtVentoRegistroInicio = value; } }
        public DateTime DtVentoRegistroFim
        { get { return dtVentoRegistroFim; } set { dtVentoRegistroFim = value; } }
    }
}