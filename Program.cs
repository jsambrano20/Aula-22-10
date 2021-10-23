using System;

namespace Aula_22_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n, x;

            //Console.WriteLine("Escreva um numero: ");
            //x = int.Parse(Console.ReadLine());

            //for (n = 1; n <= 100; n++)
            //{
            //    if (n%x == 0)
            //para um numero ser divisvel a regra é o resto ser 0//
            //        {
            //            Console.WriteLine("n = " + n + " é divisivel = " + x);
            //        }
            //}

            /*double n1, n2, n3, media;
            int a, x;

            Console.WriteLine("Quantidade de Alunos: ");
            x = int.Parse(Console.ReadLine());

            for (a=1; a < x ; a++)
            {
                Console.WriteLine("Nota 1,2,3: " + (a + 1));
                n1 = double.Parse(Console.ReadLine());
                n2 = double.Parse(Console.ReadLine());
                n3 = double.Parse(Console.ReadLine());
                media = (n1 + n2 + n3) / 3;
                Console.Write("O aluno " + (a+1) + "tem média = " + media);

                if (media >= 6)
                {
                    Console.WriteLine("está aprovado ");
                }
                else if(media < 6)
                {
                    Console.WriteLine("Reprovado ");
                }

                      int q, i;
            double n1, n2, n3, media;
            Console.Write("Oi pessoal, tudo bem?\n");
            Console.WriteLine("Oi pessoal, tudo bem?");
            Console.WriteLine("Quantos alunos tem na turma?");
            q = int.Parse(Console.ReadLine());
            for (i = 0; i < q; i++)  //for (i = 1; i <= q; i++)             {
                //fazer a leitura -> aqui dentro, pra cada execução deste laço, é 1 aluno distinto...                 Console.WriteLine("Digite as três notas do aluno " + (i + 1));
                n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            media = (n1 + n2 + n3) / 3;
            Console.Write("O aluno " + (i + 1) + " tem média = " + media);
            if (media >= 6)
            {
                Console.WriteLine(" e está aprovado!");
            }
            else
            {
                Console.WriteLine(" e está reprovado!");
            }*/

            //EXERCICIO 1 
            //int n,i;
            //Console.WriteLine("Digite um numero: ");
            //n = int.Parse(Console.ReadLine());

            //for (i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(n + " X " + i + " = " + (n*i));
            //}

            //EXERCICIO 2 

            //int n;

            //for (n = 1000; n <= 1999; n++)
            //{
            //    if (n % 11 == 5)
            //   {
            //        Console.WriteLine("n = " + n);
            //   }
            //}

            //EXERCICIO 3 

            //int n1, n2, n;
            //char p;
            //bool par; //SE par for true mostrara os pares e se for false mostra impar
            //Console.WriteLine("Escreva um numero inicial: ");
            //n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Escreva um numero final: ");
            //n2 = int.Parse(Console.ReadLine());
            //par = true;
            //Console.WriteLine("par = p e impar = i ");
            //p = char.Parse(Console.ReadLine());
            //if (p == 'p')
            //{ 
            //    par = true; 
            //}
            //else if (p == 'i')
            //{
            //    par = false;
            //}
            //else
            //{
            //    Console.WriteLine("Opção inválida");
            //}
            //for (n = n1; n <= n2; n++)
            //{
            //    if (par)
            //    {
            //        if (n % 2 == 0)
            //        {
            //            Console.WriteLine("Pares: " + n);
            //        }
            //    }
            //    else
            //    {
            //        if (n % 2 != 0)
            //        {
            //        Console.WriteLine("impar " + n);
            //        }
            //    }
            //}


            //int i;
            //for (i = 0; i < 20; i++)
            //{
            //    if (i == 11)
            //    {
            //        break;
            //    }
            //    if (i == 7)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine("O i é = " + i);
            //}

            //int op, i; /*LAÇO INFINITO*/

            //for (i = 0; i >= 0 (true); i++)
            //{
            //    Console.WriteLine("Um valor para OP: ");
            //    op = int.Parse(Console.ReadLine());
            //    if (op == 0)
            //    {
            //        i = -2; //CASo FOR TRUE no FOR o break; pausa
            //    }
            //}

            //EXERCICIO 4

            //int opcao;

            //for (opcao = 0; true; opcao++) //USAR o TRUE
            //{
            //    Console.Write(" OPÇÂO é igual =  ");

            //    opcao = int.Parse(Console.ReadLine());

            //    if (opcao >4 || opcao < 1)
            //    {
            //        Console.WriteLine("Valor digitado foi 1 ou 4! Parabéns!");
            //        continue; ; 
            //    }
            //    else
            //    {
            //        Console.WriteLine("digite um valor valido");
            //        break;
            //    }

            //}
            //OU UTILIZAR O SWITCH CASE FUNCIONAAAA

            //int i, j;

            //for (i=0;i<=10; i++)
            //{
            //    for(j=0; j<=10; j++)
            //    {
            //        Console.WriteLine(i + "*" + j + "=" + (j * i));
            //    }
            //}



            //EXERCICIO 5   

            //int i;

            //for (i=0; i <= 20; i++)
            //{
            //    Console.WriteLine(i + "=" + (i * 2,54));
            //}

            //int i, n, f;
            //Console.WriteLine("Fatorial: ");
            //n = int.Parse(Console.ReadLine());
            //f = n ;

            //for (i = n - 1; i >= n; i--)
            //{
            //    Console.WriteLine(f * i);

            //    f = f * i;

            //    Console.Write("i = " + i);
            //    Console.Write("    fatorial = "+ f);
            //}
            //Console.WriteLine("\nFatorial de" + n +  "é" + f);
            //Console.ReadLine();

            //EXERCICIO 

            double f = 1000, j = 1, s=1000 ;
            int i;
            
            for (i = 0; i <= 50; i++)
            {
                f = f - 3;
                j = j + 1;

                s =(f / j);
                Console.WriteLine(" " + f + "/" + j +  "= " + s);
            }


        } 
    }
}

