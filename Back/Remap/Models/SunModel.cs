using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Remap.Models
{
    public class SunModel
    {
        private int cdSolarId;
        private int cdUserId;
        private int cdItensidade;
        private DateTime dtSolarRegistroInicio;
        private DateTime dtSolarRegistroFim;


        public SunModel() { }
        public SunModel
        (int cdSolarId, int cdUserId, int cdItensidade, DateTime dtSolarRegistroInicio, DateTime dtSolarRegistroFim)
        {
            this.cdSolarId = cdSolarId;
            this.cdUserId = cdUserId;
            this.cdItensidade = cdItensidade;
            this.dtSolarRegistroInicio = dtSolarRegistroInicio;
            this.dtSolarRegistroFim = dtSolarRegistroFim;
        }
        public int CdSolarId
        { get { return cdSolarId; } set { cdSolarId = value; } }
        public int CdUserId
        { get { return cdUserId; } set { cdUserId = value; } }
        public int CdItensidade
        { get { return cdItensidade; } set { cdItensidade = value; } }
        public DateTime DtSolarRegistroInicio
        { get { return dtSolarRegistroInicio; } set { dtSolarRegistroInicio = value; } }
        public DateTime DtSolarRegistroFim
        { get { return dtSolarRegistroFim; } set { dtSolarRegistroFim = value; } }

    }
}