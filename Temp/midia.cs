using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public class Midia : IModel {
  public int Id { get; set; }
  public string Nome { get; set; }
  public override string ToString() {
    return $"{Id} {Nome}";
  }
}

public class Filme : Midia {
  public string Estudio { get; set; }
}
public class Livro : Midia {
  public string Editora { get; set; }
}
class NFilme : Model<Filme>{
}
class NLivro : Model<Livro>{
}
class NMidia : Model<Midia> 
{
}

/*
Filme f = new Filme { Nome = "Filme", Estudio = "Estudio" };
Livro l = new Livro { Nome = "Filme", Editora = "Editora" };
(new NFilme()).Inserir(f);
(new NLivro()).Inserir(l);
(new NMidia()).Inserir(l);
*/
