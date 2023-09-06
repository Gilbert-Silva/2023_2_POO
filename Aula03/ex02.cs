using System;

class Program {
  public static void Main() {
    double x = 1.57;
    Console.WriteLine($"{x}");
    Console.WriteLine($"{x:0.0}");
    Console.WriteLine($"{x:0.00}");
    Console.WriteLine($"{x:0.000}");
    Console.WriteLine($"{x:f5}");
    int i = 5;
    Console.WriteLine($"{i:0}");
    Console.WriteLine($"{i:00}");
    Console.WriteLine($"{i:000}");
    Console.WriteLine($"{i:d5}");
  }
}