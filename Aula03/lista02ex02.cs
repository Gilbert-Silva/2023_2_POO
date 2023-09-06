using System;

class Program {
  public static void Main() {
    Console.WriteLine("Digite seu nome completo:");
    string s = Console.ReadLine();
    int i = s.IndexOf(' ');
    Console.WriteLine($"Bem-vindo ao C#, {s.Substring(0, i)}");
    string[] v = s.Split();
    //Console.WriteLine(v[0]);
    //Console.WriteLine(v[1]);
    Console.WriteLine($"Bem-vindo ao C#, {v[0]}");
    Console.WriteLine(Math.Sqrt(16));
  }
}