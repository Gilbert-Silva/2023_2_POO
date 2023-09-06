using System;
using System.Collections.Generic;

class Program {
  public static void Main() {
    Console.WriteLine(1 + "Texto" + 2);
    object x = 10;
    object y = "Texto";
    Console.WriteLine(x);
    Console.WriteLine(y);

    List<string> z = new List<string>();   // z = [];
    z.Add("texto"); // z.append("texto");
    Console.WriteLine(z[0]); // print(z[0])

    Console.WriteLine("Teste\t\t123");
    Console.WriteLine(1.0);
    int i = 5;
    Console.WriteLine(i.ToString() + i.ToString() + 10.ToString());
    
    
  }
}
