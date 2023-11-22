using System;
using System.Collections.Generic;

class Produto {
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
  public static void Inserir(Produto p) {
    int id = 0;
    foreach(Produto obj in produtos) 
      if (obj.Id > id) id = obj.Id;
    p.Id = id + 1;
    produtos.Add(p);
  }
  public static List<Produto> Listar() {
    return produtos;
  }
  public static void Atualizar(Produto p) {
    foreach(Produto obj in produtos) 
      if (obj.Id == p.Id) {
        obj.Nome = p.Nome;
        obj.Preco = p.Preco;
        obj.Estoque = p.Estoque;
      }
  }
  public static void Excluir(Produto p) {
    Produto aux = null;
    foreach(Produto obj in produtos) 
      if (obj.Id == p.Id) aux = obj;
    if (aux != null) produtos.Remove(aux);
  }
}