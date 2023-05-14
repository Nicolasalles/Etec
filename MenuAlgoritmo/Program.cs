namespace MenuAlgoritmoCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opc;
            string Resp = "Sim";
            do
            {
                Console.Clear();
                Console.SetCursorPosition(50, 0);
                Console.WriteLine("Menu Principal");
                Console.WriteLine("Escolha um prgorama para ser executado:");
                Console.WriteLine("[1]Todos os cálculos(Adição, Subtração, Divisão, Multiplicação");
                Console.WriteLine("[2]Antecessor e Sucessor");
                Console.WriteLine("[3]Área do Triângulo");
                Console.WriteLine("[4]Média");
                Console.WriteLine("[5]Compara Números");
                Console.WriteLine("[6]Tabuada");
                Console.WriteLine("[7]Sequencia Numérica");
                Console.WriteLine("[8]Operação Escolhida (+, -, *, /)");
                Console.WriteLine("[9]Fim");
                opc = int.Parse(Console.ReadLine());
                switch (opc) //escolha-caso
                {
                    case 1:
                        {
                            Todos_Calculos();
                            break; //pare
                        }

                    case 2:
                        {
                            AntSuc();
                            break;
                        }

                    case 3:
                        {
                            ATri();
                            break;
                        }

                    case 4:
                        {
                            Media();
                            break;
                        }

                    case 5:
                        {
                            Comparador();
                            break;
                        }

                    case 6:
                        {
                            Tabuada();
                            break;
                        }

                    case 7:
                        {
                            Seq();
                            break;
                        }

                    case 8:
                        {
                            Opchse();
                            break;
                        }

                    case 9:
                        {
                            Console.WriteLine("Ok! Até a Próxima!");
                            Resp = "nao";
                            break;
                        }

                    default:
                        Console.WriteLine("Número Invalido");
                        break;
                }
            } while (Resp == "Sim" || Resp == "sim");


            static void Todos_Calculos()
            {
                //variaveis
                double a, b, Som, Sub, Mult, Div;
                string vResp;

                //loop para caso a resposta for "sim"
                do
                {
                    Console.BackgroundColor = ConsoleColor.Blue; //cor de fundo
                    Console.ForegroundColor = ConsoleColor.White; //cor da letra
                    Console.Clear(); //limpa a tela
                    Console.SetCursorPosition(45, 0);
                    Console.WriteLine("Programa Todas as Operações");
                    Console.Write(new String('=', 128)); //comando para repetir o "="

                    Console.WriteLine("Escolha o primeiro número: "); //comando para escrever
                    a = int.Parse(Console.ReadLine()); //comando para converter o texto para numero real
                    Console.WriteLine("Escolha o segundo número ");
                    b = int.Parse(Console.ReadLine());

                    Som = a + b; //atribuição
                    Sub = a - b;
                    Div = a / b;
                    Mult = a * b;

                    Console.WriteLine($"{a} + {b} = {Som}");
                    Console.WriteLine($"{a} - {b} = {Sub}");
                    Console.WriteLine($"{a} * {b} = {Mult}");
                    Console.WriteLine($"{a} / {b} = {Div}");
                    //Console.WriteLine("{0} + {1} = {2}", a, b, r); uma maneira de aparecer a + b = r
                    //Console.WriteLine($"{a} + {b} = {r} "); outra maneira de aparecer a + b = r

                    Console.WriteLine("\nDeseja cotinuar neste programa?: ");
                    vResp = Console.ReadLine();

                } while (vResp == "Sim" || vResp == "sim");


            }

            static void AntSuc()
            {
                int numb, Ant, Suc;
                string Resp;
                Console.Clear();
                Console.WriteLine("Programa Antecessor e Sucessor");
                Console.WriteLine("\nDigite um número: ");

                numb = int.Parse(Console.ReadLine());
                Ant = numb - 1;
                Suc = numb + Ant;

                Console.WriteLine("O antecessor é " + Ant);
                Console.WriteLine("O sucessor é " + Suc);
                Console.WriteLine("Deseja continuar nesse programa?[Sim/Não]: ");
                Resp = Console.ReadLine();

                if (Resp == "Sim" || Resp == "sim")
                {
                    AntSuc();
                }
            }

            static void ATri()
            {
                string Resp;
                float b, h, A;

                Console.Clear();
                Console.WriteLine("Programa Triângulo");
                Console.WriteLine("\nDigite a altura do triangulo: ");
                h = float.Parse(Console.ReadLine());
                Console.WriteLine("Digite a base do triangulo: ");
                b = float.Parse(Console.ReadLine());
                A = (b * h) / 2;
                Console.WriteLine("A área do triangulo é: " + A);
                Console.WriteLine("Deseja continuar nesse programa?:[Sim/Não]");
                Resp = Console.ReadLine();
                if (Resp == "Sim" || Resp == "sim")
                {
                    ATri();
                }

            }

            static void Media()
            {
                int c, b = 1;
                double[] n = new double[4];
                double med;
                string Resp;

                Console.Clear();
                Console.WriteLine("Programa Média");
                for (c = 0; c < 4; c++)
                {
                    Console.WriteLine("Digite a nota do " + b + "º bimestre: ");
                    n[c] = Double.Parse(Console.ReadLine());
                    b = b + 1;
                }
                med = (n[0] + n[1] + n[2] + n[3]) / 4;
                Console.WriteLine("A média é: " + med);
                Console.WriteLine("Deseja continuar no programa?:");
                Resp = Console.ReadLine();
                if (Resp == "Sim" || Resp == "sim")
                {
                    Media();
                }

            }

            static void Comparador()
            {
                int n1, n2;
                string Resp;

                Console.Clear();
                Console.WriteLine("Programa Comparador de Números");
                Console.WriteLine("Digite um número: ");
                n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro número: ");
                n2 = int.Parse(Console.ReadLine());
                if (n1 > n2)
                {
                    Console.WriteLine(n1 + " é maior que " + n2 + ".");
                }
                else if (n1 < n2)
                {
                    Console.WriteLine(n1 + " é menor que " + n2 + ".");
                }
                else
                {
                    Console.WriteLine("Os números são iguais.");
                }
                Console.WriteLine("Deseja continuar no programa?");
                Resp = Console.ReadLine();
                if (Resp == "Sim" || Resp == "sim")
                {
                    Comparador();
                }
            }

            static void Tabuada()
            {
                int n, c;
                string Resp;
                Console.Clear();
                Console.WriteLine("Programa Tabuada");
                Console.WriteLine("\nDigite um número: ");
                n = int.Parse(Console.ReadLine());
                for (c = 1; c < 11; c++)
                {
                    Console.WriteLine(n + " X " + c + " = " + (n * c));
                }
                Console.WriteLine("Deseja continuar no programa?");
                Resp = Console.ReadLine();
                if (Resp == "Sim" || Resp == "sim") ;
                {
                    Tabuada();
                }
            }

            static void Seq()
            {
                int n, step, nn, c;
                string Resp;

                Console.Clear();
                Console.WriteLine("Programa Sequência Numerica");
                Console.Write("Digite um número: ");
                n = int.Parse(Console.ReadLine());
                Console.Write("Digite o passo a ser pulado: ");
                step = int.Parse(Console.ReadLine());
                Console.Write("Digite quantas vezes seja feito a soma: ");
                nn = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                for (c = 1; c <= nn; c++)
                {
                    Console.WriteLine(n);
                    n = n + step;
                }
                Console.WriteLine("\nDeseja continuar no programa?: ");
                Resp = Console.ReadLine();
                if (Resp == "Sim" || Resp == "sim")
                {
                    Seq();
                }


            }

            static void Opchse()
            {


                int cont = 0;
                string Op = "", Resp = "";
                bool erro = true;
                double n1, n2, Rsom, Rsub, Rmult, Rdiv;

                do
                {
                    cont = 0;
                    Console.Clear();
                    Console.Write("Digite um número: ");
                    n1 = int.Parse(Console.ReadLine());
                    Console.Write("Digite outro número: ");
                    n2 = int.Parse(Console.ReadLine());
                    Console.Write("Digite a operação [+, -, *, /]: ");
                    Op = Console.ReadLine();

                    if (Op == "+")
                    {
                        Rsom = n1 + n2;
                        erro = false;
                        Console.WriteLine(n1 + " + " + n2 + " = " + Rsom);
                    }

                    else if (Op == "-")
                    {
                        Rsub = n1 - n2;
                        erro = false;
                        Console.WriteLine(n1 + " - " + n2 + " = " + Rsub);
                    }

                    else if (Op == "*")
                    {
                        Rmult = n1 * n2;
                        erro = false;
                        Console.WriteLine(n1 + " x " + n2 + " = " + Rmult);
                    }

                    else if (Op == "/")
                    {
                        Rdiv = n1 / n2;
                        erro = false;
                        Console.WriteLine(n1 + " / " + n2 + " = " + Rdiv);
                    }

                    else //laço após o erro for cometido
                    {
                        do
                        {
                            cont = cont + 1;
                            Console.Clear();
                            erro = true;
                            Console.WriteLine("Você ja errou a operação " + cont + " vezes, se errar mais " + (5 - cont) + " vezes o programa será encerrado!");
                            Console.WriteLine("Digite uma das operações indicadas nos colchetes![+, -, *, /]");
                            Op = Console.ReadLine();
                            if (Op == "+")
                            {
                                Rsom = n1 + n2;
                                erro = false;
                                Console.WriteLine(n1 + " + " + n2 + " = " + Rsom);
                            }

                            else if (Op == "-")
                            {
                                Rsub = n1 - n2;
                                erro = false;
                                Console.WriteLine(n1 + " - " + n2 + " = " + Rsub);
                            }

                            else if (Op == "*")
                            {
                                Rmult = n1 * n2;
                                erro = false;
                                Console.WriteLine(n1 + " x " + n2 + " = " + Rmult);
                            }

                            else if (Op == "/")
                            {
                                Rdiv = n1 / n2;
                                erro = false;
                                Console.WriteLine(n1 + " / " + n2 + " = " + Rdiv);
                            }

                        } while (erro == true && cont < 4);
                    }

                    if (cont == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("Você atingiu o limite de tentativas, o programa foi encerrado.");
                        Console.WriteLine("Aperte ENTER para voltar ao menu");
                        Console.ReadLine();
                        break;
                    }
                    Console.WriteLine("Deseja continuar no programa?[sim/não]: ");
                    Resp = Console.ReadLine();
                } while (Resp == "sim" || Resp == "Sim");
                if (Resp == "não" || Resp == "Não" || Resp == "nao")
                {
                    Console.WriteLine("Ok! até a proxima!");
                    Console.WriteLine("Aperte ENTER para voltar ao menu");
                    Console.ReadLine();
                }
            }



        }
    }
}