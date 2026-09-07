//Operadores Lógicos
bool usuariovalido= true;
bool senhavalida= false;

//&& operador logico and
bool resultado= usuariovalido && senhavalida;
Console.WriteLine(resultado);

// || operador logico or
resultado= usuariovalido || senhavalida;
Console.WriteLine(resultado);

// ! antes da variável é o operador lógico no
resultado= !usuariovalido && !senhavalida;
Console.WriteLine(resultado);