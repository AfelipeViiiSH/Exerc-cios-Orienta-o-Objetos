class Pessoa
{

    // Atributos
    private string? _nome;
    private int _idade;
    private string? _cidade;

    // Construtor ------- sempre usando o mesmo nome da classe
    public Pessoa(string nome, int idade, string cidade)
    {
        _nome = nome;
        _idade = idade;
        _cidade = cidade;

        Mensagem();
    }

    // Método mensagem
    private void Mensagem()
    {
        Console.WriteLine($"{_nome} mora em {_cidade} e tem {_idade} anos.");
    }

}