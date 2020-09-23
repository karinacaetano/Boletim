using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Boletim.Models
{
    public class Nota
    {
        public string Aluno { get; set; }
        public string Materia { get; set; }
        public string Notas { get; set; }


        public static bool VerificaCpf(string cpf)
        {
            Regex rx = new Regex(@"([0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{2})");
            //(@"/^\d{ 3}\.\d{ 3}\.\d{ 3}\-\d{ 2}$/");
            return (rx.IsMatch(cpf));
        }

        public static bool VerificaNome(string nome)
        {// nao ta funcionando
            Regex rx = new Regex(@"[a-zA-Z\u00C0-\u00FF ]+");
            return rx.IsMatch(nome);
        }

        public bool VerificaCurso(string situacaoCurso)
        {    // vendo se o curso está ativo
            // mudar pra classe curso?
            return string.Equals("ativo", situacaoCurso.ToLower());
        }

        public static bool VerificaData(DateTime? dataNascimento)
        {
            // Regex rx = new Regex(@"^(?:(?:31(\/|-|\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\/|-|\.)(?:0?[13-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})$|^(?:29(\/|-|\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))$|^(?:0?[1-9]|1\d|2[0-8])(\/|-|\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2})$");
            var dataLimite = new DateTime(2002, 01, 01);
            return dataNascimento <= dataLimite;
        }
        public static void CadastroAluno()
        {
            Console.WriteLine("Universidade Padawan");
            Console.WriteLine("--------------------");
            Console.WriteLine("Cadastrando novo aluno");
            Console.WriteLine("--------------------");
        }
    }
}
