using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Remap.Models
{
    public class UsuarioModel
    {
        private int cdUserId;
        private double cdCpf;
        private string dsNome;
        private double cdTelefone;
        private string dsEndereco;
        private string dsEstado;
        private string dsCidade;
        private DateTime dtRegistro;


        public UsuarioModel() { }
        public UsuarioModel
        (int cdUserId, double cdCpf,string dsNome,double cdTelefone,string dsEndereco,string dsEstado,string dsCidade,DateTime dtRegistro)
        {
            this.cdUserId = cdUserId;
            this.cdCpf = cdCpf;
            this.dsNome = dsNome;
            this.cdTelefone = cdTelefone;
            this.dsEndereco = dsEndereco;
            this.dsEstado = dsEstado;
            this.dsCidade = dsCidade;
            this.dtRegistro = dtRegistro;                
        }
        public int CdUserId
        { get { return cdUserId; } set { cdUserId = value; } }
        public double CdCpf
            { get { return cdCpf; } set { cdCpf = value; } }
        public string DsNome
            { get { return dsNome; } set { dsNome = value; } }
        public double CdTelefone
            { get { return cdTelefone; } set { cdTelefone = value; } }
        public string DsEndereco
            { get { return dsEndereco; } set { dsEndereco = value; } }
        public string DsEstado
            { get { return dsEstado; } set { dsEstado = value; } }
        public string DsCidade
            { get { return dsCidade; } set { dsCidade = value; } }
        public DateTime DtRegistro
            { get { return dtRegistro; } set { dtRegistro = value; } }

    }
}