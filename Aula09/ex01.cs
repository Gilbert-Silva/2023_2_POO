using System;

class Program {
  public static void Main() {
    Triangulo x = new Triangulo(10, 20);
    //x.b = -10;
    //x.h = -20;
    x.SetBase(10);
    x.SetAltura(20);
    // Console.WriteLine(x.b);
    // Console.WriteLine(x.h);
    Console.WriteLine(x.GetBase());
    Console.WriteLine(x.GetAltura());
    Console.WriteLine(x.ToString());
    
    Triangulo y = new Triangulo(30, 40);
    Console.WriteLine(y.GetBase());
    Console.WriteLine(y.GetAltura());
    Console.WriteLine(y);
  }
}

class Triangulo {
  private double b, h;
  public Triangulo(double b, double h) {
    //this.b = b;
    //this.h = h;
    SetBase(b);
    SetAltura(h);
  }
  public double GetBase() {
    return b;
  }
  public double GetAltura() {
    return h;
  }
  public void SetBase(double b) {
    if (b >= 0) this.b = b;
    else throw new ArgumentOutOfRangeException();
  }
  public void SetAltura(double h) {
    if (h >= 0) this.h = h;
    else throw new ArgumentOutOfRangeException();
  }
  public double CalcArea() {
    return b * h / 2;
  }
  public override string ToString() {
    return $"Base = {b}  Altura = {h}  Área = {CalcArea()}";
  }  
}
