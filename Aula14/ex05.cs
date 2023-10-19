using System;
using System.Collections;

class Program {
  public static void Main() {
    ArrayList x = new ArrayList();
    x.Add(5);
    x.Add(6);
//    x.Add(1);
    x.Add(0);
    x.Add(10);
    x.Insert(0, 8);
    //x.Sort();
    Console.WriteLine(x);
    foreach (int elem in x)
      Console.WriteLine(elem);
  }
}  