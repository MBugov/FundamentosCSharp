using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Models;

// Exemplo de uma classe com propriedades e métodos
public class Carro
{   
    //propriedades
    public string ? Nome { get; set; }
    public int Kilometragem { get; set; }

    //metodos
    public void Partida()
    {
        Console.WriteLine($"O {Nome} deu partida com {Kilometragem} kilometros rodados !");
    }
}
