using System;
using System.Collections;

class Program {
  public static void Main() {
    ArrayList v = new ArrayList();
    v.Add(10);
    v.Add(20);
    Console.WriteLine(v[0]);
    // Console.WriteLine(v.get(0));
    
    //Triangulo x = new Triangulo(10, 20);
    //Triangulo y = new Triangulo { Altura = 40, Base = 30 };
    Triangulo y = new Triangulo();
    Console.WriteLine("Informe um valor para a base");
    double b = 0;
    while (double.TryParse(Console.ReadLine(), out b) == false);
    y.Base = b;
    Console.WriteLine("Informe um valor para a altura");
    y.Altura = double.Parse(Console.ReadLine());
    
    //Console.WriteLine(x.Area);
    Console.WriteLine(y.Area);

  }
}

class Triangulo {
  private double b, h;
  // public Triangulo() { }
  // public Triangulo(double b, double h) {
  //   Base = b;
  //   Altura = h;
  // }
  public double Base {
    get { return b; }
    set { if (value > 0) b = value; }
  }
  public double Altura {
    get { return h;}
    set { if (value > 0) h = value; }
  }
  public double Area {
    get { return b * h / 2; }
  }
}  