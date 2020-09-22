using Boletim.Models;
using System;

namespace BoletimPadawan
{
    public class CadastroAluno
    {
        public static void Cadastro()
        {
            var aluno = new Aluno();
            Aluno.CadastroAluno();

            Console.Write("Nome: ");
            var auxNome = Console.ReadLine();
            while (!Aluno.VerificaNome(auxNome) || auxNome == null)
            {   // nao ta verificando certo
                Console.Write("O nome precisa conter somente letras! \nDigite novamente! \nNome: ");
                auxNome = Console.ReadLine();
            }
            Console.WriteLine(auxNome);
            //aluno.Nome = auxNome;

            Console.Write("\nSobrenome: ");
            string auxSobrenome = Console.ReadLine();
            while (auxSobrenome == null)
            {   // nao ta verificando certo
                Console.Write("O Sobrenome não pode ser nulo. \nDigite novamente! \nSobrenome: ");
                auxSobrenome = Console.ReadLine();
            }
            //aluno.Sobrenome = Console.ReadLine();

            // não digitar zerada 

            Console.Write("\nData: ");
            aluno.DataNascimento = Convert.ToDateTime(Console.ReadLine());
            while (!Aluno.VerificaData(aluno.DataNascimento))
            {
                Console.Write("a data de nascimento precisa ser anterior a 01/01/2002! \nDigite novamente! \nData: ");
                aluno.DataNascimento = Convert.ToDateTime(Console.ReadLine());
            }
            Console.WriteLine(aluno.DataNascimento);

            Console.Write("Cpf: ");
            string auxCpf = Console.ReadLine();
            Console.WriteLine(Aluno.VerificaCpf(auxCpf));
            while (!Aluno.VerificaCpf(auxCpf) || auxCpf == null)
            {   // nao ta verificando certo
                Console.Write("O CPF está a com a pountuação \n ou quantidade de numeros incorretos" +
                    "\nDigite novamente! \nCpf: ");
                auxCpf = Console.ReadLine();
            }
            Console.WriteLine(auxCpf);

            
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
                    else if(instrucao == 2)
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
                    Console.WriteLine("Voce precisa digitar um numero" );
                }
            }


            Console.ReadKey();
        }
    }
    
}
         
                
