using System;

class Program {
  public static void Main() {
    PontoXY p1 = new PontoXY(1, 5);
    PontoXY p2 = new PontoXY(3, 2);
    Console.WriteLine(p1);
    Console.WriteLine(p2);
    PontoXY p3 = p1.Somar(p2);
    Console.WriteLine(p3);
    PontoXY p4 = PontoXY.Somar(p1, p2);
    Console.WriteLine(p4);
    // Sobrecarga de operador
    PontoXY p5 = p1 + p2;
    Console.WriteLine(p5);
    
  }
}

class PontoXY {
  private double x, y;
  public PontoXY(double x, double y) {
    this.x = x;
    this.y = y;
  }
  public double GetX() => x;
  public double GetY() { return y; }
  public void SetX(double x) {
    this.x = x;
  }
  public void SetY(double y) {
    this.y = y;
  }
  public override string ToString() {
    return $"({x}, {y})";
  }
  // PontoXY p3 = p1.Somar(p2);
  // PontoXY p3 = p2.Somar(p1);
  public PontoXY Somar(PontoXY ponto) {
    double x = this.x + ponto.x;
    double y = this.y + ponto.y;
    PontoXY novo = new PontoXY(x, y);
    return novo;
  }
  // PontoXY p4 = PontoXY.Somar(p1, p2);  
  public static PontoXY Somar(PontoXY a, PontoXY b) {
    double x = a.x + b.x;
    double y = a.y + b.y;
    PontoXY novo = new PontoXY(x, y);
    return novo;    
  }  
  public static PontoXY operator +(PontoXY a, PontoXY b) {
    double x = a.x + b.x;
    double y = a.y + b.y;
    PontoXY novo = new PontoXY(x, y);
    return novo;    
  } 
}