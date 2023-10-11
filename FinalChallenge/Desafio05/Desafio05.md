### Questão 5

Analise o código a seguir.

``` csharp
    for(int i = - 5; i <= 7; i += 3)
    {
        Console.WriteLine(i);
    }
```

Assinale a opção que apresenta corretamente o resultado produzido pela execução do trecho acima. Justifique o porque dessa opção.

Opções:

<br> A) -2, 1, 4, 7, 10
<br> B) -5, -2, 1, 4, 10
<br> C) -2, 1, 4, 7
<br> D) -5, -2, 1, 4
<br> E) -5, -2, 1, 4, 7

### Resposta

A resposta correta é a letra E) -5, -2, 1, 4, 7.

A cada interação, i é incrementado em 3 unidades. A impressão segue a sequência de incremento da variável `i`.

O loop se inicia com `i == -5`, que será impresso.
<br> Em seguida, `i == -2`, que será impresso.
<br> Em seguida, `i == 1`, que será impresso.
<br> Em seguida, `i == 4`, que será impresso.
<br> Em seguida, `i == 7`, que será impresso, pois a condição dentro do `for ` continua sendo verdadeira.
<br> Em seguida, `i == 10`, que está fora dos limites da condição expressa para continuidade da estrutura de repetição `for`, logo, o bloco de código interior não será executado e não será impresso o valor `10`.

O comando `Console.WriteLine()` na linguagem C#, imprime na tela com uma linha abaixo os parâmetros que recebe. Neste caso, a função recebe a variável `i`.

Logo, temos a seguinte sequência de impressao:

```
    -5
    -2
    1
    4
    7
```