class Pessoa
{
    // Atributos
    public string? Nome;
    public int Idade;

    // Métodos de apresentação
    public void Apresentação()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}");
    }

    // Método para retornar a situação da idade

    public string VerificarIdade()
    {
        return Idade >= 18 ? "Maior de idade" : "Menor de idade";
    }


}