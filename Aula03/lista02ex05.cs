using System;
using System.Linq;

class Program {
  public static void Main() {
    // HH:MM:SS
    // x, y = map(int, input().split())
    Console.WriteLine("Digite o intervalo de tempo no formato \"HH:MM:SS\"");
    int[] x = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
    //Console.WriteLine(x[0]);
    //Console.WriteLine(x[1]);
    //Console.WriteLine(x[2]);
    long dist = 300000L * (x[0]*60*60 + x[1]*60 + x[2]);
    Console.WriteLine($"A luz percorreu {dist} km nesse intervalo");
  }
}  