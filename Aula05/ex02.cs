using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite um inteiro");
    int x;
    //x = int.Parse(Console.ReadLine());
    while (!int.TryParse(Console.ReadLine(), out x))
      Console.WriteLine("Não é inteiro, digite novamente");
    
    
    Console.WriteLine(x + 1);
  }
}