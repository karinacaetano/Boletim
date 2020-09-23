using Boletim.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace Boletim.Controllers
{
    [ApiController]
    [Route("Materia")]
    public class MateriaController : ControllerBase
    {
        public static List<Materia> minhaLista = new List<Materia>();
        [HttpPost]
        [Route("Cadastro")]
        public ActionResult PostMateria(Materia[] materia)
        {
            minhaLista.AddRange(materia);
            return Ok();
        }

        [HttpGet]
        [Route("Lista")]
        public ActionResult GetListaMateria()
        {
            return Ok(minhaLista);
        }

        //[HttpGet]
        //[Route("ListaFiltrada")]
        //public ActionResult GetListaFiltrada(string pesquisa)
        //{
        //    return Ok(minhaLista.FindAll(p => p.Situacao.Contains(pesquisa)));
        //}

        [HttpDelete]
        [Route("DeleteLista")]
        public ActionResult DeleteLista(string pesquisa)
        {
            var lista = minhaLista.Find(x => x.Descricao== pesquisa);
            return Ok(minhaLista.Remove(lista));
            // deleta tudo que tem essa descricao
        }
    }
}
