/*
PROBLEMA 1

Escreva um programa que faça a leitura de 5 valores Inteiros do usuário. Em seguida, o programa deve exibir no console a informação de quantos dos valores digitados são pares, quantos dos valores digitados são ímpares, quantos deles são positivos e, por fim, quantos são negativos. Cada uma das informações deve ser escrita em uma linha diferente.

*/

using MyFunctionsLibrary;

class Desafio01
{
    static void Main(string[] args)
    {
        // MyFunctions.HelloWorld(); // testando se a classe de funções está sendo importada corretamente

        Console.Clear();
        Console.WriteLine("Este programa exibe informações sobre conjuntos de números com 5 elementos.");
        MyFunctions.GoOn();

        bool readNumbers = true;

        while(readNumbers)
        {
            Console.Clear();

            Console.WriteLine("Digite 5 números inteiros (digite um número por linha)\n");

            int[] intArray = new int[5];

            intArray = MyFunctions.ReadIntArray(intArray.Length);
            
            MyFunctions.DescribeIntArray(intArray);

            readNumbers = MyFunctions.ReadYesOrNo("Testar novo conjunto");
        }        
    }
}