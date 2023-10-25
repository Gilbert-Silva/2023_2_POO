using System;

class Program {
  public static void Main() {
    Console.WriteLine(1.CompareTo(5));
    Console.WriteLine(1.CompareTo(1));
    Console.WriteLine(7.CompareTo(1));
    
    Console.WriteLine("C#".CompareTo("Java"));
    Console.WriteLine("Java".CompareTo("Java"));
    Console.WriteLine("Java".CompareTo("Basic"));

    //Console.WriteLine("C#" > "Java");
    
    DateTime x = DateTime.Parse("01/01/2000");
    DateTime y = DateTime.Parse("01/01/2001");
    Console.WriteLine(x.CompareTo(y));

    Musica a = new Musica { Titulo = "The meaning of love", Artista = "Joe Satriani", 
      Album = "Supernatural", DataInclusao = DateTime.Now, Duracao = new TimeSpan(0, 0, 6, 20) };
    
    Musica b = new Musica { Titulo = "Holy Diver", Artista = "Dio", Album = "Holy Diver",
      DataInclusao = DateTime.Now, Duracao = new TimeSpan(0, 0, 5, 20) };

    Console.WriteLine(a.CompareTo(b));
  }
}

/*
interface IComparable {
  int CompareTo(object obj);
}
*/

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
    /*
    if (this.Titulo == m.Titulo) return 0;
    //if (this.Titulo < m.Titulo) return -1;
    if (this.Titulo.CompareTo(m.Titulo) == -1) return -1;
    // if (this.Titulo > m.Titulo) return 1;
    if (this.Titulo.CompareTo(m.Titulo) == 1) return 1;
    */
    return this.Titulo.CompareTo(m.Titulo);
  }

}