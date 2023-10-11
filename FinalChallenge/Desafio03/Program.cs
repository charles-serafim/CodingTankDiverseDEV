/*
PROBLEMA 3

Escreva um programa que recebe como entrada uma frase do usuário. Como saída o programa deve exibir no console as seguintes informações: quantas palavras são maiúsculas, quantas palavras são minúsculas, quantas palavras iniciam com letra maiúscula, quantas palavras iniciam com letra minúscula e a quantidade de palavras.

*/

using MyFunctionsLibrary;
using System.Text.RegularExpressions;

class Desafio03
{
    static void Main(string[] args)
    {
        // MyFunctions.HelloWorld(); // testando se a classe de funções está sendo importada corretamente

        Console.Clear();
        Console.WriteLine("Este programa analisa uma frase e responde as seguintes questões:\n");
        Console.WriteLine("- Quantas palavras são maiúsculas");
        Console.WriteLine("- Quantas palavras são minúsculas");
        Console.WriteLine("- Quantas palavras são híbridas (possuem letras maiúsculas e letras minúsculas)");
        Console.WriteLine("- Quantas palavras iniciam com letras maiúsculas");
        Console.WriteLine("- Quantas palavras iniciam com letras minúsculas");
        Console.WriteLine("- Quantidade de palavras na frase");
        MyFunctions.GoOn();

        bool readString = true;

        while(readString)
        {
            Console.Clear();

            Console.WriteLine("Digite uma frase:\n");

            string phrase = Console.ReadLine();

            // string phrase = "Esta é uma frase, com! caracteres especiais... E ALGUMAS palavras EM MAIUSCULO... para teste!";

            MyFunctions.DescribeString(phrase);

            // foreach(string word in words) Console.WriteLine($"{word}");
            
            readString = MyFunctions.ReadYesOrNo("Testar nova frase");
        }        
    }
}