using System;

class Program {
  public static void Main() {
    Musica a = new Musica { Titulo = "The meaning of love", Artista = "Joe Satriani", 
      Album = "Supernatural", DataInclusao = DateTime.Now, Duracao = new TimeSpan(0, 0, 6, 20) };
    Musica b = new Musica { Titulo = "Holy Diver", Artista = "Dio", Album = "Holy Diver",
      DataInclusao = DateTime.Now, Duracao = new TimeSpan(0, 0, 5, 20) };
    Musica c = new Musica { Titulo = "Hotel California", Artista = "Eagles", 
      Album = "Hotel California", DataInclusao = DateTime.Now, Duracao = new TimeSpan(0, 0, 5, 40) };
    PlayList p = new PlayList("Rock");
    p.Inserir(a);
    p.Inserir(b);
    p.Inserir(c);
    Console.WriteLine(p);
    Console.WriteLine(p.TempoTotal());
    foreach (Musica m in p.Listar())
      Console.WriteLine(m);
  }
}

class PlayList {
  private string nome;
  private Musica[] musicas = new Musica[10];
  private int k;
  public PlayList(string nome) { this.nome = nome; }
  public void Inserir(Musica m) {
    if (k < 10) musicas[k++] = m;
  }
  public Musica[] Listar() {
    Musica[] aux = new Musica[k];
    Array.Copy(musicas, aux, k);
    Array.Sort(aux);
    return aux;
  }
  public TimeSpan TempoTotal() {
    TimeSpan t = new TimeSpan(0);
    foreach (Musica m in Listar())
      t += m.Duracao;
    return t;
  }
  public override string ToString() {
    return $"Playlist {nome} tem {k} música(s)";
  } 
}

class Musica : IComparable {
  public string Titulo { get; set; }
  public string Artista { get; set; }
  public string Album { get; set; }
  public DateTime DataInclusao { get; set; }
  public TimeSpan Duracao { get; set; }
  public override string ToString() {
    return $"{Titulo} - {Artista} - {Album} - {DataInclusao:dd/MM/yyyy} - {Duracao}";
  }
  public int CompareTo(object obj) {
    Musica m = (Musica) obj;
    return this.Artista.CompareTo(m.Artista);
  }
}
