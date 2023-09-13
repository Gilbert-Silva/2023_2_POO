using System;

class Program {
  public static void Main() {
    int n = int.Parse(Console.ReadLine());
    if (n == 1) Console.Write("0");
    if (n >= 2) {
      Console.Write("0 1");
      int a = 0;
      int b = 1;
      for (int i = 3; i <= n; i++) {
        int c = a + b;
        Console.Write(" " + c);
        a = b;
        b = c;
      }
      Console.WriteLine();
    }
  }
}