#include <iostream>

using namespace std;

class Triangulo {
  private:
    double b, h;         // atributo ou campo
  public:                // métodos
    Triangulo(double b, double h) {
      set_base(b);
      set_altura(h);
    }
    double get_base() {
      return b;
    }
    double get_altura() {
      return h;
    }
    void set_base(double b) {
      if (b >= 0) this->b = b;
      else throw invalid_argument("Valor negativo inválido");
    }
    void set_altura(double h) {
      if (h >= 0) this->h = h;
      else throw invalid_argument("Valor negativo inválido");
    }
    double calc_area() {  
      return b * h / 2;
    }
    string to_string() {
      return "Base = " + std::to_string(b) + " Altura = " + std::to_string(h) 
        + "Área = " + std::to_string(calc_area());
    }  
  };

int main() {
    Triangulo x(10, 20); // = new Triangulo(10, 20);
    //x.b = -10;
    //x.h = -20;
    x.set_base(10);
    x.set_altura(20);
    // Console.WriteLine(x.b);
    // Console.WriteLine(x.h);
    cout << x.get_base() << endl;
    cout << x.get_altura() << endl;
    // cout << x << endl;
    cout << x.to_string() << endl;
    
    Triangulo* y = new Triangulo(30, 40);
    cout << y->get_base() << endl;
    cout << y->get_altura() << endl;
    cout << y << endl;
    cout << y->to_string() << endl;
    delete y;
    y = NULL;
}