using System;

//interface IComparable {
//  int CompareTo(obejct obj);
//}

interface IPessoa : IComparable {
  string GetNome();
  DateTime GetNascimento();
}

class Aluno : IPessoa {
  private string nome;
  private DateTime nascimento;
  private string curso;
  public Aluno(string nome, DateTime nascimento, string curso) {
    this.nome = nome;
    this.nascimento = nascimento;
    this.curso = curso;
  }
  public string GetNome() { return nome; }
  public DateTime GetNascimento() { return nascimento; }
  public string GetCurso() { return curso; }
  public override string ToString() {
    return $"{nome} {nascimento:dd/MM/yyyy} {curso}";
  } 
  public int CompareTo(object obj) {
     IPessoa x = (IPessoa) obj;
     return nome.CompareTo(x.GetNome());
  }
}

class Professor : IPessoa {
  private string nome;
  private DateTime nascimento;
  private string diretoria;
  public Professor(string nome, DateTime nascimento, string diretoria) {
    this.nome = nome;
    this.nascimento = nascimento;
    this.diretoria = diretoria;
  }
  public string GetNome() { return nome; }
  public DateTime GetNascimento() { return nascimento; }
  public string GetDiretoria() { return diretoria; }
  public override string ToString() {
    return $"{nome} {nascimento:dd/MM/yyyy} {diretoria}";
  } 
  public int CompareTo(object obj) {
    IPessoa x = (IPessoa) obj;
    return nome.CompareTo(x.GetNome());
  }
}

class Program {
  public static void Main() {
    Aluno a1 = new Aluno("Igor", DateTime.Parse("2005-05-30"), "Tads");
    Console.WriteLine(a1);
    Console.WriteLine(a1.GetNome());
    Console.WriteLine(a1.GetNascimento());
    Console.WriteLine(a1.GetCurso());
    IPessoa a2 = new Aluno("Ester", DateTime.Parse("2004-04-30"), "Tads");
    Console.WriteLine(a2);
    Console.WriteLine(a2.GetNome());
    Console.WriteLine(a2.GetNascimento());
    object a3 = new Aluno("João Roberto", DateTime.Parse("2004-04-10"), "Tads");
    Console.WriteLine(a3.ToString());
    //Console.WriteLine(a3.GetNome());
    IPessoa p1 = new Professor("Eduardo", DateTime.Parse("1975-05-30"), "Diatinf");
    IPessoa p2 = new Professor("Jorgiano", DateTime.Parse("1978-04-30"), "Diatinf");
    Console.WriteLine(p1);
    Console.WriteLine(p2);
    IPessoa[] v = { a1, a2, (IPessoa) a3, p1, p2 };
    Console.WriteLine("\nAniversariantes de Abril");
    MostrarAniversariantes(v, 4);
    Console.WriteLine("\nParticipantes da Maratona de Programação");
    IPessoa[] w = { a1, a2, p1, p2 };
    MostrarParticipantes(w);
  }

  public static void MostrarAniversariantes(IPessoa[] pessoas, int mes) {
    foreach (IPessoa p in pessoas)
      if (p.GetNascimento().Month == mes)
        Console.WriteLine($"{p.GetNome()} - {p.GetNascimento():dd/MM}");
  }

  public static void MostrarParticipantes(IPessoa[] pessoas) {
    Array.Sort(pessoas);
    foreach (IPessoa p in pessoas)
      Console.WriteLine($"{p.GetNome()}");
  }
}
/*
class Array {
  public static void Sort(IComparable[] v) {
    if (v[0].CompareTo(v[1]) == 1) {
      ICompareble aux = v[0];
      v[0] = v[1];
      v1 = aux;
    }
  }
}
*/

IComparer
