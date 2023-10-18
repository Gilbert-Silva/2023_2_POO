using System;

class Program {
  public static void Main() {
    dynamic s = "Teste";
    Console.WriteLine(s + s);
    Console.WriteLine(s[2]);
    s = 10;
    Console.WriteLine(s + s);
    //Console.WriteLine(s[2]);

    object x = "Teste";
    Console.WriteLine(x);
    x = 10;
    Console.WriteLine(x);
  }
}