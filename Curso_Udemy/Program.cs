﻿using System.Globalization;

static void Aula22()
{
    string x = Console.ReadLine();

    string[] vetor = x.Split(' ');

    Console.WriteLine(vetor[1]);
}
static void Aula23()
{
    string[] dadosPessoa = Console.ReadLine().Split(' ');

    string nome = dadosPessoa[0];
    char sexo = char.Parse(dadosPessoa[1]);
    int idade = int.Parse(dadosPessoa[2]);
    double altura = double.Parse(dadosPessoa[3], CultureInfo.InvariantCulture);

    Console.WriteLine($"{nome} se identifica com o sexo {sexo}, tem {idade} anos e {altura.ToString("F2", CultureInfo.InvariantCulture)}m de altura.");
}
static void Aula27()
{
    int x = int.Parse(Console.ReadLine());

    if(x % 2 == 0)
    {
        Console.WriteLine("Par!");
    }else
    {
        Console.WriteLine("Ímpar!");
    }
}
static void Aula28()
{
    int x = int.Parse(Console.ReadLine());

    if (x < 12)
    {
        Console.WriteLine("Bom dia!");
    }
    else if (x < 18)
    {
        Console.WriteLine("Boa tarde!");
    }
    else
    {
        Console.WriteLine("Boa noite!");
    }
}

Aula27();

    
