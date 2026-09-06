//Operadores de Comparação e Inputs

//Input muda o WriteLine para apenas Write
Console.Write("Digite seu Nome: ");
string nome= Console.ReadLine();
Console.WriteLine("Olá, "+ nome);

Console.Write("Digite um Número: ");
//Converte o valor escrito do tipo string para o tipo inteiro
int a= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Número: " + a);

Console.Write("Digite Outro Número: ");
int b= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Número: " + b);

bool isequal= a==b;
Console.WriteLine(isequal);

isequal= a!=b;
Console.WriteLine(isequal);

isequal= a<b;
Console.WriteLine(isequal);

isequal= a>b;
Console.WriteLine(isequal);

isequal= a>=b;
Console.WriteLine(isequal);

isequal= a<=b;
Console.WriteLine(isequal);