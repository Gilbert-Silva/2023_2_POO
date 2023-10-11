using System;

class Program {
  public static void Main() {
    Random r = new Random();
    Personagem p1 = new Personagem("Um", r.Next(101), r.Next(101));
    Personagem p2 = new Personagem("Dois", r.Next(101), r.Next(101));
    do {
      Console.WriteLine(p1);
      Console.WriteLine(p2);
      Console.WriteLine();
    } while (!p1.Batalha(p2));
    Console.WriteLine(p1);
    Console.WriteLine(p2);
  }
}

class Personagem {
  private string nome;
  private int nivel, saude, ataque, cura;
  public Personagem(string nome, int ataque, int cura) {
    SetNome(nome);
    SetNivel(1);
    SetSaude(100);
    SetAtaque(ataque);
    SetCura(cura);
  }
  public bool Batalha(Personagem p) {
    this.saude += this.cura;
    p.saude += p.cura;
    this.saude -= p.ataque;
    p.saude -= this.ataque;
    if (this.saude <= 0) p.nivel++;
    if (p.saude <= 0) this.nivel++;
    return this.saude <= 0 || p.saude <= 0;
  }
  public string GetNome() => nome;
  public int GetNivel() => nivel;
  public int GetSaude() => saude;
  public int GetAtaque() => ataque;
  public int GetCura() => cura;
  public void SetNome(string nome) {
    this.nome = nome;
  }
  public void SetNivel(int nivel) {
    if (nivel >= 1) this.nivel = nivel;
    else throw new ArgumentOutOfRangeException();
  }
  public void SetSaude(int saude) { 
    if (saude >= 0) this.saude = saude;
    else throw new ArgumentOutOfRangeException();
  }
  public void SetAtaque(int ataque) {
    if (ataque >= 0 && ataque <= 100) this.ataque = ataque;
    else throw new ArgumentOutOfRangeException();
  }
  public void SetCura(int cura) {
    if (cura >= 0 && cura <= 100) this.cura = cura;
    else throw new ArgumentOutOfRangeException();
  }
  public override string ToString() {
    return $"{nome} Nível={nivel} Saúde={saude} Ataque={ataque} Cura={cura}";
  }
}