// Exemplo 01
Pessoa obj1 = new Pessoa();
obj1.Nome = "Ralf";
//obj1.Apresentação();

Pessoa obj2 = new Pessoa();
obj2.Nome = "Stella";
//obj2.Apresentação();

// Exemplo 03
Pessoa obj3 = new()
{
    Nome = "Ricardo",
    Idade = 23
};
string retorno = obj3.VerificarIdade();
Console.WriteLine(retorno);
