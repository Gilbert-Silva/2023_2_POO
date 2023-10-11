using System;

class Program {
  public static void Main() {
    Corrida x = null, y;
    for (int i = 1; i <= 2; i++) {
      Console.WriteLine("Informe a data dd/mm/aaaa");
      string data = Console.ReadLine();
      Console.WriteLine("Informe o horário inicial hh:mm");
      string hora = Console.ReadLine();
      Console.WriteLine("Informe a duração hh:mm:ss");
      string d = Console.ReadLine();
      Console.WriteLine("Informe a distância em metros");
      double dist = double.Parse(Console.ReadLine());
      if (i == 1) x = new Corrida(data, hora, d, dist);
      else {
        y = new Corrida(data, hora, d, dist);
        if (y.VelocidadeMedia() > x.VelocidadeMedia()) x = y; 
      }
    }
    Console.WriteLine(x.ToString());
    Console.WriteLine(x.VelocidadeMedia());    
  }
}

class Corrida {
  private string data;        // DateTime
  private string horaInicio;
  private string duracao;     // TimeSpan
  private double distancia;
  private int h, m, s;

  public Corrida(string data, string hora, string d, double dist) {
    SetData(data);
    SetHoraInicio(hora);
    SetDuracao(d);
    SetDistancia(dist);
  }
  public string GetData() { return data; }
  public string GetHoraInicio() { return horaInicio; }
  public string GetDuracao() { return duracao; }
  public double GetDistancia() { return distancia; }
  public void SetData(string data) { this.data = data; }
  public void SetHoraInicio(string horaInicio) { // hh:mm 00:00 - 23:59
    string[] v = horaInicio.Split(':');
    int h = int.Parse(v[0]);
    int m = int.Parse(v[1]);
    if (h >= 0 && h <= 23 && m >= 0 && m <= 59) 
      this.horaInicio = horaInicio;
    else
      throw new ArgumentOutOfRangeException();
  }
  public void SetDuracao(string duracao) { // hh:mm:ss 00:00:00 - 23:59:59
    string[] v = duracao.Split(':');
    h = int.Parse(v[0]);
    m = int.Parse(v[1]);
    s = int.Parse(v[2]);
   if (h >= 0 && h <= 23 && m >= 0 && m <= 59 && s >= 0 && s <= 59 && h + m + s > 0) 
      this.duracao = duracao;
    else
      throw new ArgumentOutOfRangeException();
  }  
  public void SetDistancia(double distancia) { 
    if (distancia > 0) this.distancia = distancia;
    else throw new ArgumentOutOfRangeException();
  }  
  public double VelocidadeMedia() {
    return (distancia/1000) / (h + m/60.0 + s/3600.0);
  }
  public override string ToString() {
    return $"{data} {horaInicio} {duracao} {distancia}";
  } 
}