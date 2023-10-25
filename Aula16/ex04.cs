using System;

class Program {
  public static void Main() {
    int[] v = { 4, 1, 8, 10, 2, 5 };
    Array.Sort(v);
    foreach (int i in v) Console.WriteLine(i);

    string[] w = { "C#", "VB", "Basic", "Pascal", "Python", "Java" };
    Array.Sort(w);
    foreach (string s in w) Console.WriteLine(s);

    Musica a = new Musica { Titulo = "The meaning of love", Artista = "Joe Satriani", 
      Album = "Supernatural", DataInclusao = DateTime.Now, Duracao = new TimeSpan(0, 0, 6, 20) };
    Musica b = new Musica { Titulo = "Holy Diver", Artista = "Dio", Album = "Holy Diver",
      DataInclusao = DateTime.Now, Duracao = new TimeSpan(0, 0, 5, 20) };
    Musica c = new Musica { Titulo = "Hotel California", Artista = "Eagles", 
      Album = "Hotel California", DataInclusao = DateTime.Now, Duracao = new TimeSpan(0, 0, 5, 40) };
    Musica d = new Musica { Titulo = "Oye como va", Artista = "Carlos Santana", 
      Album = "Abraxas", DataInclusao = DateTime.Now, Duracao = new TimeSpan(0, 0, 5, 40) };
    Musica[] ms = { a, b, c, d };
    Array.Sort(ms);
    foreach (Musica m in ms) Console.WriteLine(m);

    
  }  
}  


class Musica : IComparable {
  public string Titulo { get; set; }
  public string Artista { get; set; }
  public string Album { get; set; }
  public DateTime DataInclusao { get; set; }
  public TimeSpan Duracao { get; set; }
  public override string ToString() {
    return $"{Titulo} - {Artista}";
    //" - {Album} - {DataInclusao:dd/MM/yyyy} - {Duracao}";
  }
  public int CompareTo(object obj) {
    Musica m = (Musica) obj;
    return this.Artista.CompareTo(m.Artista);
  }
  
}
