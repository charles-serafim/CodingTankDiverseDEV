using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

/* Funções úteis para reutilização */
/* Autoria: Charles Serafim Morais */

namespace MyFunctionsLibrary
{

    public class MyFunctions
    {
        /* Testando a adição da biblioteca */

        public static void HelloWorld()
        {
            Console.Clear();
            Console.WriteLine("Hello, World! Biblioteca de funções pronta para uso.");

            GoOn();
        }


        /* NÚMEROS */

        /* static double ReadNumber() // sem try-catch
        {
            double number;

            while(true)
            {
                if(number = double.TryParse(Console.ReadLine())) break; // sai do loop se a leitura for feita com sucesso

                Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                Console.WriteLine();
            }
            
            return number;
        } */

        public static int ReadInt() // com try-catch // usada no desafio
        {
            int number;

            while(true)
            {
                try
                {
                    number = int.Parse(Console.ReadLine());
                    break;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                    Console.WriteLine();
                }
            }

            return number;
        }

        public static double ReadDouble() // com try-catch
        {
            double number;

            while(true)
            {
                try
                {
                    number = double.Parse(Console.ReadLine());
                    break;
                }
                catch(FormatException)
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número.");
                    Console.WriteLine();
                }
            }

            return number;
        }

        public static int[] ReadIntArray(int arraySize)
        {
            int[] intArray = new int[arraySize];

            for(int i = 0; i < arraySize; i++) intArray[i] = ReadIntWithIndex("Número", i+1);

            return intArray;
        }

        public static int ReadIntWithIndex(string objectDescription, int i) // usada no desafio
        {
            int number;

            Console.Write($"{objectDescription} {i} = ");

            number = ReadInt();

            return number;
        }

        public static double ReadDoubleWithIndex(string objectDescription, int i)
        {
            double number;

            Console.WriteLine($"{objectDescription} {i}: ");

            number = ReadDouble();

            return number;
        }

        public static int ReadIntInRange(int min, int max)
        {
            int number;

            while(true)
            {
                number = ReadInt();

                if(number >= min && number <= max) break;

                Console.WriteLine($"A entrada deve ser algum número entre {min} e {max}. Digite novamente.\n");
            }

            return number;
        }

        public static double ReadDoubleInRange(int min, int max)
        {
            double number;

            while(true)
            {
                number = ReadDouble();

                if(number >= min && number <= max) break;

                Console.WriteLine($"A entrada deve ser algum número entre {min} e {max}. Digite novamente.\n");
            }

            return number;
        }

        public static int MultiplyWithAddition(int N1, int N2) // usada no desafio
        {
            if(N1 == 0 || N2 == 0) return 0;

            int unsignedN1, unsignedN2, result = 0;

            unsignedN1 = MakeUnsigned(N1);
            unsignedN2 = MakeUnsigned(N2);

            for(int i = 0; i < unsignedN2; i++) result = result + unsignedN1;

            if((N1 < 0 && N2 > 0) || (N2 < 0 && N1 > 0)) result = result - result - result;

            return result;
        }
        
        public static int[] DivideWithSubtration(int N1, int N2) // usada no desafio
        {
            int[] result = new int[2];

            if(N2 == 0)
            {
                result[0] = 0;
                result[1] = 0;
                return result;
            } 

            int unsignedN1, unsignedN2, divideCount = 0, rest;

            unsignedN1 = MakeUnsigned(N1);
            unsignedN2 = MakeUnsigned(N2);

            while(unsignedN1 >= 0)
            {
                unsignedN1 -= unsignedN2;
                if(unsignedN1 >= 0) divideCount++;
            }

            rest = unsignedN1 - unsignedN1 - unsignedN1;

            if((N1 < 0 && N2 > 0) || (N2 < 0 && N1 > 0))
            {
                divideCount = divideCount - divideCount - divideCount;
            }
            

            result[0] = divideCount;
            result[1] = rest;

            return result;
        }

        public static int MakeUnsigned(int N) // usada no desafio
        {
            int unsignedN = (N > 0) ? N : N - N - N;
            return unsignedN;
        }

        public static void DescribeIntArray(int[] intArray) // usada no desafio
        {
            Console.Clear();

            // imprime a lista dos numeros
            string formattedArray = string.Join(", ", intArray);
            Console.WriteLine("Conjunto: {" + formattedArray + "}\n");

            // inicializa e incrementa contadores
            int oddCount = 0, evenCount = 0, positives = 0, negatives = 0;
            foreach(int number in intArray)
            {
                if(number % 2 == 0) evenCount++;
                else oddCount++;

                if(number >= 0) positives++;
                else negatives++;
            }

            Console.WriteLine("Descrição do conjunto:\n");
            Console.WriteLine($"Quantidade de números pares: {evenCount}");
            Console.WriteLine($"Quantidade de números ímpares: {oddCount}");
            Console.WriteLine($"Quantidade de números positivos: {positives}");
            Console.WriteLine($"Quantidade de números negativos: {negatives}");
        }



        /* UTILIDADES */

        public static bool ReadYesOrNo(string question) // usada no desafio
        {
            Console.WriteLine($"\n{question}? (s/n)");

            while(true)
            {
                string option = Console.ReadLine()?.ToLower();

                if(Regex.IsMatch(option, "^(s(im)?|n(ao|ão)|n(ao)?o?)$")) return option.StartsWith("s");

                Console.WriteLine("Entrada inválida.");
                Console.WriteLine($"{question}? (s/n)");
                Console.WriteLine();
            }
        }

        public static void GoOn() // usada no desafio
        {
            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void PrintList(List<Type> objectList, string listDescription, string typeDescription)
        {
            int count = 1;
            Console.WriteLine($"{listDescription}:");
            Console.WriteLine();

            foreach(Type objectInstance in objectList)
            {
                Console.WriteLine($"{count:D3} - {typeDescription}: {objectInstance}");
                count++;
            }
            
            Console.WriteLine();
        }


        /* STRINGS */

        public static void DescribeString(string phrase) // usada no desafio
        {
            Console.Clear();

            string[] words = Regex.Split(phrase, @"[\W\d]+");

            
            // inicializa e incrementa contadores e variáveis auxiliares
            bool allUpper, allLower;
            char letter, firstLetter;
            int wordCount = 0, upperFirstLetter = 0, lowerFirstLetter = 0, upperAllLetters = 0, lowerAllLetters = 0, hybridWords = 0;;

            Console.WriteLine($"Sua frase:\n\n{phrase}");
            
            // verifica as primeiras letras de cada palavra e todas as letras de cada palavra
            foreach(string word in words)
            {
                allUpper = true;
                allLower = true;

                if(word.Length > 0)
                {
                    wordCount++;
                    
                    firstLetter = word[0];
                    if(char.IsLower(firstLetter)) lowerFirstLetter++;
                    else upperFirstLetter++;

                    for(int i = 0; i < word.Length; i++)
                    {
                        letter = word[i];
                        if(char.IsLower(letter)) allUpper = false;
                        if(char.IsUpper(letter)) allLower = false;
                    }

                    if(allLower) lowerAllLetters++;
                    if(allUpper) upperAllLetters++;
                    if(!allLower && !allUpper) hybridWords++;
                }
            }

            Console.WriteLine("\n\nDescrição da frase:\n");
            Console.WriteLine($"Quantidade de palavras na frase: {wordCount}");
            Console.WriteLine($"Quantidade de palavras maiúsculas: {upperAllLetters}");
            Console.WriteLine($"Quantidade de palavras minúsculas: {lowerAllLetters}");
            Console.WriteLine($"Quantidade de palavras híbridas: {hybridWords}");
            Console.WriteLine($"Quantidade de palavras que iniciam com letra maiúscula: {upperFirstLetter}");
            Console.WriteLine($"Quantidade de palavras que iniciam com letra minúscula: {lowerFirstLetter}");
        }

        public static string ReadWithPattern(string pattern)
        {
            string entry;

            while(true)
            {
                entry = Console.ReadLine();

                if(Regex.IsMatch(entry, pattern)) break;

                Console.WriteLine("Entrada inválida. Digite novamente.\n");
            }

            return entry;
        }

        public static string FormatString(string entry)
        {
            entry = RemoveAccents(entry);
            entry = RemoveSpecialCharacters(entry);
            entry = RemoveSpaces(entry);
            entry = entry.ToLower();

            return entry;
        }

        public static string RemoveAccents(string entry)
        {
            string result = new string(
                entry
                    .Normalize(NormalizationForm.FormD)
                    .Where(ch => CharUnicodeInfo.GetUnicodeCategory(ch) != UnicodeCategory.NonSpacingMark)
                    .ToArray()
            );
            return result;
        }

        public static string RemoveSpecialCharacters(string entry)
        {
            string pattern = @"[^\w\s]";
            string result = Regex.Replace(entry, pattern, string.Empty);
            return result;
        }

        public static string RemoveSpaces(string entry)
        {
            string result = entry.Replace(" ", "");
            return result;
        }


        /* INICIALIZAÇÃO ALEATÓRIA */

        public static void InitializeIntArray(int[] array, int limit)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(limit);
        }

        public static void InitializeDoubleArray(double[] array, double limit)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = random.NextDouble() * limit;
        }

    }
}