using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public class Produto {
  public int Id { get; set; }
  public string Nome { get; set; }
  public double Preco { get; set; }
  public int Estoque { get; set; }
  public int IdCategoria { get; set; }
  public override string ToString() {
    return $"{Id} - {Nome} R$ {Preco:f2} - {Estoque}";
  }
}

class NProduto {
  private List<Produto> produtos = new List<Produto>();
  public void ToXML() {
    XmlSerializer xml = new XmlSerializer(typeof(List<Produto>));
    StreamWriter f = new StreamWriter("Produto.xml");
    xml.Serialize(f, produtos);
    f.Close();
  }
  public void FromXML() {
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
  public void Inserir(Produto p) {
    FromXML();
    int id = 0;
    foreach(Produto obj in produtos) 
      if (obj.Id > id) id = obj.Id;
    p.Id = id + 1;
    produtos.Add(p);
    ToXML();
  }
  public List<Produto> Listar() {
    FromXML();
    return produtos;
  }
  public Produto Listar(int id) {
    FromXML();
    foreach(Produto obj in produtos) 
      if (obj.Id == id) return obj;
    return null;
  }
  public void Atualizar(Produto p) {
    FromXML();
    Produto obj = Listar(p.Id);
    if (obj != null) {
      produtos.Remove(obj);
      produtos.Add(p);
    }
    ToXML();
  }
  public void Excluir(Produto p) {
    FromXML();
    Produto obj = Listar(p.Id);
    if (obj != null) produtos.Remove(obj);
    ToXML();
  }
}