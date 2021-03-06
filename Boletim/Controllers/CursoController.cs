﻿using Boletim.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
namespace Boletim.Controllers
{
    [ApiController]
    [Route("Curso")]
    public class CursoController : ControllerBase
    {
        public static List<Curso> minhaLista = new List<Curso>();
        [HttpPost]
        [Route("Cadastro")]
        public ActionResult PostCurso(Curso[] curso)
        {
            minhaLista.AddRange(curso);
            return Ok();
        }

        [HttpGet]
        [Route("Lista")]
        public ActionResult GetListaCurso()
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

            var lista = minhaLista.Find(x => x.Nome == pesquisa);
            return Ok(minhaLista.Remove(lista));
            // deleta tudo que tem esse nome
        }
    }
}
