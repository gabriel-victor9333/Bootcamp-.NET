﻿using System;

namespace Revisao
{

    class Program
    {

        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaousuario();

            while (opcaoUsuario.ToUpper() != "X")
            {

                switch (opcaoUsuario)
                {

                    case "1":

                        break;
                    case "2":

                        break;

                    case "3":

                        break;

                    default:

                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaousuario();
            }

            


        }

        private static string ObterOpcaousuario()
        {
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1 - inserir novo aluno");
            Console.WriteLine("2 - listar alunos");
            Console.WriteLine("3 - Calcular média geral ");
            Console.WriteLine("x - Sair");

            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }


}