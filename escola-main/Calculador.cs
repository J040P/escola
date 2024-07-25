using System;

class Soma {
  public float x;
  public float y;

  public void soma(){
    Console.Write("Escreva o primeiro número: ");
    x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Escreva o segundo número: ");
    y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Resultado: {x+y}");
  }
}

class Diminuir {
  public float x;
  public float y;

  public void diminuir(){
    Console.Write("Escreva o primeiro número: ");
    x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Escreva o segundo número: ");
    y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Resultado: {x-y}");
  }
}

class Vezes {
  public float x;
  public float y;

  public void vezes(){
    Console.Write("Escreva o primeiro número: ");
    x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Escreva o segundo número: ");
    y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Resultado: {x*y}");
  }
}

class Dividir {
  public float x;
  public float y;
  public void dividir(){
    Console.Write("Escreva o primeiro número: ");
    x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Escreva o segundo número: ");
    y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Resultado: {x/y}");
  }
}

class Program {
  static void Main () {
    int op;

    Console.WriteLine("1 - Soma | 2 - Diminuir | 3 - Vezes | 4 - Dividir \n--------------------------------------------------------------------");
    op = Convert.ToInt32(Console.ReadLine());

    if(op == 1){
      Soma soma = new Soma();
      soma.soma();
    }
    else if(op == 2){
      Diminuir diminuir = new Diminuir(); 
      diminuir.diminuir();
    }
    else if(op == 3){
      Vezes vezes = new Vezes();
      vezes.vezes();
    }
    else if(op == 4){
      Dividir dividir = new Dividir(); 
      dividir.dividir();
    }
    else{
      Console.WriteLine("Opção inválida");
    }
  }
}
