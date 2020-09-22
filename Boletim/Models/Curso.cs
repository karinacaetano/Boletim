﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Boletim.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Materia { get; set; }
        public string Situacao { get; set; }

        public List<Aluno> Alunos { get; set; } 

        public Curso()
        {
            Alunos = new List<Aluno>();

        }



    }
}
