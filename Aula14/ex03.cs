using System;

enum Estacao {
  Primavera, Verão, Outono, Inverno
}

[Flags]
public enum Dias {
  Nenhum = 0, 
  Segunda = 1,
  Terça = 2, 
  Quarta = 4,
  Quinta = 8, 
  Sexta = 16,
  Sábado = 32, 
  Domingo = 64
}

class MainClass {
  public static void Main (string[] args) {
    Estacao x = Estacao.Outono;
    Console.WriteLine(x); 
    Estacao y = (Estacao) 3;
    Console.WriteLine(y); 
    Estacao z = Estacao.Verão | Estacao.Outono;
    Console.WriteLine(z); 

    Dias poo = Dias.Quarta | Dias.Quinta;
    Console.WriteLine(poo);

    if ((Dias.Quarta & poo) != 0)
      Console.WriteLine("Tem aula na quarta");
  }
}
