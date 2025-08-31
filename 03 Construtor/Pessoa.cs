class Pessoa
{
    // Primeiro construtor
    public Pessoa()
    {
        Console.WriteLine("Hello World!!!");
    }

    // Segundo contrutor
    public Pessoa(string nome)
    {
        Console.WriteLine($"Olá {nome}");
    }

    // Terceiro construtor
    public Pessoa(string nome, int idade)
    {
        Console.WriteLine($"Você {nome} tem {idade} anos");
    }
}