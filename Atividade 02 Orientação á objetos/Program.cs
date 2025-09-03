/*
    EXERCÍCIO 02

    - Criar uma classe Aluno, contendo os atributos:
        a) nome
        b) nota1
        c) nota2

    Haverá três métodos, sendo dois privados e um público:
    Media: Método privado para retornar a média do aluno.
    Situação: Método privado para retornar se está aprovado ou reprovado.
    Mensagem: Método publico para retornar o nome, média e situação.

    - Vamos utilizar: Classe, atributo, método, objeto e encapsulamento.    
*/

// Criar objeto
Aluno obj = new();
obj.Nome = "Ralf";
obj.Nota1 = 8;
obj.Nota2 = 10;
obj.Mensagem();
