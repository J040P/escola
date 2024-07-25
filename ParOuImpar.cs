using System;

class Program {
  
  public static void Main () {
    int x;
    int y;
    Random aleatorio = new Random();
    y = aleatorio.Next(1,10);
    
    
    Console.WriteLine ("IMPAR OU PAR - jogo");
    Console.WriteLine ("Descrição: O computador irá sortear um número aleatório entre 1 e 10. e vai somar com um número que você escolher. Se a soma for par, você ganha. Se for ímpar Eu ganho");
    Console.WriteLine ("-------------------------");

    Console.WriteLine ("Digite um número inteiro: ");
    x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"O número escolhido foi: {y}");
    Console.WriteLine($"o final: {y+x}");

    if ((x+y) % 2 == 0){
      Console.WriteLine ("O número é par - Você ganhou");
    }
    else{
      Console.WriteLine ("O número é ímpar - Voce ganhou");
    }
  }
}
