using System; 

public class Program 
{

  public static void Main() 
  {
    Personagem a = new Personagem("Joao", 1, 100, 10, 5);
    Personagem b = new Personagem("Asuna", 1, 100, 90, 40);
    Console.WriteLine(a.Batalha(a, b));
  }
}

public class Personagem
{
  private string nome;
  private int nivel;
  private int saude;
  private int ataque;
  private int cura;

  // CONSTRUTOR
  public Personagem(string nome, int nivel, int saude, int ataque, int cura)
  {
    SetNome(nome);
    SetNivel(nivel);
    SetSaude(saude);
    SetAtaque(ataque);
    SetCura(cura);
  }


  // GETS  
  public string GetNome()
  {
    return nome;
  }

  public int GetNivel()
  {
    return nivel;
  }

  public int GetSaude()
  {
    return saude;
  }

  public int GetAtaque()
  {
    return ataque;
  }

  public int GetCura()
  {
    return cura;
  }

  // SETS
  public void SetNome(string nome)
  {
    this.nome = nome;
  }

  public void SetNivel(int nivel)
  {
    if(nivel == 1)
    {
      this.nivel = nivel;
    }
    else throw new ArgumentOutOfRangeException();
  }

  public void SetSaude(int saude)
  {
    if(saude == 100)
    {
      this.saude = saude;
    }
    else throw new ArgumentOutOfRangeException();
  }

  public void SetAtaque(int ataque)
  {
    if(ataque >= 0 && ataque <=100)
    {
      this.ataque = ataque;
    }
    else throw new ArgumentOutOfRangeException();
  }

  public void SetCura(int cura)
  {
    if(cura >= 0 && cura <=100)
    {
      this.cura = cura;
    }
    else throw new ArgumentOutOfRangeException();
  }
  

  // MÉTODO
  public bool Batalha(Personagem p, Personagem d)
  {
    //situação personagem 1
    p.saude = p.saude - d.ataque;
    p.saude = p.saude + p.cura;

    //situacao personagem 2
    d.saude = d.saude - p.ataque;
    d.saude = d.saude + p.cura;

    // resultado da batalha
    if(p.saude == 0 || d.saude == 0)
    {
    return false;
    }else{
    return true;
    }
  }

  // TO STRING
  public override string ToString() 
  {
    return $"O personagem = {nome}, tem nivel = {nivel}, saude = {saude}, ataque = {ataque} e cura = {cura}";
  }
}