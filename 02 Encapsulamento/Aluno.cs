class Aluno
{
    // Primeira maneira
    private string? _nome; // Atributo privado começa com underline
    public string? nome
    {

        get { return _nome; }
        set { _nome = value; }
    }

    // Segunda maneira
     public double Media { get; set; }
}