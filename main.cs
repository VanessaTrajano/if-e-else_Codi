using System;

class Program {
  public static void Main (string[] args) {
    // Exercício 1 -----------------------------------
    // Para o exercício 2 de comparação elabore uma saída para o programa, se a idade do aluno for inferior a 14 anos, imprima na tela: “Você não tem a idade mínima”, caso contrário imprima a frase: “Bem-vindo a Codi Academy”.
    int idade = 11;
    if(idade < 14){
      Console.WriteLine("Você não tem a idade mínima");
    } else {
      Console.WriteLine("Bem-vindo a Codi Academy");
    }

    // Exercício 2 -----------------------------------
    // Escreva um programa que recebe leia do teclado 3 valores reais referentes aos lados de um triângulo, e faça os cálculos para verificar se estes três lados são capazes de formar um triângulo (Lembrando que para formar um triângulo a soma de dois lados deve ser maior do que o terceiro), ao final dos cálculos se for possível construir um triângulo com as medidas imprima na tela: “As medidas formam um triângulo”, caso falso imprima a frase: “As medidas NÃO formam um triângulo”.

    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    int c = Convert.ToInt32(Console.ReadLine());

    if((a+b>c)&&(a+c>b)&&(b+c>a)){
      Console.WriteLine("As medidas formam um triângulo");
    } else {
      Console.WriteLine("As medidas NÃO formam um triângulo");
    }

  }
}