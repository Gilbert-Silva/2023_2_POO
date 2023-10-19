using System;

class Program {
  public static void Main() {
    int[] x = new int[5];
    object[] y = new object[5];
    Console.WriteLine(x[0]);
    Console.WriteLine(y[0]);
    Console.WriteLine(x[1]);
    Console.WriteLine(y[1]);
    Vector v = new Vector();
    v.push_back("POO");
    v.push_back(2023);
    v.print();
    Vector<int> w = new Vector<int>();
    w.push_back(1);
    w.push_back(2);
    w.print();
  }
}

class Vector {
  private object[] w = new object[10];
  private int k;
  public void push_back(object obj) {
    w[k++] = obj;
  }
  public void print() {
    for (int i = 0; i < k; i++)
      Console.WriteLine(w[i]);
  }
}

class Vector<T> {
  private T[] w = new T[10];
  private int k;
  public void push_back(T obj) {
    w[k++] = obj;
  }
  public void print() {
    for (int i = 0; i < k; i++)
      Console.WriteLine(w[i]);
  }
}
