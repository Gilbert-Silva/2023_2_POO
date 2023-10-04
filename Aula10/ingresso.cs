using System;

class Ingresso {
  private string dia;
  private int hora;
  public Ingresso(string dia, int hora) {
    this.set_dia(dia);
    this.set_hora(hora);
  }
  public void set_dia(string dia) {
    string[] dias = { "dom", "seg", "ter", "qua", "qui", "sex", "sab" }; 
    if (Array.IndexOf(dias, dia) != -1)  
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
    string[] dias = { "dom", "sex", "sab" }; 
    if (Array.IndexOf(dias, dia) != -1) p = 20;
    // if (dia in ["sex", "sab", "dom"]) p = 20;
    if (hora == 0 || hora >= 17) p = p * 1.5;
    return p;
  }  
  public double meia() {
    if (dia == "qua") return 8;
    return inteira() / 2; 
  }
}  
