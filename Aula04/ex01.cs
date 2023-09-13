using System;
using System.Collections.Generic;

class Program {
  public static void Main() {
    int i;
    for (i = 1; i <= 5; i++) {
      Console.WriteLine($"{i}");
    }
    //Console.WriteLine($"{i}");

    i = 1;
    while(i <= 5) {
      Console.WriteLine($"{i}");
      i++;   
    }
    
    i = 1;
    do {
      Console.WriteLine($"{i}");
      i++;   
    } while(i <= 5);

    int[] v = { 1, 2, 3, 4, 5 };
    int[] w = new int[10];
    
    // int v[10]; em C, C++ 
    Console.WriteLine(v.GetType());
    
    foreach (int k in v)
      Console.WriteLine($"{k}");
    
    foreach (char c in "Programação")
      Console.WriteLine(c);
    
    // lista = [1, 5, 2, 3, 4]
    // lista.append(0)
    // lista.sort()
    // for k in v:
    //    print(k)
    // print(type(lista))
    // vector<int>
    List<int> lista = new List<int> { 1, 5, 2, 3, 4 };
    lista.Add(0);
    lista.Sort();
    foreach (int k in lista)
      Console.WriteLine(k); 
    Console.WriteLine(lista.GetType());
  }
}  
