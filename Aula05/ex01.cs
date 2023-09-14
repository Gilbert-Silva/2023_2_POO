using System;

class Program {
  static int valor = 150;  // Atributo estático - Método estático 
  public static void Main() {
    valor = 200;
    Console.WriteLine(valor);
    Console.WriteLine(Primo(100));
    Console.WriteLine(Program.Primo(5));  // Opcional Program
    Console.WriteLine(Figuras.AreaTriangulo(10, 20));
    Console.WriteLine(Figuras.AreaCirculo(10));
    Program.Imprimir(1);
    Program.Imprimir(20);
    //Program.Imprimir2(1);
    int a = 10; // Variáveis locais
    int b = 20;
    MudarValor(a, b);
    Console.WriteLine($"Main: {a} {b}");
    // MudarValor2(a, b); // c++
    MudarValor2(ref a, ref b);
    Console.WriteLine($"Main: {a} {b}");
    int c; int d;
    MudarValor3(out c, out d);
    Console.WriteLine($"Main: {c} {d}");
  }
  public static void MudarValor3(out int x, out int y) { 
    // Passagem de parâmetros de saída
    x = 100; 
    y = 200; 
    //Console.WriteLine($"MudarValor: {x} {y}");
  }

  //public static void MudarValor2(int& x, int& y) { // c++
  public static void MudarValor2(ref int x, ref int y) { 
    // Passagem de parâmetros por referência
    x = 100; // a = 100
    y = 200; // b = 200
    //Console.WriteLine($"MudarValor: {x} {y}");
  }
  public static void MudarValor(int x, int y) { 
    // Passagem de parâmetros por valor
    // Passagem de parâmetros por referência
    x = 100;
    y = 200;
    //Console.WriteLine($"MudarValor: {x} {y}");
  }
  public static void Imprimir(int x) {
    Console.WriteLine(x);
    if (x > 10) return;
    Console.WriteLine(x);
  }
  public static void Imprimir2(int x) {
    Console.WriteLine(x);
    if (x >= 10) return;
    Imprimir2(x + 1);
  }  
  public static bool Primo(int x) {
    Console.WriteLine(valor);
    if (x == 1) return false;
    bool p = true;
    for (int d = 2; d < Math.Sqrt(x); d++) 
      if (x % d == 0) p = false;  
    return p;
  }
}  

class Figuras {
  public static double AreaTriangulo(double b, double h) {
    double area = b * h / 2;
    return area;
  }
  public static double AreaCirculo(double r) {
    return Math.PI * r * r; // Math.Pow(r, 2)
  }
}
