using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Remap.Models;

namespace Remap.Controllers
{
    [RoutePrefix("api/usuario")]
    public class UsuarioController : ApiController
    {
        private static List<UsuarioModel> listaUsuarios = new List<UsuarioModel>();

        [AcceptVerbs("POST")]
        [Route("CadastrarUsuario")]
        public string CadastrarUsuario(UsuarioModel usuario)
        {
            listaUsuarios.Add(usuario);
            return "Usuário cadastrado com sucesso!";
        }
        
        
        [AcceptVerbs("PUT")]
        [Route("AlterarUsuario")]
        public string AlterarUsuario(UsuarioModel usuario)
        {
            listaUsuarios.Where(n => n.CdCpf == usuario.CdCpf)
            .Select(s =>{
                s.CdCpf = usuario.CdCpf;
                s.CdTelefone = usuario.CdTelefone;
                s.DsCidade = usuario.DsCidade;
                s.CdUserId = usuario.CdUserId;
                s.DsEndereco = usuario.DsEndereco;
                s.DtRegistro = usuario.DtRegistro;
                s.DsNome = usuario.DsNome;
                s.DsEstado = usuario.DsEstado;
                return s;
            }).ToList();
            return "Usuário alterado com sucesso!";
        }
        
        
        [AcceptVerbs("DELETE")]
        [Route("ExcluirUsuario/{cdUserId}")]
        public string ExcluirUsuario(int cdUserId)
        {
            try
            {
                UsuarioModel usuario = listaUsuarios.Where(n => n.CdUserId == cdUserId).Select(n => n).First();
                listaUsuarios.Remove(usuario);
                return "Registro excluido com sucesso!";
            }
            catch (Exception)
            {
                return "Ops.... verifique que o usuario existe";
                throw;
            }
            
        }
        
        
        [AcceptVerbs("GET")]
        [Route("ConsultarUsuarioPorCodigo/{CdCpf}")]
        public UsuarioModel ConsultarUsuarioPorCodigo(int CdCpf)
        {
            UsuarioModel usuario = listaUsuarios.Where(n => n.CdCpf == CdCpf)
            .Select(n => n)
            .FirstOrDefault();
            return usuario;
        }
        
        
        [AcceptVerbs("GET")]
        [Route("ConsultarUsuarios")]
        public List<UsuarioModel> ConsultarUsuarios()
        {
            return listaUsuarios;
        }

        [AcceptVerbs("GET")]
        [Route("CarregarUsuarios")]
        public string CarregarUsuarios()
        {
            listaUsuarios.Clear();
            listaUsuarios.Add(new UsuarioModel(1, 40030020001, "NOME1" ,1112345678, "rua da tua casa", "Estado 1", "Cidade 1", System.DateTime.Today));
            listaUsuarios.Add(new UsuarioModel(2, 40030020002, "NOME2", 1112345678, "rua da tua casa", "Estado 1", "Cidade 1", System.DateTime.Today));
            listaUsuarios.Add(new UsuarioModel(3, 40030020003, "NOME3", 1112345678, "rua da tua casa", "Estado 1", "Cidade 1", System.DateTime.Today));
            listaUsuarios.Add(new UsuarioModel(4, 40030020004, "NOME4", 1112345678, "rua da tua casa", "Estado 1", "Cidade 1", System.DateTime.Today));
            return "Usuarios Carregados com Sucesso";
        }
    }
}