public class Ex01 {
  public static void main(String[] args) {
    Triangulo x = new Triangulo();
    Triangulo y = new Triangulo();
    x.b = 10;
    x.h = 20;
    y.b = 15;
    y.h = 30;
    System.out.println(x.b * x.h / 2);
    System.out.println(y.b * y.h / 2);
    System.out.println(x.CalcArea());
    System.out.println(y.CalcArea());        
  }
}

class Triangulo {
  public double b, h;  // atributo ou campo
  public double CalcArea() {  // método
    return b * h / 2;
  }
}
