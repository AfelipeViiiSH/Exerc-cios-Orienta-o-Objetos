/* EXERCÍCIO 01 - Criar uma classe Produto, contendo os atributos:
a) nome
b) valor
c) forma de pagamento

Haverá um método público para retornar essas três características,
além de um possível desconto. Haverá desconto de 10% se o valor de 
venda for de pelo menos R$500,00 e se for á vista.

Vamos utilizar: Classe, atributo, método, objeto e encapsulamento.
*/

// Criar um objeto


Produto obj = new();


obj.Nome = "Smartphone";
obj.Valor = 1000;
obj.FormaPagamento = "Á vista";
obj.Mensagem();
