using Boletim.Models;
using System;

namespace BoletimPadawan
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                Console.WriteLine("BEM VINDO AO SISTEMA DE NOTAS PADAWAN");
                Console.WriteLine("Qual o seu tipo de usuario? \n1 - Aluno" +
                    "\n2 - Professor \n3 - Administrador");
                int usuario = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (usuario == 3)
                {
                    Console.WriteLine("O que deseja fazer adm? \n1 - Cadastrar Materia \n" +
                        "2 - Cadastrar Curso\n3 - Cadastrar Aluno");
                    int cadastrar = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (cadastrar == 3)
                    {
                        CadastroAluno.Cadastro();
                        Console.WriteLine("menu principal");
                    }
                }
                //CadastroAluno.Cadastro();
               // CadastroMateria.Cadastro();
            }
        }
    }
}


    