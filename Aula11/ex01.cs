using System;

class Program {
  public static void Main() {
    Veiculo[] vs = new Veiculo[3];
    for (int i = 0; i < 3; i++) {
      Console.WriteLine("Informe o nome do veículo");
      string n = Console.ReadLine();
      Console.WriteLine("Informe a potência em cv");
      int p = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe o peso em kg");
      double k = double.Parse(Console.ReadLine());
      vs[i] = new Veiculo(n, p, k);
    } 
    Veiculo v = vs[0];
    for (int i = 1; i < 3; i++) 
      if (vs[i].PesoPotencia() < v.PesoPotencia()) v = vs[i];
    Console.WriteLine(v.ToString());
    Console.WriteLine(v.PesoPotencia());      
  }
  public static void Main2() {
    Console.WriteLine("Informe o nome do veículo");
    string n = Console.ReadLine();
    Console.WriteLine("Informe a potência em cv");
    int p = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o peso em kg");
    double k = double.Parse(Console.ReadLine());
    Veiculo v = new Veiculo(n, p, k);
    for (int i = 2; i <= 3; i++) {
      Console.WriteLine("Informe o nome do veículo");
      n = Console.ReadLine();
      Console.WriteLine("Informe a potência em cv");
      p = int.Parse(Console.ReadLine());
      Console.WriteLine("Informe o peso em kg");
      k = double.Parse(Console.ReadLine());
      Veiculo w = new Veiculo(n, p, k);
      if (w.PesoPotencia() < v.PesoPotencia()) v = w;
    }
    Console.WriteLine(v.ToString());
    Console.WriteLine(v.PesoPotencia());
  }
}

class Veiculo {
  private string nome;
  private int potencia;
  private double peso;
  public Veiculo(string nome, int potencia, double peso) {
    SetNome(nome);
    SetPotencia(potencia);
    SetPeso(peso);
  }
  public string GetNome() {
    return nome;
  }
  public int GetPotencia() {
    return potencia;
  }
  public double GetPeso() {
    return peso;
  }
  public void SetNome(string nome) {
    if (nome != "") this.nome = nome;
    else throw new ArgumentOutOfRangeException();
  }
  public void SetPotencia(int potencia) {
    if (potencia > 0) this.potencia = potencia;
    else throw new ArgumentOutOfRangeException();
  }
  public void SetPeso(double x) {
    if (x >= 0) peso = x;
    else throw new ArgumentOutOfRangeException();
  }
  public double PesoPotencia() {
    return peso/potencia;
  }
  public override string ToString() {
    return $"Nome = {nome}, Potência = {potencia} cv, Peso = {peso} kg";
  }
}