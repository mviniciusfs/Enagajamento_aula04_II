using System;
/*
2- O cardápio de uma casa de lanches é dado pela tabela abaixo:
Código Produto Preço Unitário (R$)
---------------------------------
100  Cachorro quente   R$ 1,70
101   Bauru Simples    R$ 2,30
102   Bauru com ovo    R$ 2,60
103   Hamburguer       R$ 2,40
104   Cheeseburguer    R$ 2,50
105   Refrigerante     R$ 1,00
----------------------------------
Escreva um algoritmo que leia o código do item adquirido pelo consumidor e a
quantidade, calculando e mostrando o valor a pagar. Não será necessário exibir o produto
e o valor, somente o valor final
*/

class MainClass {
  public static void Main (string[] args) {
    int codigo = 0;
    int quantidade = 0;
    double soma = 0;

    Console.Write("Digite o código do produto: ");
    codigo = int.Parse(Console.ReadLine());

    Console.Write("Digite a quantidade: ");
    quantidade = int.Parse(Console.ReadLine());

    if (codigo == 100 )
    {
      soma = quantidade * 1.70;
    }

    else if (codigo == 101)
    {
      soma = quantidade * 2.30;
    }

    else if (codigo == 102)
    {
      soma = quantidade * 2.60;
    }

    else if (codigo == 103)
    {
      soma = quantidade * 2.40;
    }

    else if (codigo == 104)
    {
      soma = quantidade * 2.50;
    }

    else if (codigo == 105)
    {
      soma = quantidade * 1;
    }

    Console.WriteLine();
    Console.WriteLine("Valor final: R${0}", soma);
  }
}