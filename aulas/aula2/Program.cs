//Para definir variáveis é sempre este método: Tipo>Nome>Atribuição
//Dá para definir de duas formas diferentes, a direta e a desmanchada
/*Tipos de Valores:
int: Inteiro;
long: Numeros longos;
byte: inteiros sem sinal (0 a 255);
float: números quebrados curtos (uma casa após o inteiro);
double: números quebrados médios (duas casas após o inteiro);
decimal: números quebrados longos (ótimos para valores financeiros);
bool: Verdadeiro ou Falso;
char: Caracter único (ex: 'A')

entre outros tipos...
*/
string nome = "João";

int idade;
idade= 16;

int val1= 2;
int val2= 5;

int resultado= val1+val2;

//double é o famoso float, a variável final precisa ser do mesmo tipo que as variáveis para não dar erro
double valor= 1.56;
double valor1= 1.5;

double resultado1= valor+valor1;

Console.WriteLine(nome);
Console.WriteLine(idade);
Console.WriteLine(resultado);
Console.WriteLine(resultado1);