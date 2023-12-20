using System;

class Program {
  public static void Main() {
    int n;
    try {
      Console.WriteLine("Informe um valor inteiro");
      n = int.Parse(Console.ReadLine());
      Console.WriteLine(n*n);
    }
    catch (FormatException) {
      Console.WriteLine("Valor informado é um número");
    }
    
  }
}