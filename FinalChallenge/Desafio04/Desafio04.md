### Questão 4

Ao executar o código a seguir será exibido qual valor no terminal? Justifique sua resposta.

``` csharp
    Int32 numero;
    numero = Convert.ToInt16(!(21 > 21));
    Console.WriteLine(numero);
```

Opções:

<br> A) -1;
<br> B) 0;
<br> C) 1;
<br> D) 21;
<br> E) irá dar erro

### Resposta

A resposta correta é a letra C) 1.

Justificativa:

A primeira coisa que é feita no bloco de código é a inicialização de uma variável chamada `numero` que pode guardar um inteiro de até 32 bits. Ela vai receber posteriormente o valor definido pelas expressões na linha seguinte.

No trecho `(21 > 21)` está sendo feita uma comparação - se 21 é maior do que 21. A resposta a esse trecho é false. Junto a esta comparação, há o símbolo `!`, que é o operador lógico NOT e inverte a sentença que o segue. Logo, `(!(21 > 21))` será o resultado de `(21 > 21)` invertido, ou seja, true.

A operação feita com este valor, descrita por `Convert.ToInt16`, converte o valor lógico para um inteiro de até 16 bits, sendo convertido para 1. Em seguida, é feita a atribuição deste valor à variável `numero`, e a atribuição ocorre sem problemas porque a mesma é uma variável `Int32`, logo, se cabem 32 bits, cabem 16.

A última linha é o comando `Console.WriteLine()` na linguagem C#, que imprime na tela com uma linha abaixo os parâmetros que recebe. Neste caso, a função recebe a variável `numero`, de valor `1`. Portanto, é impresso na tela o valor 1, letra C.