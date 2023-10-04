using System;

class Program {
  public static void Main() {
    Ingresso a = new Ingresso("ter", 16);
    Ingresso b = new Ingresso("qua", 18);
    Ingresso c = new Ingresso("sex", 18);
    Console.WriteLine(a.inteira());
    Console.WriteLine(b.inteira());
    Console.WriteLine(c.inteira());
  }
}

