//Switch
Console.Write ("Diga um dia da semana: ");
int dia;
dia= Convert.ToInt32(Console.ReadLine());

//switch substitui esse if enorme

/*if (dia == 1)
{
    Console.WriteLine("É Domingo!");
}else if (dia == 2){
    Console.WriteLine("É Segunda!");
}else if (dia == 3){
    Console.WriteLine("É Terça!");
}else if (dia == 4){
    Console.WriteLine("É Quarta!");
}else if (dia == 5){
    Console.WriteLine("É Quinta!");
}else if (dia == 6){
    Console.WriteLine("É Sexta!");
}else if (dia == 7){
    Console.WriteLine("É Sábado!");
}
else
{
    Console.WriteLine("Dia Inválido!");
}*/

switch (dia)
{
    case 1:
        Console.WriteLine("É Domingo!");
        break;
    
    case 2:
        Console.WriteLine("É Segunda!");
        break;
    
    case 3:
        Console.WriteLine("É Terça!");
        break;
    
    case 4:
        Console.WriteLine("É Quarta!");
        break;
    
    case 5:
        Console.WriteLine("É Quinta!");
        break;
    
    case 6:
        Console.WriteLine("É Sexta!");
        break;
    
    case 7:
        Console.WriteLine("É Sábado!");
        break;
    
    default:
        Console.WriteLine("Dia Inválido!");
        break;
}