using System;

class Program {
  public static void Main() {
    int i = 10;      // Variáveis locais
    Console.WriteLine(i);
    Triangulo x = null;
    Console.WriteLine(x);
    
    // Cria uma nova variável na memória
    x = new Triangulo();  // Construtor padrão
    x.cor = "Amarelo";
    Console.WriteLine(x.b);
    Console.WriteLine(x.h);
    Console.WriteLine(x.cor);
    Console.WriteLine(x);
    x = null;
    
    Triangulo y = new Triangulo(10, 20);
    //y.b = 10;
    //y.h = 20;
    y.cor = "Azul";
    Console.WriteLine(y.b);
    Console.WriteLine(y.h);
    Console.WriteLine(y.cor);
    Console.WriteLine(y);

    Triangulo z = new Triangulo(80, 2, "Cinza");
    Console.WriteLine(z.b);
    Console.WriteLine(z.h);
    Console.WriteLine(z.cor);
    Console.WriteLine(z);

    Triangulo t = z;
    t.b = 50;
    t.h = 100;
    t.cor = "Verde";

    Console.WriteLine(z.b);
    Console.WriteLine(z.h);
    Console.WriteLine(z.cor);
    Console.WriteLine(z);
    
    Triangulo u = t.Clone();
    t.cor = "Roxo";
    Console.WriteLine(u.b);
    Console.WriteLine(u.h);
    Console.WriteLine(u.cor);
    Console.WriteLine(u);

    Console.WriteLine(z.b);
    Console.WriteLine(z.h);
    Console.WriteLine(z.cor);
    Console.WriteLine(z);
    
    
  }
}

class Triangulo {
  public double b, h;
  public string cor;
  public Triangulo() {
    b = 5;  // b e this.b é a mesma coisa
    h = 5;
    cor = null;
  }
  public Triangulo(double b, double h) {
    this.b = b;
    this.h = h;
    cor = null;
  }
  public Triangulo(double vb, double vh, string c) {
    this.b = vb;
    h = vh;
    cor = c;
  }
  public Triangulo Clone() {
    Triangulo aux = new Triangulo();
    aux.b = b; // this.b
    aux.h = this.h;
    aux.cor = this.cor;
    return aux;
  }
  public override string ToString() {
    return $"{b} {h} {cor}";
  }
}