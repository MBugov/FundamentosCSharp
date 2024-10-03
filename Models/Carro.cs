using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// O namespace é usado como um organizador
namespace ExemploFundamentos.Models;

// Exemplo de uma classe com propriedades e métodos
public class Carro
{   
    //propriedade
    public string ? Nome { get; set; }
    public int Kilometragem { get; set; }

    //método
    public void Partida()
    {
        // o WriteLine é um método da classe Console, e estamos passando um parametro ou argumento.
        Console.WriteLine($"O {Nome} deu partida com {Kilometragem} kilometros rodados !");
    }
}
