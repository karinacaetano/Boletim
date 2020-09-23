using Boletim.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoletimPadawan
{
    class CadastroMateria
    {
        public static void Cadastro()
        {
            var materia = new Materia();
            Aluno.CadastroAluno(); // menu

            Console.Write("Descrição: ");
            var auxDescricao = Console.ReadLine();
            while (!Materia.VerificaDescricao(auxDescricao)|| auxDescricao == null)
            {   
                Console.Write("O Descrição precisa conter somente letras! \nDigite novamente! \nNome: ");
                auxDescricao = Console.ReadLine();
            }
            Console.WriteLine(auxDescricao);
           

            // não digitar zerada 

            Console.Write("\nData do Cadastro: ");
            var auxData = Convert.ToDateTime(Console.ReadLine());
            while (!Materia.VerificaData( auxData))
            {
                Console.Write("a data do cadastro não pode ser posterior a atual" +
                    "! \nDigite novamente! \nData: ");
                auxData = Convert.ToDateTime(Console.ReadLine());
            }
            Console.WriteLine(auxData);



            Console.Write("Situação: ");
            var auxSituacao = Console.ReadLine();
            while (!Materia.VerificaSituacao (auxSituacao) || auxSituacao == null)
            {
                Console.Write("A situação precisa ser \"Ativa\" ou \"Inativa\" \nDigite novamente! \nSituação: ");
                auxDescricao = Console.ReadLine();
            }
            Console.WriteLine(auxDescricao);

            int aux = 0;
            while (aux == 0)
            {

                Console.WriteLine("O que deseja fazer agora? \n 1 - voltar ao menu \n " +
                    "2 - Salvar esse registro" +
                    "\n 3 - Excluir esse registro");
                var instrucaoString = Console.ReadLine();
                if (int.TryParse(instrucaoString, out int instrucao))
                {
                    if (instrucao == 1)
                    {
                        Console.WriteLine("retorna ao meunu principal");
                        aux = 1;
                        break;
                    }
                    else if (instrucao == 2)
                    {
                        // salvar com api
                        aux = 1;
                        Console.WriteLine("salvando....");
                    }
                    else if (instrucao == 3)
                    {
                        // exlui com api
                        aux = 1;
                        Console.WriteLine("excluido...");
                    }
                    else
                    {
                        Console.WriteLine("numero invalido");
                    }

                }
                else
                {
                    Console.WriteLine("Voce precisa digitar um numero");
                }
            }


            Console.ReadKey();
        }
    }

}
