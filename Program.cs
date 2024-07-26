using AppEscola.RegrasDeNegocio;

Alunos[] salaDeAula = new Alunos[350];

int cont = 1;
int posicao = 0;
int opcao = 0;

while (opcao != 6)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Clear();
    Console.WriteLine("@@@@@@@@@@@@@@@@@@@ MENU @@@@@@@@@@@@@@@@@@@");
    Console.WriteLine();
    Console.WriteLine("1 - Cadastrar aluno");
    Console.WriteLine("2 - Alunos matriculados");
    Console.WriteLine("3 - Consultar aluno");
    Console.WriteLine("4 - Alunos aprovados");
    Console.WriteLine("5 - Alunos reprovados");
    Console.WriteLine("6 - Fechar o sistema");
    Console.Write("Opção N°...........................................: ");
    opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {

        case 1:
            {

                break;
            }//fim do case 1
        case 2:
            {

                break;
            }//fim do case 2
        case 3:
            {

                break;
            }//fim do case 3
        case 4:
            {

                break;
            }//fim do case 4
        case 5:
            {

                break;
            }//fim do case 5
        case 6:
            {
                Console.Clear();
                Console.WriteLine("Deseja mesmo fechar o Sistema? 1 - S/N");
                string resposta = Console.ReadLine();
                if (resposta.ToUpper() == "N") opcao = 0;
                
                   
                
                break;
            }//fim do case 6

        default:
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Opção inválida!!!");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.ReadKey();
                break;
            }//fim do default


    }//fim dos 18


}
//fim do laço principal
