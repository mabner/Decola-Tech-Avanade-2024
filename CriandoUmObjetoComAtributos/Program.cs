/*
# Criando um jogador de futebol
# Desafio
Você deve criar um programa que crie um objeto jogador com nome, nacionalidade, 
idade e posição. O jogador deve ser criado a partir de uma classe "Jogador" com o 
método "novo" e os atributos mencionados.

## Entrada
O programa deve ler as informações do jogador nessa ordem: 

- nome: string
- nacionalidade: string
- idade: inteiro
- posição: string

## Saída
O programa deve imprimir as informações do jogador criado, uma por linha, 
com a mensagem "Jogador criado!" no início. As informações devem ser exibidas 
na seguinte ordem: nome, nacionalidade, idade e posição (com a mensagem "Posição:" na frente). 
Veja a estrutura abaixo:

- Jogador criado!
- [nome]
- [nacionalidade]
- [idade]
- Posição: [posição]

### Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas 
saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada					Saída
Ronaldo					Jogador criado!
Brasil					Ronaldo
46							Brasil
Atacante				46
								Posição: Atacante
*/

using System;

class Jogador
{
    public string Nome { get; set; }
    public string Nacionalidade { get; set; }
    public int Idade { get; set; }
    public string Posicao { get; set; }

    public Jogador()
    {
    }
}

class Program
{
    static void Main()
    {
        
    }
}