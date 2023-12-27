﻿/*
# Catálogo de Jogos
# Descrição
Neste desafio, o objetivo é criar um catálogo de jogos que permita ao usuário adicionar 
uma quantidade específica de jogos. Inicie solicitando a quantidade desejada e, em seguida, 
peça o nome de cada jogo individualmente, armazenando-os em um array chamado nomesJogos. 
Utilize um loop `for` para facilitar a adição dos jogos. Após a conclusão, exiba um resumo 
em uma única linha, indicando a quantidade total de jogos adicionados e a lista de nomes no catálogo.

## Entrada
O programa inicia solicitando ao usuário que insira a quantidade de jogos que deseja adicionar 
ao catálogo. Em seguida, para cada jogo, o usuário é solicitado a inserir o nome do jogo.

## Saída
Ao final da adição dos jogos, o programa exibe um resumo que inclui a quantidade total de 
jogos adicionados e uma lista com os nomes dos jogos separados por vírgulas. Este resumo 
fornece uma visão geral dos jogos que foram incluídos no catálogo.

### Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas 
esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada									Saída
2												Foi adicionado '2' jogos: SimCity, Prince of Persia ao catalogo.
SimCity
Prince of Persia

*/

using System;

class Program
{
    static void Main()
    {
        int quantidadeJogos = int.Parse(Console.ReadLine());

        string[] nomesJogos = new string[quantidadeJogos];

        for (int i = 0; i < quantidadeJogos; i++)
        {
            AdicionarJogo(i, nomesJogos);
        }
        ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
    }

    static void AdicionarJogo(int indice, string[] nomes)
    {
        nomes[indice] = Console.ReadLine();
    }

    static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
    {
        Console.WriteLine(
            $"Foi adicionado '{quantidadeJogos}' jogos: {string.Join(", ", nomes)} ao catalogo."
        );
    }
}
