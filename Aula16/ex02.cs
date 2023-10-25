using System;

class Program {
  public static void Main() {
    Contato c1 = new Contato();
    c1.Nome = "João Roberto";
    Contato c2 = new Contato { Nome = "Débora Samara" };
    Console.WriteLine(c1.Nome);
    Console.WriteLine(c2.Nome);
    Console.WriteLine(c1);
    Console.WriteLine(c2);

  }
}  

class Contato {
  public string Nome { get; set; }
  public string Email { get; set; }
  public string Fone { get; set; }
  public DateTime Nascimento { get; set; }
  public override string ToString() {
    return $"{Nome} {Email} {Fone} {Nascimento}";
  }
}