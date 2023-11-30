using System;
using System.IO;

class Program {
  public static void Main2() {
    StreamWriter f = new StreamWriter("teste.txt");
    string s = Console.ReadLine();
    while (s != "fim") {
      f.WriteLine(s);
      s = Console.ReadLine();
    }
    f.Close();
  }
  public static void Main() {
    StreamReader f = new StreamReader("teste.txt");
    string s = f.ReadLine();
    while (s != null) {
      Console.WriteLine(s);
      s = f.ReadLine();
    }
    f.Close();
  }
}

