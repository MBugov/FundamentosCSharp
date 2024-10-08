// See https://aka.ms/new-console-template for more information
using ExemploFundamentos.Models;

// instaciando a classe
var carro = new Carro();

// chamando o metodo da classe Carro
carro.Partida("Classic", 16522);

// --------------------------------------------------------
// Outra forma de instanciar:
Carro carro1 = new Carro(); 

carro1.Nome = "HB20";
carro1.Kilometragem = 51000;
carro1.Partida(carro1.Nome, carro1.Kilometragem);

//ou
carro1.Partida("Tucson", 85000);

// ------------------- Conversao segura -------------------

string variavelA = "15";
int variavelB;

if (int.TryParse(variavelA, out variavelB))
{
    Console.WriteLine("Conversão realizada com sucesso: " + variavelB);
}
else
{
    Console.WriteLine("Falha na conversão");
}

// ------------------- Estrutura condicional -------------------

int quantidadeEmEstoque = 15;
int quantidadeCompra = 11;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"É possivel realizar a vendas: {possivelVenda} ");

if (possivelVenda)
{
    Console.WriteLine("Venda autorizada!");
}
else
{
     Console.WriteLine("Venda negada! \n Não temos a quantidade suficiente em estoque!");
}