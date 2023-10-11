/*
PROBLEMA 2

Escreva um programa que calcule e escreva a multiplicação e a divisão inteira de dois números inteiros, N1 por N2, que devem ser lidos do teclado. É importante observar que a máquina que irá executar este programa é capaz de efetuar apenas duas operações matemáticas: adição e subtração. Ou seja, você não poderá usar os operadores de multiplicação, divisão, módulo etc. bem como truncamentos.

*/

using MyFunctionsLibrary;

class Desafio02
{
    static void Main(string[] args)
    {
        // MyFunctions.HelloWorld(); // testando se a classe de funções está sendo importada corretamente

        Console.Clear();
        Console.WriteLine("Este programa realiza as operações de multiplicação e divisão entre dois números inteiros utilizando apenas as operações de adição e subtração.");
        MyFunctions.GoOn();

        bool readNumbers = true;

        while(readNumbers)
        {
            Console.Clear();

            Console.WriteLine("Digite 2 números inteiros:\n");

            int N1, N2, product;
            int[] divisionResult = new int[2];

            N1 = MyFunctions.ReadIntWithIndex("Número", 1);
            N2 = MyFunctions.ReadIntWithIndex("Número", 2);

            product = MyFunctions.MultiplyWithAddition(N1, N2);

            if(N2 != 0) divisionResult = MyFunctions.DivideWithSubtration(N1, N2);

            Console.WriteLine($"\n{N1} vezes {N2} = {product}");
            Console.Write((N2 != 0) ? $"\n{N1} dividido por {N2} = {divisionResult[0]}" : "\nNão é possível realizar divisão por zero.");
            Console.Write((divisionResult[1] > 0) ? $", com resto = {divisionResult[1]}" : "\n");
            
            readNumbers = MyFunctions.ReadYesOrNo("Testar novo conjunto");
        }        
    }
}