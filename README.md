# Fundamentos Básicos de C#

C# é uma linguagem de programação orientada a objetos, fortemente tipada, desenvolvida pela Microsoft como parte da plataforma .NET. É amplamente utilizada para criar uma variedade de aplicações, como software de desktop, aplicativos web e jogos.

## Índice

1. [Hello World](#hello-world)
2. [Tipos de Dados](#tipos-de-dados)
3. [Variáveis](#variáveis)
4. [Operadores](#operadores)
5. [Estruturas de Controle](#estruturas-de-controle)
6. [Métodos](#métodos)
7. [Classes e Objetos](#classes-e-objetos)
8. [Herança](#herança)
9. [Polimorfismo](#polimorfismo)
10. [Encapsulamento](#encapsulamento)
11. [Exceções](#exceções)

## 1. Hello World

O exemplo clássico de `Hello World` em C#:

```csharp
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}
```

Neste código:

using System; importa o namespace System, que contém a classe Console.
Console.WriteLine() é usado para exibir uma mensagem no console.

## 2. Tipos de Dados

C# suporta vários tipos de dados. Alguns exemplos incluem:

- int: números inteiros (e.g., int idade = 25;)
- float: números de ponto flutuante de precisão simples (e.g., float altura = 1.75f;)
- double: números de ponto flutuante de precisão dupla (e.g., double peso = 70.5;)
- bool: valores booleanos (true ou false)
- string: sequência de caracteres (e.g., string nome = "João";)

## 3. Variáveis
Para declarar uma variável, especificamos o tipo seguido pelo nome da variável e, opcionalmente, um valor inicial:

```csharp
int idade = 30;
string nome = "Maria";
bool isAluno = true;
```
## 4. Operadores
C# tem uma ampla gama de operadores, como:

- Aritméticos: `+, -, *, /, %`
- Comparação: `==, !=, <, >, <=, >= `
- Lógicos: `&& (E), || (OU), ! (NÃO)`

Exemplo:

```csharp
int a = 10;
int b = 20;

bool resultado = (a < b);  // true
```
## 5. Estruturas de Controle

#### Condicionais

Usamos if, else if e else para controle condicional.
```csharp
int idade = 18;

if (idade >= 18)
{
    Console.WriteLine("Maior de idade");
}
else
{
    Console.WriteLine("Menor de idade");
}
```

#### Laços de Repetição

`for`

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

```

`while`

```csharp
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}
```


## 6. Métodos

Um método é um bloco de código que realiza uma tarefa específica. Podemos definir métodos com ou sem parâmetros, e com ou sem valor de retorno.

```csharp
public int Somar(int a, int b)
{
    return a + b;
}

```

##### Chamando o método:

```csharp
int resultado = Somar(2, 3);
Console.WriteLine(resultado);  // 5

```

## 7. Classes e Objetos

C# é uma linguagem orientada a objetos, o que significa que podemos criar classes e instanciar objetos.

##### Definindo uma Classe:

```csharp
class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos.");
    }
}
```