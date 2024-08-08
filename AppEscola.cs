using AppEscola.RegrasDeNegocio;

Alunos[] salaDeAula = new Alunos[350];

int cont = 1;
int posicao = 0;
int opcao = 0;

//FUNÇÃO PARA CADASTRAR ALUNO

void CadastrarAluno()
{
    int opcao = 1;
    while (opcao != 0)
    {
        if (cont < 350)
        {
            Alunos aluno = new Alunos();
            Console.Clear();
            Console.WriteLine("---------------------- CADASTRAR ALUNO ----------------------");
            Console.WriteLine();
            Console.WriteLine("Número de Inscrição..........:" + cont);

            aluno.Id = cont;
            aluno.NumeroDeMatricula = cont * 1000;

            Console.Write("Nome................: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Nota1................: ");
            aluno.Nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Nota2................: ");
            aluno.Nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write(aluno.MostrarSituacao());

            salaDeAula[posicao] = aluno;
            cont++; posicao++;

            Console.Write("DESEJA CONTINUAR CADASTRANDO? S/N: ");
            string resposta = Console.ReadLine();
            if (resposta.ToUpper() == "N") opcao = 0;

        }
        else
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("VAGAS ESGOTADAS!!!");
            Console.ForegroundColor= ConsoleColor.Red;
            Console.ReadKey();
        }
    }//Fim do Laço
}//Fim função cadastrar alunos


//Função listar alunos cadastrados
void ListarAlunos()
{
    Alunos alunos = new Alunos();
    Console.WriteLine("================Lista de Alunos================"); 
   
    for (int i = 0; i < posicao; i++)
    {
        alunos = salaDeAula[i];

        Console.WriteLine("Número da Matricula: " + alunos.NumeroDeMatricula);

        Console.WriteLine("Número de Inscrição................: " + alunos.Id);
      

        Console.WriteLine("Nome................: "+ alunos.Nome);
        
        Console.WriteLine("Nota1................: "+ alunos.Nota1);
  
        Console.WriteLine("Nota2................: "+alunos.Nota2);

        Console.Write(alunos.MostrarSituacao());

        Console.WriteLine();
    }
    Console.ReadKey();
}

//Função Consultar Aluno

void ConsultarAluno()
{
    Alunos alunos= new Alunos();
    Console.WriteLine("Insira Numero da matricula do aluno");
    posicao = Convert.ToInt16(Console.ReadLine());
    alunos = salaDeAula[posicao/1000 - 1];   
   if (alunos != null)
    {
        Console.WriteLine("Número da Matricula: " + alunos.NumeroDeMatricula);

        Console.WriteLine("Número de Inscrição................: " + alunos.Id);


        Console.WriteLine("Nome................: " + alunos.Nome);

        Console.WriteLine("Nota1................: " + alunos.Nota1);

        Console.WriteLine("Nota2................: " + alunos.Nota2);

        Console.Write(alunos.MostrarSituacao());
    }
   else
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Não se encontra alunos Cadastrados");
        Console.ForegroundColor = ConsoleColor.White;

    }

    Console.ReadKey();
   
}
//alunos aprovados
void ListarAlunosAprovados()
{
    Alunos alunos = new Alunos();
    Console.Clear();
    Console.WriteLine("================APROVADOS================");
    for (int i = 0; i < posicao; i++)
    {
        alunos = salaDeAula[i];
        Console.ForegroundColor = ConsoleColor.White;
        if (alunos.MostrarSituacao() == "APROVADO")
        {           
           
                Console.WriteLine("Número da Matricula: " + alunos.NumeroDeMatricula);

                Console.WriteLine("Número de Inscrição................: " + alunos.Id);


                Console.WriteLine("Nome................: " + alunos.Nome);

                Console.WriteLine("Nota1................: " + alunos.Nota1);

                Console.WriteLine("Nota2................: " + alunos.Nota2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(alunos.MostrarSituacao() + "\n");
           
        }
       
    }
    Console.ReadKey();
}
//alunos reprovados
void ListarAlunosReprovados()
{
    Alunos alunos = new Alunos();
    Console.Clear();
    Console.WriteLine("================REPROVADOS================");
    for (int i = 0; i < posicao; i++)
    {
        alunos = salaDeAula[i];
        Console.ForegroundColor = ConsoleColor.White;
        if (alunos.MostrarSituacao() != "APROVADO")
        {

            Console.WriteLine("Número da Matricula: " + alunos.NumeroDeMatricula);

            Console.WriteLine("Número de Inscrição................: " + alunos.Id);


            Console.WriteLine("Nome................: " + alunos.Nome);

            Console.WriteLine("Nota1................: " + alunos.Nota1);

            Console.WriteLine("Nota2................: " + alunos.Nota2);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(alunos.MostrarSituacao() + "\n");
        }
    }
    Console.ReadKey();
}
while (opcao != 6)
{
    Console.ForegroundColor = ConsoleColor.White;
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
                CadastrarAluno();
                break;
            }//fim do case 1
        case 2:
            {
                ListarAlunos();
                break;
            }//fim do case 2
        case 3:
            {
                ConsultarAluno();
                break;
            }//fim do case 3
        case 4:
            {
                ListarAlunosAprovados();
                break;
            }//fim do case 4
        case 5:
            {
                ListarAlunosReprovados();
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
