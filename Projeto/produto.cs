using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public class Produto {
  public int Id { get; set; }
  public string Nome { get; set; }
  public double Preco { get; set; }
  public int Estoque { get; set; }
  public override string ToString() {
    return $"{Id} {Nome} {Preco:f2} {Estoque}";
  }
}

static class NProduto {
  private static List<Produto> produtos = new List<Produto>();
  public static void ToXML() {
    XmlSerializer xml = new XmlSerializer(typeof(List<Produto>));
    StreamWriter f = new StreamWriter("Produto.xml");
    xml.Serialize(f, produtos);
    f.Close();
  }
  public static void FromXML() {
    try {
      XmlSerializer xml = new XmlSerializer(typeof(List<Produto>));
      StreamReader f = new StreamReader("Produto.xml");
      produtos = (List<Produto>) xml.Deserialize(f);
      f.Close();
    }
    catch (FileNotFoundException)
    {
    }
  }
  public static void ToCSV() {
    StreamWriter f = new StreamWriter("Produto.csv");
    foreach(Produto p in produtos)
      f.WriteLine($"{p.Id};{p.Nome};{p.Preco};{p.Estoque}");
    f.Close();
  }
  public static void FromCSV() {
    StreamReader f = new StreamReader("Produto.csv");
    string s = f.ReadLine();
    while (s != null) {
      string[] v = s.Split(';');
      produtos.Add(new Produto { Id = int.Parse(v[0]), 
        Nome = v[1], Preco = double.Parse(v[2]), 
        Estoque =  int.Parse(v[3]) });
      s = f.ReadLine();
    }
    f.Close();
  }
  public static void Inserir(Produto p) {
    FromXML();
    int id = 0;
    foreach(Produto obj in produtos) 
      if (obj.Id > id) id = obj.Id;
    p.Id = id + 1;
    produtos.Add(p);
    ToXML();
  }
  public static List<Produto> Listar() {
    FromXML();
    return produtos;
  }
  public static void Atualizar(Produto p) {
    FromXML();
    foreach(Produto obj in produtos) 
      if (obj.Id == p.Id) {
        obj.Nome = p.Nome;
        obj.Preco = p.Preco;
        obj.Estoque = p.Estoque;
      }
    ToXML();
  }
  public static void Excluir(Produto p) {
    FromXML();
    Produto aux = null;
    foreach(Produto obj in produtos) 
      if (obj.Id == p.Id) aux = obj;
    if (aux != null) produtos.Remove(aux);
    ToXML();
  }
}