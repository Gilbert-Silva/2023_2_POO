using System;

class Program {
  public static void Main() {
    Console.WriteLine("Opa"); 
  }
}

class Disciplina : IComparable{
    private string nome, semestre;
    private int media, ch;
    private bool aprovado;
    public Disciplina(string n, string s, int m, int c){
        nome = n;
        semestre = s;
        media = m;
        ch = c;
    }
    public string Nome{
        get{return nome;}
        set{nome = value != "" ? value : throw new ArgumentOutOfRangeException();}
    }
    public string Semestre{
        get{return semestre;}
        set{semestre = value.Length != 6 ? value : throw new ArgumentOutOfRangeException();}
    }
    public int Media{
        get{return media;}
        set{media = value > 100 || value < 0 ? throw new ArgumentOutOfRangeException() : value;}
    }
    public int Ch{
        get{return ch;}
        set{ch = value;}
    }
    public bool Aprovado{
        get{return aprovado;}
        set{aprovado = false;}
    }
    public int CompareTo(object obj){
        if (Semestre == ((Disciplina)obj).Semestre) return Nome.CompareTo(((Disciplina)obj).Nome);
        return Semestre.CompareTo(((Disciplina)obj).Semestre);
    }
    public override string ToString(){
        if (Media >= 60) aprovado = true;
        string aprovou = (aprovado) ? "Aprovado" : "Reprovado";
        return $"Disciplina - {Nome}\nSemestre - {Semestre}\nMédia - {Media}\nCarga horária - {Ch}\nSituação - {aprovou}\n";
    }
}
