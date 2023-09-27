#include <iostream>

using namespace std;

class Triangulo {
  public :
    double b, h;  // atributo ou campo
    double CalcArea() {  // método
      return b * h / 2;
    }
};

int main() {
  Triangulo x;
  Triangulo* y = new Triangulo();
  x.b = 10;
  x.h = 20;
  y->b = 15;
  y->h = 30;
  cout << x.b * x.h / 2 << endl;
  cout << y->b * y->h / 2 << endl;
  cout << x.CalcArea() << endl;
  cout << y->CalcArea() << endl; 
  delete y;
}