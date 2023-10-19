using System;

class Program {
  public static void Main() {
    int[] x = { 5, 6, 1, 0, 10 };
    int[] w = x;
    //Array.Sort(w);
    Console.WriteLine(Array.IndexOf(x, 8));
    Console.WriteLine(x);
    Console.WriteLine(x.Length);
foreach (int elem in x)
      Console.WriteLine(elem);
    Console.WriteLine(x[0]);
    Console.WriteLine(x[4]);
    
    
    bool[] y = new bool[5];
    Console.WriteLine(y);
    foreach (bool elem in y)
      Console.WriteLine(elem);
    int[] z = new int[5];
    Console.WriteLine(z);
    foreach (int elem in z)
      Console.WriteLine(elem);

    
  }
}