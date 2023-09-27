using System;

class Triangulo {
  public double b, h;  // atributo ou campo
  public double CalcArea() {  // método
    return b * h / 2;
  }
}

class Program {
  public static void Main() {
    int i = 5;
ex    x = new Triangulo(); // reserva
    Triangulo y = new Triangulo();
    x.b = 10;
    x.h = 20;
    y.b = 15;
    y.h = 30;
    Console.WriteLine(x.b * x.h / 2);
    Console.WriteLine(y.b * y.h / 2);
    Console.WriteLine(x.CalcArea());
    Console.WriteLine(y.CalcArea());
    x = null; // liberação
  }
}






