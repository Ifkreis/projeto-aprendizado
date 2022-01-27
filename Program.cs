using System;

namespace ProjetoPratica
{
    class program
    {
        static void Main(string[] args)
        {   
            Aluno[] alunos = new Aluno[5];
            string opcaoUsuario = ObterOpcaoUsuario();
            var Indicealuno = 0;
            Conceito conceitoGeral;
            while(opcaoUsuario.ToUpper() !="X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("informe o nome do aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();
                        
                        Console.WriteLine("informe a nota do aluno: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }else 
                        {
                            throw new ArgumentException("o valor da nota tem que ser decimal");
                        }

                        if(aluno.Nota<2)
                        {
                            conceitoGeral = Conceito.E;
                        } else if (aluno.Nota < 4)
                        {
                            conceitoGeral = Conceito.D;
                        } else if(aluno.Nota < 6)
                        {
                            conceitoGeral = Conceito.C;
                        } else if (aluno.Nota < 8)
                        {
                            conceitoGeral = Conceito.B;
                              
                        } else /*(MediaGeral <= 10)*/
                        {
                            conceitoGeral = Conceito.A;
                        }

                        Console.WriteLine($"Media Geral: {aluno.Nota} - Conceito Geral: {conceitoGeral}");
                        
                        alunos[Indicealuno] = aluno;
                        Indicealuno++;
                    
                        break;
                    
                    case "2":
                        foreach(var alunoLista in alunos)
                        {  
                            if(!string.IsNullOrEmpty(alunoLista.Nome))
                            { 
                                Console.WriteLine($"Aluno - {alunoLista.Nome}, Nota - {alunoLista.Nota}");
                            }
                        }
                        break;
                    
                    case "3":
                        decimal NotaTotal = 0;
                        var NumeroAluno = 0;
                        

                        for(int i = 0; i < alunos.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                NotaTotal = NotaTotal + alunos[i].Nota;
                                NumeroAluno++;
                            }
                        
                        }
                            var MediaGeral = NotaTotal / NumeroAluno;
                            //Conceito conceitoGeral;
                            
                            if(MediaGeral<2)
                            {
                                conceitoGeral = Conceito.E;
                            } else if (MediaGeral < 4)
                            {
                                conceitoGeral = Conceito.D;
                            } else if(MediaGeral < 6)
                            {
                                conceitoGeral = Conceito.C;
                            } else if (MediaGeral < 8)
                            {
                                conceitoGeral = Conceito.B;
                                
                            } else /*(MediaGeral <= 10)*/
                            {
                                conceitoGeral = Conceito.A;
                            }

                       Console.WriteLine($"Media Geral: {MediaGeral} - Conceito Geral: {conceitoGeral}");
                        
                        break; 

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();

            }
        }
        private static string ObterOpcaoUsuario()
            {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-----Menu-----");
            Console.WriteLine("1 - Inserir aluno");
            Console.WriteLine("2 - Listar aluno");
            Console.WriteLine("3 - Media geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine("Insira uma opçao de escolha: ");
            Console.WriteLine();
            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
            }
    }
}