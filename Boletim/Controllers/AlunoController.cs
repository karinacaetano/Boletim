using Boletim.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace Boletim.Controllers
{
    [ApiController]
    [Route("Aluno")]
    public class AlunoController : ControllerBase
    {
        public static List<Aluno> minhaLista = new List<Aluno>();
        [HttpPost]
        [Route("Cadastro")]
        public ActionResult PostUsuario(Aluno []aluno)
        {
            minhaLista.AddRange(aluno);           
            return Ok();            
        }

        [HttpGet]
        [Route("Lista")]
        public ActionResult GetListaUsuario()
        {
            return Ok(minhaLista);
        }

        [HttpGet]
        [Route("ListaFiltrada")]
        public ActionResult GetListaFiltrada(string pesquisa)
        {            
            return Ok(minhaLista.FindAll(p => p.Nome.Contains(pesquisa) && p.Sobrenome.Contains(pesquisa)));
        }

        [HttpDelete]
        [Route("DeleteLista")]
        public ActionResult DeleteLista(string pesquisa)
        {
            
            var lista =minhaLista.Find(x => x.Nome == pesquisa);
            return Ok(minhaLista.Remove(lista));
            // deleta tudo que tem esse nome
        }
    }
}
