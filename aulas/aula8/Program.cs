//IF, ELSE IF E ELSE

Console.Write("Digite sua Idade: ");
int idade= Convert.ToInt32(Console.ReadLine());


if (idade >= 18)
{
    Console.WriteLine("Acesso Autorizado");
}else if (idade == 17)
{
    Console.WriteLine("Pode entrar com permissão dos pais!");
    Console.Write("Tem Permissão dos Pais (Para adolescentes de 17 anos apenas!): ");
    string permissao;
    permissao= Console.ReadLine();
    
    if (permissao == "sim")
    {
        Console.WriteLine("Pode entrar!");
    }
    else
    {
        Console.WriteLine("Não pode Entrar!");
    }
}
else
{
    Console.WriteLine("Acesso Negado");
}