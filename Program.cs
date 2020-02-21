using System;

namespace basico_do_menu
{  static void MontarMenu(String[] opcoes, Action[] acoes)
        {
            if (opcoes.Length > 0)
            {
                Boolean imprimirMenu = true;
                StringBuilder menu = new StringBuilder();
                Int32 numeroOpcao = 1;



                menu.Append(numeroOpcao).Append(" - ").Append(opcoes[numeroOpcao - 1]);



                for (numeroOpcao = 2; numeroOpcao <= opcoes.Length; numeroOpcao++)
                {
                    menu.Append("\n").Append(numeroOpcao).Append(" - ").Append(opcoes[numeroOpcao - 1]);
                }



                while (imprimirMenu == true)
                {
                    Console.WriteLine(menu.ToString());
                    Int32 opcaoEscolhida = readpositiveinterger();



                    if (opcaoEscolhida < opcoes.Length)
                    {
                        acoes[opcaoEscolhida - 1]();
                    }
                    else if (opcaoEscolhida == opcoes.Length)
                    {
                        imprimirMenu = false;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida");
                    }
                }
            }
        }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

             MontarMenu(new String[]
                {
                "Cadastrar Aluno",
                "Alterar Aluno",
                "Excluir Aluno",
                "Pesar Aluno",
                "Calcular Evolução do Aluno",
                "Sair"
                }, new Action[] {
                
                
                
                
                
                });
        }
    }
}
