using System;

class Program {
  public static void Main() {
    Ingresso a = new Ingresso("ter", 16);
    Ingresso b = new Ingresso("qua", 18);
    Ingresso c = new Ingresso("sex", 18);
    Console.WriteLine(a.inteira());
    Console.WriteLine(b.inteira());
    Console.WriteLine(c.inteira());
  }
}

class Ingresso {
  public Ingresso(string dia, int hora) {
    this.set_dia(dia);
    this.set_hora(hora);
  }
  public void set_dia(string dia) {
    if (dia in ["dom", "seg", "ter", "qua", "qui", "sex", "sab"])
      this.dia = dia;
    else
      throw new ArgumentOutOfRangeException();
  }  
  public void set_hora(int hora) { 
    if (0 <= hora && hora <= 23) this.hora = hora;
    else throw new ArgumentOutOfRangeException();
  }  
  public string get_dia() {
    return dia;
  }  
  public int get_hora() {
    return hora;
  }  
  public double inteira() {
    if (dia == "qua") return 8;
    double p = 16;
    if (dia in ["sex", "sab", "dom"]) p = 20;
    if (hora == 0 || self.hora >= 17) p = p * 1.5;
    return p;
  }  
  public double meia() {
    if (dia == "qua") return 8;
    return inteira() / 2; 
  }
}  
