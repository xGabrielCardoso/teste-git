using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System;

namespace Projeto_Teste // ORGANIZAÇÃO , PARA ENCONTRAR AS CLASSES COM FACILIDADE NO PROJETO
{
    class Program //NOME DA CLASSE
    {
        static void Main(string[] args) // Entrepoint = vai ser carregado primeiro de tudo assim como o Load do 4Manager
        {
            //int idade = 21;
            //double saldo = 1000.8745;
            //string nome = "Gabriel";

            //Console.WriteLine("{0} tem {1} anos de idade e saldo de {2:F2} no banco.", nome, idade, saldo);//placeholders
            //Console.WriteLine($"{nome} tem {idade} anos de idade e saldo de {saldo:F2} no banco.");//interpolação
            //Console.WriteLine(nome + " Tem " + idade + " Anos de idade e saldo de " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " no banco.");//concatenação


            //----------------------------------------------------------------------------------------------------------------------------------------
            //string produto1 = "Computador";
            //string produto2 = "Mesa de escritório";
            //byte idade = 30;
            //int codigo = 5290;
            //char genero = 'M';
            //double preco1 = 2100.0;
            //double preco2 = 650.50;
            //double medida = 53.234567;

            //Console.WriteLine("Produtos: ");
            //Console.WriteLine($"{produto1}, cujo preço é $ {preco1}");//interpolãção
            //Console.WriteLine("{0}, cujo preço é $ {1}", produto2, preco2);//placeholders
            //Console.WriteLine("");
            //Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            //Console.WriteLine("");
            //Console.WriteLine("Medida com oito casas decimais: "+ medida);//concatenação
            //Console.WriteLine($"Arredondado (três casas decimais): {medida:F3}");
            //Console.WriteLine("Separador decimal invariant culture: " + medida.ToString("F3", CultureInfo.InvariantCulture));
            //-----------------------------------------------------------------------------------------------------------------------------------------

            //double a;
            //float b;
            //a = 5.1;
            //b =  (float) a;
            //System.Console.WriteLine(b);
            //double PiConvert = System.Convert.ToDouble(3.1415926535897849);
            //double PiCast = (double)3.1415926535897849;
            //System.Double PiDoubleClass = (System.Double)3.1415926535897849;

            //System.Console.WriteLine(PiConvert);
            //System.Console.WriteLine(PiCast);
            //System.Console.WriteLine(PiDoubleClass);

            //int n1 = 3 + 4 * 2;
            //int n2 = (3 + 4) * 2;
            //int n3 = (17 % 3);
            //double n4 = 10.0 / 8;

            //double a = 1.0, b = -3.0, c = -4.0;

            //double delta = Math.Pow(b , 2.0) - 4.0 * a * c;

            //double x1 = (-b + Math.Sqrt(delta)) / 2* a;

            //double x2 = (-b - Math.Sqrt(delta)) / 2 * a;


            //System.Console.WriteLine(n1);
            //System.Console.WriteLine(n2);
            //System.Console.WriteLine(n3);
            //System.Console.WriteLine(n4);
            //Console.WriteLine(delta);
            //Console.WriteLine(x1);
            //Console.WriteLine(x2);

            //int a = 10;

            //Console.WriteLine(a);

            //a += 2;
            //Console.WriteLine(a);

            //a -= 2;
            //Console.WriteLine(a);

            //a *= 3;
            //Console.WriteLine(a);

            //a /= 10;
            //Console.WriteLine(a);

            //string s = "ABC";
            //Console.WriteLine(s);

            //s += "DEF";
            //Console.WriteLine(s);

            //int a = 10;
            //int b = ++a;


            //Console.WriteLine(a);
            //Console.WriteLine(b);

            //float x = 4.5f;

            //double y = x;

            //Console.WriteLine(y);

            //double a;
            //int b;

            //a = 5.1;
            //b = (int)a;

            //int a = 5;
            //int b = 2; 

            //double resultado = (double)a / b;

            //Console.WriteLine(resultado);

            //string frase = Console.ReadLine();
            //string x = Console.ReadLine();
            //string y = Console.ReadLine();
            //string z = Console.ReadLine();

            //Console.WriteLine("Você digitou : ");
            //Console.WriteLine(frase);
            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);


            ////string a = Console.ReadLine();
            //int[] vet = int.Parse(Console.ReadLine()).Split(' ');
            //int p1 = vet[0];
            //int p2 = vet[1];
            //int p3 = vet[2]; 

            //Console.WriteLine("Você digitou : ");
            //Console.WriteLine(p1 +" "+ p2 +" "+ p3);

            //try
            //{

            //    int n1 = int.Parse(Console.ReadLine());
            //    char ch = char.Parse(Console.ReadLine());
            //    double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //    string[] vet = Console.ReadLine().Split(' ');
            //    string nome = vet[0];
            //    string sexo = vet[1];
            //    int idade = int.Parse(vet[2]);
            //    double altura = double.Parse(vet[3]);

            //    Console.WriteLine("Você digitou: ");
            //    Console.WriteLine(n1);
            //    Console.WriteLine(ch);
            //    Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            //    Console.WriteLine(nome +" " + sexo + " " + idade + " " + altura);
            //}
            //catch (Exception err)
            //{
            //    Console.WriteLine("Digite um numero inteiro "  + err.Message);


            //     Console.Read() ;

            //}

            //Console.WriteLine("Entre com seu nome completo:");
            //string nome = Console.ReadLine();
            //Console.WriteLine("Quantos quartos tem na sua casa?");
            //int qntQuartos = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com o preço de um produto:");
            //double precoProduto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            //Console.WriteLine("Entre seu último nome, idade e altura: ");
            //string[] vet = Console.ReadLine().Split(' ');
            //string ultimoNome = vet[0];
            //int idade = int.Parse(vet[1]);
            //double altura = double.Parse(vet[2],CultureInfo.InvariantCulture);

            //Console.WriteLine(nome);
            //Console.WriteLine(qntQuartos);
            //Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine(ultimoNome);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));



            //Console.Read(); // lê resultados na forma de string , oq for diferente de string ele n aceita

            //int n1 = 10;
            //int n2 = 30;

            //int result = n1 + n2;
            //Console.WriteLine(result);

            //int n3 = -30;
            //int n4 = 10;

            //int result1 = n3 + n4;
            //Console.WriteLine(result1);

            //int n5 = 0;
            //int n6 = 0;
            //int result2 = n5 + n6;

            //Console.WriteLine(result2);


            //double PI = 3.14159d;
            //double a = 2.00d;
            //double b = 100.64d;
            //double c = 150.00;

            //double area1 = PI * Math.Pow(a, 2.00);
            //double area2 = PI * Math.Pow(b, 2.00);
            //double area3 = PI * Math.Pow(c, 2.00);

            //Console.WriteLine(area1.ToString("F4"), CultureInfo.InvariantCulture);
            //Console.WriteLine(area2.ToString("F4"), CultureInfo.InvariantCulture);
            //Console.WriteLine(area3.ToString("F4"), CultureInfo.InvariantCulture);



            //var aa = Convert.ToInt32(Console.ReadLine());
            //var bb = Convert.ToInt32(Console.ReadLine());
            //var cc = Convert.ToInt32(Console.ReadLine());
            //var dd = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("DIFERENCA = " + (aa * bb - cc * dd).ToString());


            //var a = Convert.ToInt32(Console.ReadLine());
            //var b = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);
            //var c = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
            ////var d = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("NUMBER = " + (a).ToString());
            //Console.WriteLine("SALARY = U$ " + (b * c /** d*/).ToString("F2",CultureInfo.InvariantCulture));

            //string[] vet = Console.ReadLine().Split(' ');
            //int cod = int.Parse(vet[0], CultureInfo.InvariantCulture);
            //int numPecas = int.Parse(vet[1], CultureInfo.InvariantCulture);
            //double valorUni = double.Parse(vet[2],CultureInfo.InvariantCulture);

            //string[] vet2 = Console.ReadLine().Split(' ');
            //int cod1 = int.Parse(vet2[0], CultureInfo.InvariantCulture);
            //int numPecas1 = int.Parse(vet2[1], CultureInfo.InvariantCulture);
            //double valorUni1 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            //double resul1 = (numPecas * valorUni);
            //double result2 = (numPecas1 * valorUni1);
            //double result3 = result2 + resul1;

            //Console.WriteLine($"VALOR A PAGAR: R$ {result3.ToString("F2", CultureInfo.InvariantCulture)}");


            //string[] vet = Console.ReadLine().Split(' ');
            //double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            //double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            //double C = double.Parse(vet[2], CultureInfo.InvariantCulture);
            //double PI = 3.14159;


            //Console.WriteLine($"TRIANGULO: {((A * C)/2).ToString("F3", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"CIRCULO: {(Math.Pow(C , 2.00) * PI).ToString("F3", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"TRAPEZIO: {((((A + B)* C )/ 2)).ToString("F3", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"QUADRADO: {(Math.Pow(B , 2.00)).ToString("F3", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"RETANGULO: {(A * B).ToString("F3", CultureInfo.InvariantCulture)}");

            //int a = 10;

            //bool c1 = a < 10;
            //bool c2 = a < 20;
            //bool c3 = a > 10;
            //bool c4 = a > 5;

            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c3);
            //Console.WriteLine(c4);
            //Console.WriteLine("****************************************");

            //bool c5 = a <= 10;
            //bool c6 = a >= 10;
            //bool c7 = a == 10;
            //bool c8 = a != 10;

            //Console.WriteLine(c5);
            //Console.WriteLine(c6);
            //Console.WriteLine(c7);
            //Console.WriteLine(c8);,


            //bool c1 = 2 > 3 || 4 != 5; //true
            //bool c2 = !(2 > 3) && 4 != 5; //true
            //bool c3 = 10 < 5; //false
            //bool c4 = c1 || c2 && c3;

            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c3);
            //Console.WriteLine(c4);


            //int x = 10;

            //if (x > 5)
            //{
            //    Console.WriteLine("Bom dia");
            //}

            //Console.WriteLine("Boa tarde");
            //Console.WriteLine("Boa noite");


            //Console.WriteLine("Entre com um número inteiro: ");
            //double numero = double.Parse(Console.ReadLine());

            //if(numero % 2 == 0)
            //{
            //    Console.WriteLine("Numero Par!");
            //}
            //else
            //{
            //    Console.WriteLine("Numero Impar!");
            //}


            //Console.WriteLine("Qual a hora atual?");
            ////TimeSpan horaAtual = TimeSpan.FromHours(double.Parse(Console.ReadLine()));
            //int horaAtual = int.Parse(Console.ReadLine());

            //if (horaAtual < 12)
            //    Console.WriteLine("Bom dia");

            //else if (horaAtual < 18)
            //    Console.WriteLine("Boa Tarde");

            //else
            //    Console.WriteLine("Boa noite");

            //double preco = double.Parse(Console.ReadLine());
            //double desconto = 0.0;

            //if (preco > 100.0)
            //{
            //    desconto = preco * 0.1;
            //}
            //Console.WriteLine(desconto);

            //string[] entradas = Console.ReadLine().Split(' ');
            //int entrada1 = int.Parse(entradas[0]);
            //int entrada2 = int.Parse(entradas[1]);


            //int duracao = 0;

            //if (entrada1 >= 0 && entrada2 >= 0 && entrada1 <= 24 && entrada2 <= 24)
            //{
            //    if (entrada1 < entrada2)
            //    {
            //        duracao = entrada2 - entrada1;

            //    }
            //    else
            //    {
            //        duracao = 24 - entrada1 + entrada2;
            //    }

            //    Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
            //}
            //else
            //{
            //    Console.WriteLine("DIA EXCEDEU 24 HORAS");
            //}
            //    Console.WriteLine("Digite três números: ");
            //    int n1 = int.Parse(Console.ReadLine());
            //    int n2 = int.Parse(Console.ReadLine());
            //    int n3 = int.Parse(Console.ReadLine());

            //    //if (n1 > n2 && n1 > n3)
            //    //{
            //    //    Console.WriteLine("O Maior número é o {0}", n1);
            //    //}
            //    //else if (n2 > n1 && n2 > n3)
            //    //{
            //    //    Console.WriteLine("O Maior número é o {0}", n2);
            //    //}
            //    //else
            //    //{
            //    //    Console.WriteLine("O Maior número é o {0}" , n3);
            //    //}
            //    double resultado = Maior(n1, n2, n3);

            //    Console.WriteLine("O maior é o {0}", resultado);

            //    Console.ReadLine();
            //}

            //static int Maior(int a, int b, int c)
            //{
            //    int m;
            //    if (a > b && a > c)
            //    {
            //        m = a;
            //    }
            //    else if (b > c)
            //    {
            //        m = b;
            //    }
            //    else
            //    {
            //        m = c;
            //    }
            //    return m;


            //Console.WriteLine("Digite um número: ");

            //double numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double raizQuadrada = 0.0;

            //while (numero >= 0.0)
            //{
            //    raizQuadrada = Math.Sqrt(numero);
            //    Console.WriteLine("A raiz do número {0} é {1}", numero, raizQuadrada.ToString("F4", CultureInfo.InvariantCulture));
            //    Console.WriteLine("Digite outro numero: ");
            //    numero = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //}

            //Console.WriteLine("Numero negativo");




            //Console.WriteLine("Digite a senha: ");
            //int senha = int.Parse(Console.ReadLine());
            //int correta = 2002;

            //while (senha != correta)
            //{
            //    Console.WriteLine("Senha Invalida");
            //    Console.WriteLine("Digite a senha novamente");
            //    senha = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Acesso Permitido");



            //Console.WriteLine("Digite as coordenadas de X e Y : ");
            //string[] valores = Console.ReadLine().Split(' ');

            //int x = int.Parse(valores[0]);
            //int y = int.Parse(valores[1]);

            //while(x != 0 && y != 0)
            //{
            //    if (x > 0 && y > 0)
            //    {
            //        Console.WriteLine("primeiro");
            //    }
            //    else if (x < 0 && y < 0)
            //        Console.WriteLine("terceiro");

            //    if (x < 0 && y > 0)
            //    {
            //        Console.WriteLine("segundo");
            //    }
            //    else if (x > 0 && y < 0)
            //        Console.WriteLine("quarto");

            //    Console.WriteLine("Digite as coordenadas de X e Y : ");
            //    string[] valoress = Console.ReadLine().Split(' ');

            //     x = int.Parse(valoress[0]);
            //     y = int.Parse(valoress[1]);
            //}

            ////Console.WriteLine(" ");
            //Console.WriteLine("********************************");
            //Console.WriteLine("*        1.Álcool              *");
            //Console.WriteLine("*        2.Gasolina            *");
            //Console.WriteLine("*        3.Diesel              *");
            //Console.WriteLine("*        4.Fim                 *");
            //Console.WriteLine("********************************");
            //Console.WriteLine("Digite o código do combustível: ");

            //int alcool = 0;
            //int gasolina = 0;
            //int diesel = 0;
            //int fim = 4;
            //int combustivel = int.Parse(Console.ReadLine());

            //while (combustivel != fim)
            //{
            //    if (combustivel == 1)
            //    {
            //        alcool += 1;
            //    }
            //    if (combustivel == 2)
            //    {
            //        gasolina += 1;
            //    }
            //    else if (combustivel == 3)
            //    {
            //        diesel += 1;
            //    }
            //    combustivel = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("MUITO OBRIGADO");
            //Console.WriteLine($"Alcool: {alcool}");
            //Console.WriteLine($"Gasolina: {gasolina}");
            //Console.WriteLine($"Diesel: {diesel}");



            //Console.Write("Quantos números inteiros você vai digitar para soma? ");
            //int qtdeNumeros = int.Parse(Console.ReadLine());

            //int soma = 0;
            //for (int i = 1; i <= qtdeNumeros; i++)
            //{
            //    Console.Write($"Valor #{i}: ");
            //    int valor = int.Parse(Console.ReadLine());
            //    soma += valor;

            //}

            //Console.WriteLine($"Soma = {soma}");


            //Console.Write("Digite um numero de um a mil: ");
            //int numero = int.Parse(Console.ReadLine());


            //int i;

            //for (i = 1; i <= numero; i++)
            //{
            //    bool par = i % 2 == 0;

            //    if (!par)
            //    {
            //        Console.WriteLine(i);
            //    }


            //}

            //Console.WriteLine("Numeros inteiros dentro e fora do intervalo [10,20]");
            //Console.Write("Digite a quantidade de números que será digitado: ");

            //int dentro = 0;
            //int fora = 0;
            //int numeros = int.Parse(Console.ReadLine());


            //for (int i = 1; i <= numeros ; i++)
            //{
            //   int numero = int.Parse(Console.ReadLine());
            //    if (numero >= 10 && numero <= 20)
            //    {
            //        dentro += 1;
            //    }
            //    else
            //    {
            //        fora += 1;
            //    }
            //}

            //Console.WriteLine($"{dentro} in");
            //Console.WriteLine($"{fora} out");

            //Console.Write("Digite o numero de conjuntos para a média ponderada: ");
            //int numero = int.Parse(Console.ReadLine());
            //double media = 0.0;

            //Console.WriteLine("Digite as médias :");

            //for (int i = 1; i <= numero; i++)
            //{
            //    string[] valores = Console.ReadLine().Split(' ');
            //    double v1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            //    double v2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            //    double v3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //    double soma = v1 + v2 + v3;

            //    media = soma / numero;
            //    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            //}



            //Console.WriteLine("Entre com as medidas do triângulo X :" );
            //double xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double X = 0;

            //Console.WriteLine("Entre com as medidas do triângulo Y :");
            //double yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double Y = 0;

            //double xP = (xA + xB + xC) / 2.0;
            //double areaX = Math.Sqrt(xP * ((xP - xA) * (xP - xB) * (xP - xC)));

            //double yP = (yA + yB + yC) / 2.0;
            //double areaY = Math.Sqrt(yP * ((yP - yA) * (yP - yB) * (yP - yC)));

            //double maior = 0.0;

            //if (areaX > areaY)
            //     maior = areaX;
            //else
            //    maior = areaY;



            //Console.WriteLine($"A area do Triângulo X: {areaX:F2}",CultureInfo.InvariantCulture);
            //Console.WriteLine($"A area do Triângulo Y: {areaY:F2}", CultureInfo.InvariantCulture);
            //Console.WriteLine($"A maior area: {maior:F2}", CultureInfo.InvariantCulture);




            //Triangulo x, y;
            //x = new Triangulo();
            //y = new Triangulo();

            // Triangulo x = new Triangulo();
            // Triangulo y = new Triangulo();


            // Console.WriteLine("Entre com as medidas do triângulo X :" );
            // x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Console.WriteLine("Entre com as medidas do triângulo Y :");
            // y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            // //double xP = (x.A + x.B + x.C) / 2.0;
            // //double areaX = Math.Sqrt(xP * ((xP - x.A) * (xP - x.B) * (xP - x.C)));

            // //double yP = (y.A + y.B + y.C) / 2.0;
            // //double areaY = Math.Sqrt(yP * ((yP - y.A) * (yP - y.B) * (yP - y.C)));

            //double areaX = x.Area();
            //double areaY = y.Area();


            // double maior = 0.0;

            // if (areaX > areaY)
            //     maior = areaX;
            // else
            //     maior = areaY;



            // Console.WriteLine($"A area do Triângulo X: {areaX:F2}", CultureInfo.InvariantCulture);
            // Console.WriteLine($"A area do Triângulo Y: {areaY:F2}", CultureInfo.InvariantCulture);
            // Console.WriteLine($"A maior area: {maior:F2}", CultureInfo.InvariantCulture);



            //Pessoas x, y;
            //x = new Pessoas();
            //y = new Pessoas();

            //Console.WriteLine("Dados da primeira pessoa:");
            //Console.Write("Nome: ");
            //x.nome = Console.ReadLine();

            //Console.Write("Idade: ");
            //x.idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dados da segunda pessoa:");
            //Console.Write("Nome: ");
            //y.nome = Console.ReadLine();

            //Console.Write("Idade: ");
            //y.idade = int.Parse(Console.ReadLine());

            //if (x.idade > y.idade)
            //{
            //    Console.WriteLine("Pessoa mais velha: {0}", x.nome);
            //}
            //else
            //{
            //    Console.WriteLine("Pessoa mais velha: {0}", y.nome);
            //}


            ////Funcionario x, y;
            //Funcionario x = new Funcionario();
            //Funcionario y = new Funcionario();


            //Console.WriteLine("Dados do primeiro funcionário");
            //Console.Write("Nome: ");
            //x.Nome = Console.ReadLine();
            //Console.Write("Salário: ");
            //x.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine("Dados do segundo funcionário");
            //Console.Write("Nome: ");
            //y.Nome = Console.ReadLine();
            //Console.Write("Salário: ");
            //y.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double medio = (x.Salario + y.Salario) / 2.0;


            //Console.WriteLine("O Salário médio = {0}", medio);

            Produto prod = new Produto();

            Console.WriteLine("Entre com os dados do Produto");
            Console.Write("Nome: ");
            prod.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            prod.Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("Quantidade no Estoque: ");
            prod.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do Produto: {prod.Nome}, ${prod.Preco:F2} , {prod.Quantidade} unidades, Total: ${prod.ValorTotalEmEstoque()}");

            Console.Write("Digite o numero de produtos a ser adicionado ao estoque: ");
            int adicionar = int.Parse(Console.ReadLine());
            Console.WriteLine($"Dados atualizados: {prod.Nome}, ${prod.Preco:F2} , {prod.AdicionarProdutos(adicionar)} unidades, Total: ${prod.ValorTotalEmEstoque()}");

            Console.Write("Digite o numero de produtos a ser removido do estoque: ");
            int remover = int.Parse(Console.ReadLine());
            Console.WriteLine($"Dados atualizados: {prod.Nome}, ${prod.Preco:F2} , {prod.RemoverProdutos(remover)} unidades, Total: ${prod.ValorTotalEmEstoque()}");


            Console.ReadLine();
        }
    }
}
