using System;

class Program {
  public static void Main() {
    Disciplina a = new Disciplina("POO", "2023.2", 100, 90);
    Disciplina b = new Disciplina("Algoritmos", "2023.1", 50, 60);
    Disciplina c = new Disciplina("Algoritmos", "2023.2", 80, 60);
    Disciplina d = new Disciplina("ADC", "2023.2", 100, 60);
    Historico h = new Historico("Gilbert");
    h.Inserir(a);
    h.Inserir(b);
    h.Inserir(c);
    h.Inserir(d);
    Console.WriteLine(h);
    foreach(Disciplina x in h.Listar()) Console.WriteLine(x);
    Console.WriteLine("\nDisciplinas de 2023.1");
    foreach(Disciplina x in h.ListarSemestre("2023.1")) Console.WriteLine(x);
    Console.WriteLine("\nDisciplinas de 2023.2");
    foreach(Disciplina x in h.ListarSemestre("2023.2")) Console.WriteLine(x);
    Console.WriteLine("\nMaiores Médias");
    foreach(Disciplina x in h.MaiorMedia()) Console.WriteLine(x);
    Console.WriteLine($"\nIRA = {h.IRA()}");
    Console.WriteLine($"\nCH = {h.TotalCH()}");
  }
}

class Historico {
  private string aluno;
  private Disciplina[] disciplinas = new Disciplina[10];
  private int k;
  public Historico(string aluno) { this.aluno = aluno; }
  public void Inserir(Disciplina d) {
    if (k < 10) disciplinas[k++] = d;
  }
  public Disciplina[] Listar() {
    Disciplina[] aux = new Disciplina[k];
    Array.Copy(disciplinas, aux, k);
    Array.Sort(aux);
    return aux;
  }
  public Disciplina[] ListarSemestre(string semestre) {
    int qtd = 0;
    foreach(Disciplina d in Listar()) 
      if (d.GetSemestre() == semestre) qtd++;
    Disciplina[] aux = new Disciplina[qtd];
    int i = 0;
    foreach(Disciplina d in Listar()) 
      if (d.GetSemestre() == semestre) aux[i++] = d;
    return aux;
  }
  public Disciplina[] MaiorMedia() {
    int media = 0;
    foreach(Disciplina d in Listar()) 
      if (d.GetMedia() > media) media = d.GetMedia();
    int qtd = 0;
    foreach(Disciplina d in Listar()) 
      if (d.GetMedia() == media) qtd++;
    Disciplina[] aux = new Disciplina[qtd];
    int i = 0;
    foreach(Disciplina d in Listar()) 
      if (d.GetMedia() == media) aux[i++] = d;
    return aux;
  }
  public double IRA() {
    double media = 0;
    int qtd = 0;
    foreach(Disciplina d in Listar()) 
      if (d.GetAprovado()) {
        media += d.GetMedia();
        qtd++;
      }
    if (qtd == 0) return 0;
    return media/qtd;
  }
  public int TotalCH() {
    int ch = 0;
    foreach(Disciplina d in Listar()) 
      if (d.GetAprovado()) ch += d.GetCH();
    return ch;
  }
  public override string ToString() {
    return $"{aluno} {k} disciplina(s)";
  }
}  


class Disciplina : IComparable {
  private string nome, semestre;
  private int media, ch;
  private bool aprovado;
  public Disciplina(string nome, string semestre, int media, int ch) {
    this.nome = nome;
    this.semestre = semestre;
    this.media = media;
    this.ch = ch;
    this.aprovado = media >= 60;
    if (nome == "" || semestre == "" || media < 0 || media > 100 || ch <= 0)
      throw new ArgumentOutOfRangeException();
  }
  public string GetNome() { return nome; }
  public string GetSemestre() { return semestre; }
  public int GetMedia() { return media; }
  public int GetCH() { return ch; }
  public bool GetAprovado() { return aprovado; }

  public void SetNome(string nome) { 
    if (nome == "") throw new ArgumentOutOfRangeException();
    this.nome = nome;
  }
  public void SetSemestre(string semestre) { 
    if (semestre == "") throw new ArgumentOutOfRangeException();
    this.semestre = semestre;
 }
  public void SetMedia(int media) { 
    if (media < 0 || media > 100) throw new ArgumentOutOfRangeException();
    this.media = media;
    this.aprovado = media >= 60;
  }
  public void SetCH(int ch) { 
    if (ch <= 0) throw new ArgumentOutOfRangeException();
    this.ch = ch;
  }
  public override string ToString() {
    if (aprovado) return $"{semestre} {nome} {media} {ch} Aprovado";
    return $"{semestre} {nome} {media} {ch} Reprovado";
  }
  public int CompareTo(object obj) {
    Disciplina x = (Disciplina) obj;
    if (this.semestre == x.semestre) return this.nome.CompareTo(x.nome);
    return this.semestre.CompareTo(x.semestre);
  }
}
