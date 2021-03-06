﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Boletim.Models
{
    public class Materia
    {
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Situacao { get; set; }

        public static bool VerificaData(DateTime dataCadastro)
        {
            //Regex rx = new Regex(@"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[13-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$");
            var data = DateTime.Now;
            return dataCadastro <= data;
        }

        public static bool VerificaDescricao(string descricao)
        {
            Regex rx = new Regex(@"^[ a-zA-Z á]*$");
            //(@"[a-zA-Z\u00C0-\u00FF ]+");
            return rx.IsMatch(descricao);
        }
        // arrumar 
        public static bool VerificaSituacao(string situacaoMateria)
        {
            string ativo = "ativo";
            string inativo = "inativo";
            bool result = ativo.Equals(situacaoMateria, StringComparison.OrdinalIgnoreCase);
            bool result2 = inativo.Equals(situacaoMateria, StringComparison.OrdinalIgnoreCase);
            if (result || result2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

}
