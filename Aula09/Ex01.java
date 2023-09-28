public class Ex01 {
  public static void main(String[] args) {
    Triangulo x = new Triangulo(10, 20);
    //x.b = -10;
    //x.h = -20;
    x.setBase(10);
    x.setAltura(20);
    // Console.WriteLine(x.b);
    System.out.println(x.getBase());
    // Console.WriteLine(x.h);
    System.out.println(x.getAltura());
    System.out.println(x.toString());
    
    Triangulo y = new Triangulo(30, 40);
    System.out.println(y.getBase());
    System.out.println(y.getAltura());
    System.out.println(y);
  }
}

class Triangulo {
  private double b, h;
  public Triangulo(double b, double h) {
    //this.b = b;
    //this.h = h;
    setBase(b);
    setAltura(h);
  }
  public double getBase() {
    return b;
  }
  public double getAltura() {
    return h;
  }
  public void setBase(double b) {
    if (b >= 0) this.b = b;
    else throw new IllegalArgumentException();
  }
  public void setAltura(double h) {
    if (h >= 0) this.h = h;
    else throw new IllegalArgumentException();
  }
  public double calcArea() {
    return b * h / 2;
  }
  public String toString() {
    return String.format("Base = %f  Altura = %f  Área = %f", b, h, calcArea());
  }  
}
