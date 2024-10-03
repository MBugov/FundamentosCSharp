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