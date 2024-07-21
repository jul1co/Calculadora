# Calculadora

## Comentários

1. Foi alterada para a função `Dequeue` de modo que após a execução o item é removido da fila.
2. Implementada a funcionalidade de divisão.
3. Corrigido o erro de cálculo da penúltima operação. Tratava-se de colocar o valor como `long` ao invés de `int`.
4. Implementada a funcionalidade de imprimir a lista de operações a ser processada.
5. Implementada a funcionalidade de guardar o resultado de cada cálculo efetuado e imprimir a pilha ao final. Usando a classe `Stack` do C#.

## Extra
Implementado um pequeno teste unitário para a função de divisão da calculadora, espera-se que seja lançada uma exceção quando o divisor for zero.

Durante o desenvolvimento foi utilizado NixOS, dessa forma foram criados os arquivos necessários.

## Descrição Original

Case para Engenharia de Software JR

Você precisa corrigir os seguintes problemas no codigo:

1.  Aplicação só está processando o primeiro item da fila infinitamente.
2.  Implemente a funcionalidade de divisão.
3.  Aplicação não está calculando a penultima operação corretamente.

    Saída esperada no console:

        14 - 8 = 6

        5 * 6 = 30

        2147483647 + 2 = 2147483649

        18 / 3 = 6

4.  Implemente uma funcionalidade para imprimir toda a lista de operaçõoes a ser processada após cada calculo realizado.
5.  Crie uma nova pilha (Stack) para guardar o resultado de cada calculo efetuado e imprima a pilha ao final

Não existe resposta certa ou errada, o objetivo do case é avaliar a linha de raciocínio de cada candidato.
Você é livre para fazer na linguagem de sua preferência, desde que aplique as mesmas funcionalidades e tarefas deste case.
Dica: Utilize Visual Code ou Visual Studio Community para realizar as tarefas.
