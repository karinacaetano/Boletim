using Boletim.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace Boletim.Controllers
{
    [ApiController]
    [Route("Nota")]
    public class NotaController : ControllerBase
    {
        public static List<Nota> minhaLista = new List<Nota>();
        [HttpPost]
        [Route("Cadastro")]
        public ActionResult PostNota(Nota[] nota)
        {
            minhaLista.AddRange(nota);
            return Ok();
        }

        [HttpGet]
        [Route("Lista")]
        public ActionResult GetListaNota()
        {
            return Ok(minhaLista);
        }

        //[HttpGet]
        //[Route("ListaFiltrada")]
        //public ActionResult GetListaFiltrada(string pesquisa)
        //{
        //    return Ok(minhaLista.FindAll(p => p.Nome.Contains(pesquisa) && p.Sobrenome.Contains(pesquisa)));
        //}

        [HttpDelete]
        [Route("DeleteLista")]
        public ActionResult DeleteLista(string pesquisa)
        {
            var lista = minhaLista.Find(x => x.Notas == pesquisa);
            return Ok(minhaLista.Remove(lista));
            // deleta tudo que tem esse nome
        }
    }
}